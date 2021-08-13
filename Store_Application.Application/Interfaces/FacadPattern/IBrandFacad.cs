using Store_Application.Application.Services.Brands.Queries.GetBrands;
using Store_Application.Application.Services.Brands.Queries.IsExistBrand;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IBrandFacad
    {
       IGetBrandsService GetBrandsService{ get; }
       IisExistBrandService IsExistBrandService { get; }
    }
}
