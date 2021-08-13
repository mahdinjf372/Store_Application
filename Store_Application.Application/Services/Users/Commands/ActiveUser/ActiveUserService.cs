using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Commands.ActiveUser
{
    public class ActiveUserService : IActiveUserService
    {
        private readonly IDataBaseContext _db;
        public ActiveUserService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(string activationCode)
        {
            var user = _db.Users.Single(u => u.ActiveCode.Equals(activationCode));

            user.isActive = true;
            user.ActiveCode = Guid.NewGuid().ToString();
            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "عملیات فعالسازی کاربر با موفقیت انجام شد"
            };

        }
    }
}
