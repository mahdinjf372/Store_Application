using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel
{
    public class GetOrdersForUserPanelService : IGetOrdersForUserPanelService
    {
        private readonly IDataBaseContext _db;
        public GetOrdersForUserPanelService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<List<ResultGetOrderForUserPanel>> Execute(int userId)
        {
            try
            {

                var ClosedOrders = _db.Orders
                    .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                    .Include(o => o.RequestPay)
                    .Where(o => o.UserId == userId && o.RequestPay.IsPay)
                    .Select(o => new ResultGetOrderForUserPanel
                    {
                        Id = o.Id,
                        Finished = o.RequestPay.IsPay,
                        FinallyDate = o.RequestPay.PayDate,
                        PaidAmount = o.RequestPay.Amount,
                        State = o.OrderState,
                        totalAmount = o.OrderDetails.Sum(od => od.Count * od.Price),
                        OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
                        {
                            Id = od.Id,
                            Price = od.Price,
                            Count = od.Count,
                            Title = od.Product.Title
                        }).ToList()
                    }).ToList();

                var OpenOrder = _db.Orders
                    .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                    .Include(o => o.RequestPay)
                    .Where(o => o.UserId == userId && !o.RequestPay.IsPay)
                    .Select(o => new ResultGetOrderForUserPanel
                    {
                        Id = o.Id,
                        Finished = false,
                        FinallyDate = null,
                        PaidAmount = 0,
                        State = o.OrderState,
                        totalAmount = o.OrderDetails.Sum(od => od.Count * (od.Product.Price - od.Product.DiscountAmount)),
                        OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
                        {
                            Id = od.Id,
                            Price = od.Product.Price,
                            DiscountAmount = od.Product.DiscountAmount,
                            PriceWithDiscount = od.Product.Price - od.Product.Price,
                            Count = od.Count,
                            Title = od.Product.Title
                        }).ToList()
                    }).SingleOrDefault();

                if (OpenOrder != null)
                    ClosedOrders.Add(OpenOrder);

                return new ResultDto<List<ResultGetOrderForUserPanel>>
                {
                    Data = ClosedOrders,
                    IsSuccess = true,
                    Message = "سفارشات با موفقیت واکشی شدند"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<List<ResultGetOrderForUserPanel>>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "سفارشات یافت نشد"
                };
            }
        }
    }
}
