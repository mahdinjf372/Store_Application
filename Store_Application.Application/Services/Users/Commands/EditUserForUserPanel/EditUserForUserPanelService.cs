using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;

namespace Store_Application.Application.Services.Users.Commands.EditUserForUserPanel
{
    public class EditUserForUserPanelService : IEditUserForUserPanelService
    {
        private readonly IDataBaseContext _db;
        public EditUserForUserPanelService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto Execute(RequestEditUserForUserPanelDto req)
        {
            User user = _db.Users.Find(req.Id);
            user.Address = req.Address;
            user.age = req.age;
            user.FullName = req.FullName;
            user.Phone = req.Phone;
            user.UpdateTime = DateTime.Now;

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
