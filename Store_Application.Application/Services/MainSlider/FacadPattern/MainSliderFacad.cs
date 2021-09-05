using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.MainSlider.Commands.Add;
using Store_Application.Application.Services.MainSlider.Commands.Delete;
using Store_Application.Application.Services.MainSlider.Commands.Edit;
using Store_Application.Application.Services.MainSlider.Queries.GetSlide;
using Store_Application.Application.Services.MainSlider.Queries.GetSlides;

namespace Store_Application.Application.Services.MainSlider.FacadPattern
{
    public class MainSliderFacad : IMainSliderFacad
    {
        private readonly IDataBaseContext _db;

        public MainSliderFacad(IDataBaseContext db)
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

        private IEditSlideService _editSlideService;
        public IEditSlideService EditSlideService
        {
            get
            {
                return _editSlideService = _editSlideService ?? new EditSlideService(_db);
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
