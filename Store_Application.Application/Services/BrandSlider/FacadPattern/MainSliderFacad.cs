using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.BrandSlider.Commands.Add;
using Store_Application.Application.Services.BrandSlider.Commands.Delete;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlide;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlides;

namespace Store_Application.Application.Services.BrandSlider.FacadPattern
{
    public class BrandSliderFacad : IBrandSliderFacad
    {
        private readonly IDataBaseContext _db;

        public BrandSliderFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddSlideService _addSlideService;
        public IAddSlideService AddSlideService
        {
            get
            {
                return _addSlideService = _addSlideService ?? new AddSlideService(_db);
            }
        }

        private IDeleteSlideService _deleteSlideService;
        public IDeleteSlideService DeleteSlideService
        {
            get
            {
                return _deleteSlideService = _deleteSlideService ?? new DeleteSlideService(_db);
            }
        }

        private IGetSlidesService _getSlidesService;
        public IGetSlidesService GetSlidesService
        {
            get
            {
                return _getSlidesService = _getSlidesService ?? new GetSlidesService(_db);
            }
        }


        private IGetSlideService _getSlideService;
        public IGetSlideService GetSlideService
        {
            get
            {
                return _getSlideService = _getSlideService ?? new GetSlideService(_db);
            }
        }
    }
}
