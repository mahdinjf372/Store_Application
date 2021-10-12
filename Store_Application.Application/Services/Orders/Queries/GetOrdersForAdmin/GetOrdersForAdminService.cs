using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public class GetOrdersForAdminService : IGetOrdersForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetOrdersForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetOrdersForAdminDto> Execute(RequestGetOrderForAdminDto req)
        {
            try
            {
                var query = _db.Orders.IgnoreQueryFilters().AsQueryable();

                query = ApplyFilters(query, req);

                var ordersViewModel = query
                    .Include(o => o.RequestPay)
                    .Select(c => new OrderForAdminDto()
                    {
                        Id = c.Id,
                        UserId = c.UserId,
                        OrderInsertTime = c.InsertTime,
                        State = (OrderStatesDto)c.OrderState,
                        PayId = c.RequestPayId,
                        isPay = c.RequestPay.IsPay,
                        Authority = c.RequestPay.Authority,
                        PayAmount = c.RequestPay.Amount,
                        PayDate = c.RequestPay.PayDate,
                        RefId = c.RequestPay.RefId
                    })
                    .ToPaged(req.Page, req.Take, out var rowCount).ToList();

                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int)Math.Ceiling(ee);

                var resultGetUsers = new ResultGetOrdersForAdminDto()
                {
                    CurrentPage = req.Page,
                    PageCount = pageCount,
                    Orders = ordersViewModel
                };

                return new ResultDto<ResultGetOrdersForAdminDto>()
                {
                    Data = resultGetUsers,
                    IsSuccess = true,
                    Message = "عملیات واکشی سفارشات با موفقیت انجام شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetOrdersForAdminDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی سفارشات با شکست مواجه شد"
                };
            }

        }

        private IQueryable<Domain.Entities.Order.Order> ApplyFilters(IQueryable<Domain.Entities.Order.Order> query, RequestGetOrderForAdminDto req)
        {
            var res = query;

            if (req.OrderId != null)
            {
                res = res.Where(c => c.Id == req.OrderId).AsQueryable();
            }
            if (req.UserId != null)
            {
                res = res.Where(c => c.UserId == req.UserId).AsQueryable();
            }
            if (req.State != null && req.State != OrderStatesDto.None)
            {
                res = res.Where(c => c.OrderState == (OrderState)req.State).AsQueryable();
            }
            if (req.FromDateOrder != null)
            {
                DateTime fromDate = (DateTime)req.FromDateOrder;
                res = res.Where(c => c.InsertTime >= fromDate.ToMiladi()).AsQueryable();
            }
            if (req.ToDateOrder != null)
            {
                DateTime toDate = (DateTime)req.ToDateOrder?.ToMiladi();
                DateTime endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);

                res = res.Where(c => c.InsertTime <= endDate).AsQueryable();
            }
            if (req.FromDatePay != null)
            {
                DateTime fromDate = (DateTime)req.FromDatePay;
                res = res.Where(c => c.RequestPay.PayDate >= fromDate.ToMiladi()).AsQueryable();
            }
            if (req.ToDatePay != null)
            {
                DateTime toDate = (DateTime)req.ToDatePay?.ToMiladi();
                DateTime endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);

                res = res.Where(c => c.RequestPay.PayDate <= endDate).AsQueryable();
            }

            return res;
        }
    }
}


