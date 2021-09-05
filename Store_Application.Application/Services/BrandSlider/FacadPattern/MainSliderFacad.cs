using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.BrandSlider.Commands.Add;
using Store_Application.Application.Services.BrandSlider.Commands.Delete;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlideForAdmin;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlidesForAdmin;

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

        private IGetSlidesForAdminService _getSlidesForAdminService;
        public IGetSlidesForAdminService GetSlidesForAdminService
        {
            get
            {
                return _getSlidesForAdminService = _getSlidesForAdminService ?? new GetSlidesForAdminService(_db);
            }
        }


        private IGetSlideForAdminService _getSlideForAdminService;
        public IGetSlideForAdminService GetSlideForAdminService
        {
            get
            {
                return _getSlideForAdminService = _getSlideForAdminService ?? new GetSlideForAdminService(_db);
            }
        }
    }
}
