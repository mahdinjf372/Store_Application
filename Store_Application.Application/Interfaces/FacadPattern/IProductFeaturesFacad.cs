using Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature;
using Store_Application.Application.Services.ProductFeatures.Commands.ChangeBoldStatus;
using Store_Application.Application.Services.ProductFeatures.Commands.DeleteProductFeature;
using Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature;
using Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeatures;
using Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IProductFeaturesFacad
    {
        IGetProductFeaturesService GetProductFeaturesService { get; }
        IAddProductFeatureService AddProductFeatureService { get; }
        IisExistProductFeatureService isExistProductFeatureService { get; }
        IChangeBoldStatusService ChangeBoldStatusService { get; }
        IDeleteProductFeatureService DeleteProductFeatureService { get; }
        IEditProductFeatureService EditProductFeatureService { get; }
    }
}
