using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.RequestPay.Commands.AddRequestPay
{
    public class AddRequestPayService : IAddRequestPayService
    {
        private readonly IDataBaseContext _db;
        public AddRequestPayService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultAddRequestPayDto> Execute(int userId, decimal totalAmount)
        {
            var user = _db.Users.Find(userId);

            var order = _db.Orders.Include(o=> o.RequestPay).Where(o => o.UserId.Equals(userId) && !o.RequestPay.IsPay).SingleOrDefault();

            order.RequestPay.Amount = totalAmount;
            order.RequestPay.Guid = Guid.NewGuid();
            order.RequestPay.IsPay = false;
            order.RequestPay.UserId = user.Id;
            
            _db.RequestPays.Update(order.RequestPay);
            _db.SaveChanges();

            return new ResultDto<ResultAddRequestPayDto>()
            {
                Data = new ResultAddRequestPayDto
                {
                    guid = order.RequestPay.Guid,
                    Amount = order.RequestPay.Amount,
                    Email = user.Email,
                    RequestPayId = order.RequestPay.Id,
                },
                IsSuccess = true,
            };
        }
    }
}
