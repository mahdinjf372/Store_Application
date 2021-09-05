using Store_Application.Application.Services.Features.Commands.AddFeature;
using Store_Application.Application.Services.Features.Commands.DeleteFeature;
using Store_Application.Application.Services.Features.Commands.EditFeature;
using Store_Application.Application.Services.Features.Queries.GetFeatureForAdmin;
using Store_Application.Application.Services.Features.Queries.GetFeaturesForAdmin;
using Store_Application.Application.Services.Features.Queries.IsExistFeature;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IFeatureFacad
    {
        IGetFeaturesForAdminService GetFeaturesForAdminService { get; }
        IisExistFeatureService isExistFeatureService { get; }
        IAddFeatureService AddFeatureService { get; }
        IGetFeatureForAdminService GetFeatureForAdminService { get; }
        IEditFeatureService EditFeatureService { get; }
        IDeleteFeatureService DeleteFeatureService { get; }
    }
}
