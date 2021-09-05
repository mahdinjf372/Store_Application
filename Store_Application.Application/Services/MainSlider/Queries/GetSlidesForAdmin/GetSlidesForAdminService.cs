using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.MainSlider.Queries.GetSlidesForAdmin
{
    public class GetSlidesForAdminService : IGetSlidesForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetSlidesForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetSlidesForAdminDto>> Execute()
        {
            var res = _db.MainSlides.Select(s => new ResultGetSlidesForAdminDto
            {
                Id = s.Id,
                ImageName = s.ImageName,
                LinkTo = s.LinkTo,
                Title = s.Title
            }).ToList();

            return new ResultDto<List<ResultGetSlidesForAdminDto>>
            {
                Data = res,
                IsSuccess = true,
            };

        }
    }
}
