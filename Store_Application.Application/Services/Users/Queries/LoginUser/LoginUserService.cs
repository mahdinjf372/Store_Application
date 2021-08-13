using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.LoginUser
{
    public class LoginUserService : ILoginUserService
    {
        private readonly IDataBaseContext _db;
        public LoginUserService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultLoginUserDto> Execute(RequestLoginUserDto req)
        {
            string hashedPassword = PasswordHelper.HashPassword(req.Password);
            User user = _db.Users.SingleOrDefault(u => u.Email.Equals(req.Email) && u.Password.Equals(hashedPassword));

            if (user != null)
            {
                ResultLoginUserDto res = new ResultLoginUserDto()
                {
                    Id = user.Id,
                    Username = user.Username,
                    isActive = user.isActive,
                    RoleId = user.RoleId
                };
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "جستوجوی دیتابیس با موفقیت انجام شد"
                };
            }

            return new ResultDto<ResultLoginUserDto>()
            {
                Data = null,
                IsSuccess = true,
                Message = "جستوجوی دیتابیس با موفقیت انجام شد"
            };
        }
    }
}
