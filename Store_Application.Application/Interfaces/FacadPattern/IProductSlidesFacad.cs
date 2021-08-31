using Store_Application.Application.Services.ProductSliders.Commands.AddProductSlider;
using Store_Application.Application.Services.ProductSliders.Commands.DeleteProductSlider;
using Store_Application.Application.Services.ProductSliders.Queries.GetProductSliders;
using Store_Application.Application.Services.ProductSliders.Queries.IsExistProductSlider;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IProductSlidersFacad
    {
        IGetProductSlidersService GetProductSlidersService { get; }
        IAddProductSliderService AddProductSliderService { get; }
        IDeleteProductSliderService DeleteProductSliderService { get; }
        IisExistProductSliderService IsExistProductSliderService { get; }

    }
}
