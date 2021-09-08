
using Store_Application.Application.Services.BrandSlider.Commands.Add;
using Store_Application.Application.Services.BrandSlider.Commands.Delete;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlideForAdmin;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlidesForAdmin;
using Store_Application.Application.Services.BrandSlider.Queries.GetSlides;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IBrandSliderFacad
    {
        IAddSlideService AddSlideService { get; }
        IDeleteSlideService DeleteSlideService { get; }
        IGetSlidesForAdminService GetSlidesForAdminService { get; }
        IGetSlideForAdminService GetSlideForAdminService { get; }
        IGetSlidesService GetSlidesService { get; }

    }
}
