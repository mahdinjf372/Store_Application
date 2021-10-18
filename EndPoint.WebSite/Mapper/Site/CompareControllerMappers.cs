using AutoMapper;
using Store_Application.Application.Services.Compare.Queries.GetCompareList;

namespace EndPoint.WebSite.Mapper.Site
{
    public class CompareControllerMappers : Profile
    {
        public CompareControllerMappers()
        {
            AllowNullCollections = true; 
            CreateMap<ProductCompareDto, Models.Compare.Index.ProductCompareViewModel>();
            CreateMap<FeatureDto, Models.Compare.Index.FeatureViewModel>();
            CreateMap<ProductFeatureDto, Models.Compare.Index.ProductFeatureViewModel>();

        }
    }
}
