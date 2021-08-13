using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Features.Queries.GetFeatures
{
    public class GetFeaturesService : IGetFeaturesService
    {
        private readonly IDataBaseContext _db;
        public GetFeaturesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetFeaturesDto>> Execute()
        {
            List<ResultGetFeaturesDto> features = _db.Features.IgnoreQueryFilters()
                .Select(f => new ResultGetFeaturesDto
                {
                    Id = f.Id,
                    Title = f.Title,
                    isRemoved = f.isRemoved
                }).ToList();

            return new ResultDto<List<ResultGetFeaturesDto>>
            {
                Data = features,
                IsSuccess = true,
                Message = "ویژگی ها با موفقیت واکشی شدند"
            };
        }
    }
}
