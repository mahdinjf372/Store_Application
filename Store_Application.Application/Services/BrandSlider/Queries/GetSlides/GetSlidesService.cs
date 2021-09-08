using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.BrandSlider.Queries.GetSlides
{
    public class GetSlidesService : IGetSlidesService
    {
        private readonly IDataBaseContext _db;
        public GetSlidesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetSlidesDto>> Execute()
        {
            var res = _db.BrandSlides.Select(s => new ResultGetSlidesDto
            {
                Id = s.Id,
                ImageName = s.ImageName,
                LinkTo = s.LinkTo,
                Title = s.Title
            }).ToList();

            return new ResultDto<List<ResultGetSlidesDto>>
            {
                Data = res,
                IsSuccess = true,
            };

        }
    }
}
