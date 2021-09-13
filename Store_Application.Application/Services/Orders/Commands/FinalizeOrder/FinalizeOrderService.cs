using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Commands.FinalizeOrder
{
    public class FinalizeOrderService : IFinalizeOrderService
    {
        private readonly IDataBaseContext _db;
        public FinalizeOrderService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int orderId, string authority, long RefId)
        {

            try
            {
                var order = _db.Orders
                .Include(o => o.RequestPay)
                .Include(o => o.OrderDetails)
                .ThenInclude(od=> od.Product)
                .Include(o => o.User)
                .ThenInclude(o => o.Carts)
                .Where(o => o.Id.Equals(orderId)).Single();

                order.OrderState = Domain.Enums.OrderState.Processing;
                order.RequestPay.Authority = authority;
                order.RequestPay.RefId = RefId;
                order.RequestPay.IsPay = true;
                order.RequestPay.PayDate = DateTime.Now;
                order.UpdateTime = DateTime.Now;
                order.RequestPay.UpdateTime = DateTime.Now;
                order.User.Carts.SingleOrDefault(c => c.Finished == false).UpdateTime = DateTime.Now;
                order.User.Carts.SingleOrDefault(c => c.Finished == false).Finished = true;

                foreach (var od in order.OrderDetails)
                {
                    od.Product.Inventory = od.Product.Inventory - od.Count;
                    od.Price = (int)(od.Product.Price - od.Product.DiscountAmount);
                }

                _db.SaveChanges();

                return new ResultDto<bool>
                {
                    Data = true,
                    IsSuccess = true,
                    Message = "پرداخت شما با موفقیت انجام شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "پرداخت شما با شکست مواجه شد"
                };
            }
        }
    }
}
