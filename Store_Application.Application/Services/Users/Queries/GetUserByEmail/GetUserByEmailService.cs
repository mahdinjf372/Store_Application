using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetUserByEmail
{
    public class GetUserByEmailService : IGetUserByEmailService
    {
        private readonly IDataBaseContext _db;
        public GetUserByEmailService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetUserbyEmailDto> Execute(string email)
        {
            User _user = _db.Users.SingleOrDefault(u=> u.Email.Equals(email));

            ResultGetUserbyEmailDto user = new ResultGetUserbyEmailDto()
            {
                Address = _user.Address,
                age = _user.age,
                Email = _user.Email,
                FullName = _user.FullName,
                Id = _user.Id,
                Phone = _user.Phone,
                Roles = _user.UserRoles.Select(r=> new GetEmailRoleDto
                {
                    Id = r.RoleId
                }).ToList(),
                Username = _user.Username
            };

            return new ResultDto<ResultGetUserbyEmailDto>()
            {
                Data = user,
                IsSuccess = true,
                Message = "كاربر با موفقيت يافت و واكشي شد"
            };
        }
    }
}
