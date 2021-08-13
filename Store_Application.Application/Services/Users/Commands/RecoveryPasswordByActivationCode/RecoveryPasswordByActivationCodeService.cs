using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Commands.RecoveryPasswordByActivationCode
{
    public class RecoveryPasswordByActivationCodeService : IRecoveryPasswordByActivationCodeService
    {
        private readonly IDataBaseContext _db;
        public RecoveryPasswordByActivationCodeService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(string activationCode, string password)
        {
            var user = _db.Users.SingleOrDefault(u => u.ActiveCode.Equals(activationCode));

            user.Password = PasswordHelper.HashPassword(password);
            user.ActiveCode = Guid.NewGuid().ToString();

            _db.Users.Update(user);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "عملیات تغییر رمز عبور با موفقیت انجام شد"
            };

        }
    }
}
