using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _db;
        public GetUsersService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetUsersDto> Execute(RequestGetUsersDto req)
        {
            try
            {
                var users = _db.Users.IgnoreQueryFilters().AsQueryable();

                if (!string.IsNullOrEmpty(req.Searchkey))
                {
                    users = users.Where(u => u.Username.Contains(req.Searchkey) || u.Email.Contains(req.Searchkey));
                }

                int rowCount = 0;
                var usersViewModel = users.Include(u => u.Role)
                    .Select(u => new GetUsersDto()
                    {
                        Id = u.Id,
                        Username = u.Username,
                        Email = u.Email,
                        isRemoved = u.isRemoved,
                        RoleName = u.Role.Name,
                        isActive = u.isActive
                    })
                    .ToPaged(req.Page, req.Take, out rowCount).ToList();
                
                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int) Math.Ceiling(ee);

                var resultGetUsers = new ResultGetUsersDto()
                {
                    CurrentPage = req.Page,
                    PageCount = pageCount,
                    users = usersViewModel
                };

                return new ResultDto<ResultGetUsersDto>()
                {
                    Data = resultGetUsers,
                    IsSuccess = true,
                    Message = "عملیات واکشی کاربران با موفقیت انجام شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetUsersDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی کاربران با شکست مواجه شد"
                };
            }
        }
    }
}
