using EndPoint.WebSite.Models.Checkout.Index;
using EndPoint.WebSite.Utilities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Orders.Commands.EditOrderForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IOrderFacad _orderFacad;
        private readonly ClaimUtility _claimUtility;
        public CheckoutController(IOrderFacad orderFacad, ClaimUtility claimUtility)
        {
            _orderFacad = orderFacad;
            _claimUtility = claimUtility;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var userId = _claimUtility.GetUserId(User);
            var res = _orderFacad.GetOrderForSiteService.Execute(userId);

            if (res.IsSuccess)
            {
                CheckoutViewModel model = new CheckoutViewModel()
                {
                    Address = res.Data.Address,
                    Description = res.Data.Description,
                    PostCode = res.Data.PostCode,
                    ReceiverName = res.Data.ReceiverName,
                    ReceiverPhone = res.Data.ReceiverPhone,
                    TotalAmount = res.Data.TotalAmount,
                    OrderDetails = res.Data.OrderDetails.Select(od => new OrderDetailViewModel
                    {
                        Id = od.Id,
                        Count = od.Count,
                        DiscountAmount = od.DiscountAmount,
                        Price = od.Price,
                        Title = od.Title,
                        SumPrice = od.SumPrice,
                        ProductId = od.ProductId,
                        PriceWithDiscount = od.PriceWithDiscount,
                    }).ToList(),
                };
                return View(model);
            }

            return Redirect("/Cart/Index");

        }

        [HttpPost]
        [Authorize]
        public IActionResult Index(CheckoutViewModel req)
        {

            var RequestValidation = new CheckoutViewModelValidator();
            var Validation = RequestValidation.Validate(req);
            Validation.AddToModelState(ModelState, null);

            var userId = _claimUtility.GetUserId(User);

            if (!ModelState.IsValid)
            {
                
                var model = _orderFacad.GetOrderForSiteService.Execute(userId);

                if (model.IsSuccess)
                {
                    req.TotalAmount = model.Data.TotalAmount;
                    req.OrderDetails = model.Data.OrderDetails.Select(od => new OrderDetailViewModel
                    {
                        Id = od.Id,
                        Count = od.Count,
                        DiscountAmount = od.DiscountAmount,
                        Price = od.Price,
                        Title = od.Title,
                        SumPrice = od.SumPrice,
                        ProductId = od.ProductId,
                        PriceWithDiscount = od.PriceWithDiscount,
                    }).ToList();
                }
                else
                {
                    return Redirect("/Cart");
                }



                return View(req);
            }

            var res = _orderFacad.EditOrderForSiteService.Execute(new RequestEditOrerForSiteDto
            {
                UserId = userId,
                Address = req.Address,
                Description = req.Description,
                PostCode = req.PostCode,
                ReceiverName = req.ReceiverName,
                ReceiverPhone = req.ReceiverPhone
            });

            return RedirectToAction("Index","Pay");

        }

    }
}
