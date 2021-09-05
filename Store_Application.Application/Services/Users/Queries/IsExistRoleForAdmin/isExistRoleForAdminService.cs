using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.IsExistRoleForAdmin
{
    public class isExistRoleForAdminService : IisExistRoleForAdminService
    {
        private readonly IDataBaseContext _db;
        public isExistRoleForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            return new ResultDto<bool>()
            {
                Data = _db.Roles.Any(u => u.Id.Equals(id)),
                IsSuccess = true,
                Message = "ديتابيس با موفقيت بررسي شد"
            };
        }
    }
}
