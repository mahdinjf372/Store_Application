using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.IsExistEmail
{
    public interface IisExistEmailService
    {
        ResultDto<bool> Execute(string email);
    }

    public class isExistEmailService : IisExistEmailService
    {
        private readonly IDataBaseContext _db;
        public isExistEmailService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(string email)
        {
            return new ResultDto<bool>
            {
                Data = _db.Users.Any(u => u.Email.Equals(email)),
                IsSuccess = true,
                Message = "عملیات جستوجوی دیتابیس با موفقیت انجام شد"
            };
        }
    }
}
