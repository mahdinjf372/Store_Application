using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;

namespace Store_Application.Application.Services.Users.Commands.RemoveUserForAdmin
{
    public class RemoveUserForAdminService : IRemoveUserForAdminService
    {
        private readonly IDataBaseContext _db;
        public RemoveUserForAdminService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto Execute(int userId)
        {
            User user = _db.Users.Find(userId);
            user.isRemoved = true;
            user.RemovedTime = DateTime.Now;
            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کاربر با موفقیت حذف شد"
            };
        }
    }
}
