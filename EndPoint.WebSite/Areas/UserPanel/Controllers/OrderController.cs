using EndPoint.WebSite.Areas.UserPanel.Models.Order.Index;
using EndPoint.WebSite.Areas.UserPanel.Models.Order.ShowOrderInfo;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderFacad _orderFacad;
        private readonly ClaimUtility _claimUtility;
        public OrderController(IOrderFacad orderFacad, ClaimUtility claimUtility)
        {
            _claimUtility = claimUtility;
            _orderFacad = orderFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userId = _claimUtility.GetUserId(User);
            var res = _orderFacad.GetOrdersForUserPanelService.Execute(userId);
            List<OrdersViewModel> model = new List<OrdersViewModel>();
            if (res.IsSuccess)
            {
                model = res.Data.Select(o => new OrdersViewModel
                {
                    Id = o.Id,
                    Finished = o.Finished,
                    FinallyDate = o.FinallyDate,
                    PaidAmount = o.PaidAmount,
                    State = o.State,
                    totalAmount = o.totalAmount,
                    OrderDetails = o.OrderDetails.Select(od => new Models.Order.Index.OrderDetailViewModel
                    {
                        Id = od.Id,
                        Price = od.Price,
                        Count = od.Count,
                        Title = od.Title,
                        DiscountAmount = od.DiscountAmount,
                        PriceWithDiscount = od.PriceWithDiscount
                    }).ToList()
                }).ToList();
            }

            return View(model);
        }
        
        [HttpGet]
        public IActionResult ShowOrderInfo(int orderId)
        {
            var res = _orderFacad.GetOrderForUserPanelService.Execute(orderId);
            ShowOrderInfoViewModel model = new ShowOrderInfoViewModel();
            if (res.IsSuccess)
            {
                model = new ShowOrderInfoViewModel()
                {
                    Id = res.Data.Id,
                    Address = res.Data.Address,
                    PostCode = res.Data.PostCode,
                    ReceiverName = res.Data.ReceiverName,
                    ReceiverPhone = res.Data.ReceiverPhone,
                    totalAmount = res.Data.totalAmount,
                    OrderDetails = res.Data.OrderDetails.Select(od => new Models.Order.ShowOrderInfo.OrderDetailViewModel
                    {
                        Id = od.Id,
                        Price = od.Price,
                        Count = od.Count,
                        Title = od.Title,
                        DiscountAmount = od.DiscountAmount,
                        PriceWithDiscount = od.PriceWithDiscount
                    }).ToList()
                };
            }
            return View(model);
        }

    }
}
