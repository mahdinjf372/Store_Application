using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

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
            Domain.Entities.Finance.RequestPay requestPay = new Domain.Entities.Finance.RequestPay()
            {
                Amount = totalAmount,
                Guid = Guid.NewGuid(),
                IsPay = false,
                User = user,
                InsertTime = DateTime.Now,

            };
            _db.RequestPays.Add(requestPay);
            _db.SaveChanges();

            return new ResultDto<ResultAddRequestPayDto>()
            {
                Data = new ResultAddRequestPayDto
                {
                    guid = requestPay.Guid,
                    Amount = requestPay.Amount,
                    Email = user.Email,
                    RequestPayId = requestPay.Id,
                },
                IsSuccess = true,
            };
        }
    }
}
