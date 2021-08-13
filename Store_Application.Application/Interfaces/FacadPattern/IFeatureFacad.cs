using Store_Application.Application.Services.Features.Commands.AddFeature;
using Store_Application.Application.Services.Features.Commands.DeleteFeature;
using Store_Application.Application.Services.Features.Commands.EditFeature;
using Store_Application.Application.Services.Features.Queries.GetFeature;
using Store_Application.Application.Services.Features.Queries.GetFeatures;
using Store_Application.Application.Services.Features.Queries.IsExistFeature;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IFeatureFacad
    {
        IGetFeaturesService GetFeaturesService { get; }
        IisExistFeatureService isExistFeatureService { get; }
        IAddFeatureService AddFeatureService { get; }
        IGetFeatureService GetFeatureService { get; }
        IEditFeatureService EditFeatureService { get; }
        IDeleteFeatureService DeleteFeatureService { get; }
    }
}
