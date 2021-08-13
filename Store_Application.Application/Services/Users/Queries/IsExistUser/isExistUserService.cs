using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.IsExistUser
{
    public class isExistUserService : IisExistUserService
    {
        private readonly IDataBaseContext _db;
        public isExistUserService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            return new ResultDto<bool>()
            {
                Data = _db.Users.Any(u => u.Id.Equals(id)),
                IsSuccess = true,
                Message = "كاربري با اين مشخصات يافت شد"
            };
        }
    }
}
