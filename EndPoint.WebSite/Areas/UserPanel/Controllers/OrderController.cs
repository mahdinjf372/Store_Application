using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Order.Index;
using EndPoint.WebSite.Areas.UserPanel.Models.Order.ShowOrderInfo;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize(Roles = nameof(Roles.Customer))]

    public class OrderController : Controller
    {
        private readonly IOrderFacad _orderFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;
        public OrderController(IOrderFacad orderFacad,
            ClaimUtility claimUtility,
            IMapper mapper)
        {
            _claimUtility = claimUtility;
            _orderFacad = orderFacad;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userId = _claimUtility.GetUserId(User);
            var res = _orderFacad.GetOrdersForUserPanelService.Execute(userId);
            List<OrdersViewModel> model = new List<OrdersViewModel>();
            if (res.IsSuccess)
            {
                model = _mapper.Map<List<OrdersViewModel>>(res.Data);
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
                model = _mapper.Map<ShowOrderInfoViewModel>(res.Data);
            }
            return View(model);
        }

    }
}
