using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;

namespace Store_Application.Application.Services.Users.Commands.ChangePasswordForUserPanel
{
    public class ChangePasswordForUserPanelService : IChangePasswordForUserPanelService
    {
        private readonly IDataBaseContext _db;
        public ChangePasswordForUserPanelService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto Execute(RequestChangePasswordForUserPanelDto req)
        {
            User user = _db.Users.Find(req.Id);
            user.Password = PasswordHelper.HashPassword(req.Password);
            user.UpdateTime = DateTime.Now;

            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "پسورد كاربر با موفقيت ويرايش شد"
            };
        }
    }
}
