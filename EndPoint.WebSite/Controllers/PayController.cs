using System;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Checkout.FinalOrderInfo;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Domain.Entities.Order;
using Store_Application.Persistence.Contexts;

namespace EndPoint.WebSite.Controllers
{
    [Authorize]
    public class PayController : Controller
    {
        private readonly CookiesManager _cookiesManager;
        private readonly ClaimUtility _claimUtility;
        private readonly ICartFacad _cartFacad;
        private readonly IOrderFacad _orderFacad;
        private readonly IRequestPayFacad _requestPayFacad;
        private readonly IDataBaseContext _db;

        public PayController(CookiesManager cookiesManager
            , ClaimUtility claimUtility
            , ICartFacad cartFacad
            , IOrderFacad orderFacad
            , IRequestPayFacad requestPayFacad
            , IDataBaseContext db
             )
        {
            _cookiesManager = cookiesManager;
            _claimUtility = claimUtility;
            _cartFacad = cartFacad;
            _orderFacad = orderFacad;
            _requestPayFacad = requestPayFacad;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            int userId = _claimUtility.GetUserId(User);
            Guid browserId = _cookiesManager.GetBrowserId(HttpContext);
            var order = _orderFacad.GetOrderForPayService.Execute(userId);

            if (order.Data.TotalAmount > 0)
            {
                var requestPay = _requestPayFacad.AddRequestPayService.Execute(userId, order.Data.TotalAmount);
                var payment = new ZarinpalSandbox.Payment((int)order.Data.TotalAmount);
                var request = await payment.PaymentRequest($"پرداخت بابت فاکتور شماره DKC-{requestPay.Data.RequestPayId}",
                    $"https://localhost:5001/Pay/Verify?guid=" + requestPay.Data.guid,
                    requestPay.Data.Email);

                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + request.Authority);
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }

        }

        public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        {

            var requestPay = _requestPayFacad.GetRequestPayService.Execute(guid);
            string Authority = HttpContext.Request.Query["Authority"];
            string Status = HttpContext.Request.Query["Status"];

            int UserId = _claimUtility.GetUserId(User);
            var order = _orderFacad.GetOrderForPayService.Execute(UserId);

            if (order.IsSuccess)
            {
                var payment = new ZarinpalSandbox.Payment((int)order.Data.TotalAmount);
                var request = payment.Verification(Authority);
                if (Status == "OK")
                {
                    _orderFacad.FinalizeOrderService.Execute(order.Data.Id, authority, request.Result.RefId);
                    var finallyOrder = GetFinallyOrder(authority, order.Data.Id);
                    ViewBag.RefId = request.Result.RefId;
                    return View("/Views/Checkout/FinalOrderInfo.cshtml", new FinalOrderInfoViewModel
                    {
                        RequestPayId = requestPay.Data.Id,
                        FinallyDate = DateTime.Now,
                        PayedAmount = requestPay.Data.Amount,
                        RefId = request.Result.RefId.ToString(),
                        orderDetails = finallyOrder.OrderDetails.Select(od => new OrderDetailViewModel
                        {
                            Title = od.Product.Title,
                            Count = od.Count,
                            DiscountAmount = od.Product.DiscountAmount,
                            Price = od.Product.Price,
                            PriceWithDiscount = od.Product.Price - od.Product.DiscountAmount,
                            SumPrice = od.Count * (od.Product.Price - od.Product.DiscountAmount),
                        }).ToList(),
                    });
                }
                return View("/Views/Checkout/_FailedVerificationPayment.cshtml");

            }

            return RedirectToAction("Index", "Home");

        }

        private Order GetFinallyOrder(string authority, int orderId)
        {
            var reqPay = _db.RequestPays.Include(r => r.Orders)
                .ThenInclude(o => o.OrderDetails)
                .ThenInclude(o => o.Product)
                .Where(r => r.Authority == authority)
                .SingleOrDefault();

            return reqPay.Orders.SingleOrDefault(o => o.Id == orderId);
        }
    }
}
