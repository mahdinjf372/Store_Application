using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Sliders.Queries.GetSlidersForAdmin
{
    public class GetSlidersForAdminService : IGetSlidersForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetSlidersForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetSlidersForAdminDto>> Execute()
        {
            var res = _db.Sliders.Select(s => new ResultGetSlidersForAdminDto
            {
                Id = s.Id,
                Title = s.Title
            }).ToList();

            return new ResultDto<List<ResultGetSlidersForAdminDto>>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
