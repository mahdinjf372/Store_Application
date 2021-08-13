using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Users.Queries.GetRoles
{
    public class GetRolesService : IGetRolesService
    {
        private readonly IDataBaseContext _db;
        public GetRolesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<GetRolesDto>> Execute()
        {
            try
            {
                var roles = _db.Roles.Select(r => new GetRolesDto()
                {
                    Id = r.Id,
                    Name = r.Name
                }).ToList();

                return new ResultDto<List<GetRolesDto>>()
                {
                    Data = roles,
                    IsSuccess = true,
                    Message = "عملیات واکشی نقش ها با موفقیت انجام شد"
                };
            }
            catch (System.Exception)
            {
                return new ResultDto<List<GetRolesDto>>()
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "عملیات واکشی نقش ها با شکست مواجه شد"
                };
            }
        }
    }
}
