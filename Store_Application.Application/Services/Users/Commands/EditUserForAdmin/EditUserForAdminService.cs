using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;

namespace Store_Application.Application.Services.Users.Commands.EditUserForAdmin
{
    public class EditUserForAdminService : IEditUserForAdminService
    {
        private readonly IDataBaseContext _db;
        public EditUserForAdminService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto Execute(RequestEditUserForAdminDto req)
        {
            User user = _db.Users.Find(req.Id);
            user.Address = req.Address;
            user.age = req.age;
            user.FullName = req.FullName;
            user.Phone = req.Phone;
            user.RoleId = req.RoleId;
            user.UpdateTime = DateTime.Now;
            user.Username = req.Username;

            if (!string.IsNullOrEmpty(req.Password))
            {
                user.Password = PasswordHelper.HashPassword(req.Password);
            }

            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "اطلاعات كاربر با موفقيت ويرايش شد"
            };
        }
    }
}
