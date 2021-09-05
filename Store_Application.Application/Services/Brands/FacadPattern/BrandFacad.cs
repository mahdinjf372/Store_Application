using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Brands.Queries.GetBrandsForAdmin;
using Store_Application.Application.Services.Brands.Queries.IsExistBrand;

namespace Store_Application.Application.Services.Brands.FacadPattern
{
    public class BrandFacad : IBrandFacad
    {

        private readonly IDataBaseContext _db;

        public BrandFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetBrandsForAdminService _getBrandsForAdminService;
        public IGetBrandsForAdminService GetBrandsForAdminService
        {
            get
            {
                return _getBrandsForAdminService = _getBrandsForAdminService ?? new GetBrandsForAdminService(_db);
            }
        }
        private IisExistBrandService _isExistBrandService;
        public IisExistBrandService IsExistBrandService
        {
            get
            {
                return _isExistBrandService = _isExistBrandService ?? new isExistBrandService(_db);
            }
        }

    }
}
