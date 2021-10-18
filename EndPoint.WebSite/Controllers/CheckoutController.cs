using AutoMapper;
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
        private readonly IMapper _mapper;
        public CheckoutController(IOrderFacad orderFacad, ClaimUtility claimUtility, IMapper mapper)
        {
            _orderFacad = orderFacad;
            _claimUtility = claimUtility;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var userId = _claimUtility.GetUserId(User);
            var res = _orderFacad.GetOrderForSiteService.Execute(userId);

            if (res.IsSuccess)
            {
                CheckoutViewModel model = _mapper.Map<CheckoutViewModel>(res.Data);

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

                if (!model.IsSuccess)
                {
                    return Redirect("/Cart");
                }

                req.TotalAmount = model.Data.TotalAmount;
                req.OrderDetails = _mapper.Map<List<OrderDetailViewModel>>(model.Data.OrderDetails);
                
                return View(req);
            }

            var serviceRequest = _mapper.Map<RequestEditOrerForSiteDto>(req);
            serviceRequest.UserId = userId;

            var res = _orderFacad.EditOrderForSiteService.Execute(serviceRequest);

            return RedirectToAction("Index","Pay");

        }

    }
}
