using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.IsOldPassword
{
    public class IsOldPasswordService : IisOldPasswordService
    {
        private readonly IDataBaseContext _db;
        public IsOldPasswordService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int userId, string password)
        {
            password = PasswordHelper.HashPassword(password);

            var res = _db.Users.Any(u => u.Id.Equals(userId) && u.Password.Equals(password));

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
