using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class GetUsersForAdminService : IGetUsersForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetUsersForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetUsersForAdminDto> Execute(RequestGetUsersForAdminDto req)
        {
            try
            {
                var users = _db.Users.IgnoreQueryFilters().AsQueryable();

                if (!string.IsNullOrEmpty(req.Searchkey))
                {
                    if (int.TryParse(req.Searchkey,out int id))
                    {
                        users = users.Where(u => u.Username.Contains(req.Searchkey) || u.Email.Contains(req.Searchkey) || u.Id == id);
                    }
                    else
                    {
                        users = users.Where(u => u.Username.Contains(req.Searchkey) || u.Email.Contains(req.Searchkey));
                    }
                }

                int rowCount = 0;
                var usersViewModel = users.Include(u => u.UserRoles).ThenInclude(ur=> ur.Role)
                    .Select(u => new GetUsersForAdminDto()
                    {
                        Id = u.Id,
                        Username = u.Username,
                        Email = u.Email,
                        isRemoved = u.isRemoved,
                        RolesName = u.UserRoles.Where(r=> !r.isRemoved).OrderBy(r=> r.RoleId).Select(r=> r.Role.Name).ToList(),
                        isActive = u.isActive
                    })
                    .ToPaged(req.Page, req.Take, out rowCount).ToList();
                
                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int) Math.Ceiling(ee);

                var resultGetUsers = new ResultGetUsersForAdminDto()
                {
                    CurrentPage = req.Page,
                    PageCount = pageCount,
                    users = usersViewModel
                };

                return new ResultDto<ResultGetUsersForAdminDto>()
                {
                    Data = resultGetUsers,
                    IsSuccess = true,
                    Message = "عملیات واکشی کاربران با موفقیت انجام شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetUsersForAdminDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی کاربران با شکست مواجه شد"
                };
            }
        }
    }
}
