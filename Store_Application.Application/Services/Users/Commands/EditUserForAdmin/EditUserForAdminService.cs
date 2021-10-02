using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;

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
            user.UpdateTime = DateTime.Now;
            user.Username = req.Username;

            if (!string.IsNullOrEmpty(req.Password))
            {
                user.Password = PasswordHelper.HashPassword(req.Password);
            }

            _db.Users.Update(user);
            _db.SaveChanges();

            UpdateRoles(req.Roles, user.Id);

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "اطلاعات كاربر با موفقيت ويرايش شد"
            };
        }

        private void UpdateRoles(List<EditRoleDto> roles, int userId)
        {

            var oldUserRoles = _db.UserRoles.Where(ur => ur.UserId.Equals(userId)).ToList();

            foreach (var role in oldUserRoles)
            {
                if (!roles.Any(r=> r.Id.Equals(role.RoleId)))
                {
                    role.isRemoved = true;
                    role.RemovedTime = DateTime.Now;
                    _db.UserRoles.Update(role);
                    _db.SaveChanges();
                }
            }
            
            List<UserRoles> newUserRoles = new List<UserRoles>();
            foreach (var role in roles)
            {
                if (!oldUserRoles.Any(ur => ur.RoleId.Equals(role.Id)))
                {
                    newUserRoles.Add(new UserRoles
                    {
                        RoleId = role.Id,
                        InsertTime = DateTime.Now,
                        UserId = userId
                    });
                }
            }
            _db.UserRoles.AddRange(newUserRoles);
            _db.SaveChanges();
        }
    }
}
