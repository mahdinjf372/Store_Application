using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetActivationCodeByEmail
{
    public class GetActivationCodeByEmailService : IGetActivationCodeByEmailService
    {
        private readonly IDataBaseContext _db;
        public GetActivationCodeByEmailService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<string> Execute(string email)
        {
            var ActivationCode = _db.Users.SingleOrDefault(u => u.Email.Equals(email)).ActiveCode;

            return new ResultDto<string>
            {
                Data = ActivationCode,
                IsSuccess = true,
                Message = "عملیات واکشی کد فعالسازی از دیتابیس با موفقیت انجام شد"
            };
        }
    }
}
