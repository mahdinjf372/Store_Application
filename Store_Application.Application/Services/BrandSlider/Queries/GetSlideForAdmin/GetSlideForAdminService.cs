using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.BrandSlider.Queries.GetSlideForAdmin
{
    public class GetSlideForAdminService : IGetSlideForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetSlideForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetSlideForAdminDto> Execute(int id)
        {
            var slide = _db.BrandSlides.Find(id);

            ResultGetSlideForAdminDto res = new ResultGetSlideForAdminDto()
            {
                Id = slide.Id,
                ImageName = slide.ImageName,
                LinkTo = slide.LinkTo,
                Title = slide.Title
            };

            return new ResultDto<ResultGetSlideForAdminDto>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
