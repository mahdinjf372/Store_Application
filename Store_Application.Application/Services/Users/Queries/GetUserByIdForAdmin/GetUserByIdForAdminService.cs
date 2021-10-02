using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin
{
    public class GetUserByIdForAdminService : IGetUserByIdForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetUserByIdForAdminService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetUserByIdForAdminDto> Execute(int id)
        {
            User _user = _db.Users.Include(u=> u.UserRoles).Single(u=> u.Id.Equals(id));

            ResultGetUserByIdForAdminDto user = new ResultGetUserByIdForAdminDto()
            {
                Address = _user.Address,
                age = _user.age,
                Email = _user.Email,
                FullName = _user.FullName,
                Id = _user.Id,
                Phone = _user.Phone,
                Roles = _user.UserRoles.Select(r=> new UserRolesDto
                {
                    Id = r.RoleId
                }).ToList(),
                Username = _user.Username
            };

            return new ResultDto<ResultGetUserByIdForAdminDto>()
            {
                Data = user,
                IsSuccess = true,
                Message = "كاربر با موفقيت يافت و واكشي شد"
            };
        }
    }

}
