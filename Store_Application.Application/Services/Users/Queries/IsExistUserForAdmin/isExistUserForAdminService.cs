using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.IsExistUserForAdmin
{
    public class isExistUserForAdminService : IisExistUserForAdminService
    {
        private readonly IDataBaseContext _db;
        public isExistUserForAdminService(IDataBaseContext db)
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
