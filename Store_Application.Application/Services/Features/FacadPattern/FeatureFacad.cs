using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Features.Commands.AddFeature;
using Store_Application.Application.Services.Features.Commands.DeleteFeature;
using Store_Application.Application.Services.Features.Commands.EditFeature;
using Store_Application.Application.Services.Features.Queries.GetFeatureForAdmin;
using Store_Application.Application.Services.Features.Queries.GetFeaturesForAdmin;
using Store_Application.Application.Services.Features.Queries.IsExistFeature;

namespace Store_Application.Application.Services.Features.FacadPattern
{
    public class FeatureFacad : IFeatureFacad
    {
        private readonly IDataBaseContext _db;

        public FeatureFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetFeaturesForAdminService _getFeaturesForAdminService;
        public IGetFeaturesForAdminService GetFeaturesForAdminService
        {
            get
            {
                return _getFeaturesForAdminService = _getFeaturesForAdminService ?? new GetFeaturesForAdminService(_db);
            }
        }

        private IisExistFeatureService _isExistFeatureService;
        public IisExistFeatureService isExistFeatureService
        {
            get
            {
                return _isExistFeatureService = _isExistFeatureService ?? new isExistFeatureService(_db);
            }
        }

        private IAddFeatureService _addFeatureService;
        public IAddFeatureService AddFeatureService
        {
            get
            {
                return _addFeatureService = _addFeatureService ?? new AddFeatureService(_db);
            }
        }

        private IGetFeatureForAdminService _getFeatureForAdminService;
        public IGetFeatureForAdminService GetFeatureForAdminService
        {
            get
            {
                return _getFeatureForAdminService = _getFeatureForAdminService ?? new GetFeatureForAdminService(_db);
            }
        }

        private IEditFeatureService _editFeatureService;
        public IEditFeatureService EditFeatureService
        {
            get
            {
                return _editFeatureService = _editFeatureService ?? new EditFeatureService(_db);
            }
        }

        private IDeleteFeatureService _deleteFeatureService;
        public IDeleteFeatureService DeleteFeatureService
        {
            get
            {
                return _deleteFeatureService = _deleteFeatureService ?? new DeleteFeatureService(_db);
            }
        }
    }
}
