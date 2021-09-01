using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.BrandSlider.Queries.GetSlide
{
    public class GetSlideService : IGetSlideService
    {
        private readonly IDataBaseContext _db;
        public GetSlideService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetSlideDto> Execute(int id)
        {
            var slide = _db.BrandSlides.Find(id);

            ResultGetSlideDto res = new ResultGetSlideDto()
            {
                Id = slide.Id,
                ImageName = slide.ImageName,
                LinkTo = slide.LinkTo,
                Title = slide.Title
            };

            return new ResultDto<ResultGetSlideDto>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
