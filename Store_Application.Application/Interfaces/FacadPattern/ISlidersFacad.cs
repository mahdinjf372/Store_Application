using Store_Application.Application.Services.Sliders.Queries.GetSliders;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ISlidersFacad
    {
        IGetSlidersService GetSlidersService { get; }
    }
}
