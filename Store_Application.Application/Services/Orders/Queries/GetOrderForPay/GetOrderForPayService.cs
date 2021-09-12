using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForPay
{
    public class GetOrderForPayService : IGetOrderForPayService
    {
        private readonly IDataBaseContext _db;
        public GetOrderForPayService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetOrderForPayDto> Execute(int userId)
        {
            try
            {
                var order = _db.Orders
                           .Include(o => o.RequestPay)
                           .Include(o => o.OrderDetails)
                           .ThenInclude(od => od.Product)
                           .Where(o => !o.RequestPay.IsPay && o.OrderState.Equals(OrderState.WaitingForPay) && o.UserId.Equals(userId))
                           .SingleOrDefault();

                var res = new ResultGetOrderForPayDto();
                res.TotalAmount = order.OrderDetails.Sum(od => od.Count * (od.Product.Price - od.Product.DiscountAmount));
                res.Id = order.Id;
                return new ResultDto<ResultGetOrderForPayDto>
                {
                    Data = res,
                    IsSuccess= true
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetOrderForPayDto>
                {
                    Data = null,
                    IsSuccess = false,
                };
            }
        }
    }
}
