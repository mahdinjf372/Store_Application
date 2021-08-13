using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Brands.Queries.GetBrands;
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

        private IGetBrandsService _getBrandsService;
        public IGetBrandsService GetBrandsService
        {
            get
            {
                return _getBrandsService = _getBrandsService ?? new GetBrandsService(_db);
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
