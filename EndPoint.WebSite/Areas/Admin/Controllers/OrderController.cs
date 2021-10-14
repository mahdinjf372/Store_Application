using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Areas.Admin.Models.Order.Common;
using EndPoint.WebSite.Areas.Admin.Models.Order.LoadOrders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + "," + nameof(Roles.Operator))]
    public class OrderController : Controller
    {
        private readonly IOrderFacad _orderFacad;
        public OrderController(IOrderFacad orderFacad)
        {
            _orderFacad = orderFacad;
        }

        public IActionResult Index(RequestLoadOrdersViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = req.Searchkey;

            req.BinSearchValuesToFields();

            return View(req);
        }

        [HttpPost]
        public PartialViewResult LoadOrders(RequestLoadOrdersViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = $"{req.OrderId},{req.UserId},{(int)req.State},{req.FromDateOrder},{req.ToDateOrder},{req.FromDatePay},{req.ToDatePay}";

            var res = _orderFacad.GetOrdersForAdminService.Execute(new RequestGetOrderForAdminDto()
            {
                Page = req.Page,
                Take = req.Take,
                OrderId = req.OrderId,
                UserId = req.UserId,
                State = (OrderStatesDto)req.State,
                FromDateOrder = req.FromDateOrder,
                ToDateOrder = req.ToDateOrder,
                FromDatePay = req.FromDatePay,
                ToDatePay = req.ToDatePay,
            });

            var model = new LoadOrdersViewModel();

            if (res.IsSuccess)
            {
                model.Orders = res.Data.Orders.Select(o => new OrderViewModel()
                {
                    Id = o.Id,
                    OrderInsertTime = o.OrderInsertTime,
                    State = (OrderStatesViewModel)o.State,
                    Authority = o.Authority,
                    isPay = o.isPay,
                    PayAmount = o.PayAmount,
                    PayDate = o.PayDate,
                    PayId = o.PayId,
                    RefId = o.RefId,
                    UserId = o.UserId

                }).ToList();
            }

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("/Areas/Admin/Views/Order/_LoadOrders.cshtml", model);
        }
    }
}
