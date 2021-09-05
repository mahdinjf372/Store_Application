using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetRolesForAdmin
{
    public class GetRolesForAdminService : IGetRolesForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetRolesForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<GetRolesForAdminDto>> Execute()
        {
            try
            {
                var roles = _db.Roles.Select(r => new GetRolesForAdminDto()
                {
                    Id = r.Id,
                    Name = r.Name
                }).ToList();

                return new ResultDto<List<GetRolesForAdminDto>>()
                {
                    Data = roles,
                    IsSuccess = true,
                    Message = "عملیات واکشی نقش ها با موفقیت انجام شد"
                };
            }
            catch (System.Exception)
            {
                return new ResultDto<List<GetRolesForAdminDto>>()
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "عملیات واکشی نقش ها با شکست مواجه شد"
                };
            }
        }
    }
}
