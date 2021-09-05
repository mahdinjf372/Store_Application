using Store_Application.Application.Services.Brands.Queries.GetBrandsForAdmin;
using Store_Application.Application.Services.Brands.Queries.IsExistBrand;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IBrandFacad
    {
       IGetBrandsForAdminService GetBrandsForAdminService { get; }
       IisExistBrandService IsExistBrandService { get; }
    }
}
