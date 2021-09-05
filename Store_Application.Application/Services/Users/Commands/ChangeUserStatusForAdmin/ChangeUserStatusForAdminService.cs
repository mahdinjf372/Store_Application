using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Users.Commands.ChangeUserStatusForAdmin
{
    public class ChangeUserStatusForAdminService : IChangeUserStatusForAdminService
    {
        private readonly IDataBaseContext _db;
        public ChangeUserStatusForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int userId)
        {
            var user = _db.Users.Find(userId);
            user.isActive = !user.isActive;
            user.UpdateTime = DateTime.Now;

            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto<bool>()
            {
                Data = user.isActive,
                IsSuccess = true,
                Message = "وضعیت کاربر با موفقیت در دیتابیس تغییر کرد"
            };
        }
    }
}
