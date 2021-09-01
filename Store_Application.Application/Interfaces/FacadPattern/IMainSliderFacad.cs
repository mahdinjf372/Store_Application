using Store_Application.Application.Services.MainSlider.Commands.Add;
using Store_Application.Application.Services.MainSlider.Commands.Delete;
using Store_Application.Application.Services.MainSlider.Commands.Edit;
using Store_Application.Application.Services.MainSlider.Queries.GetSlide;
using Store_Application.Application.Services.MainSlider.Queries.GetSlides;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IMainSliderFacad
    {
        IAddSlideService AddSlideService { get; }
        IEditSlideService EditSlideService { get; }
        IDeleteSlideService DeleteSlideService { get; }
        IGetSlidesService GetSlidesService { get; }
        IGetSlideService GetSlideService { get; }

    }
}
