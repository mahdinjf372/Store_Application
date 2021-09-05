using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Features.Queries.GetFeaturesForAdmin
{
    public class GetFeaturesForAdminService : IGetFeaturesForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetFeaturesForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetFeaturesForAdminDto>> Execute()
        {
            List<ResultGetFeaturesForAdminDto> features = _db.Features.IgnoreQueryFilters()
                .Select(f => new ResultGetFeaturesForAdminDto
                {
                    Id = f.Id,
                    Title = f.Title,
                    isRemoved = f.isRemoved
                }).ToList();

            return new ResultDto<List<ResultGetFeaturesForAdminDto>>
            {
                Data = features,
                IsSuccess = true,
                Message = "ویژگی ها با موفقیت واکشی شدند"
            };
        }
    }
}
