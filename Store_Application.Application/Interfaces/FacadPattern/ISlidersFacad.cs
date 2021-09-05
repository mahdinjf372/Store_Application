using Store_Application.Application.Services.Sliders.Queries.GetSlidersForAdmin;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ISlidersFacad
    {
        IGetSlidersForAdminService GetSlidersForAdminService { get; }
    }
}
