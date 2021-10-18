using AutoMapper;
using EndPoint.WebSite.Areas.Admin.Models.Product.Create;
using EndPoint.WebSite.Areas.Admin.Models.Product.Edit;
using Store_Application.Application.Services.Products.Commands.AddProduct;
using Store_Application.Application.Services.Products.Commands.EditProduct;
using Store_Application.Application.Services.Products.Queries.GetProductForAdmin;
using System.Linq;

namespace EndPoint.WebSite.Mapper.Admin
{
    public class ProductControllerMappers : Profile
    {
        public ProductControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<CreateProductViewModel, RequestAddProductDto>();

            CreateMap<ResultGetProductForAdminDto, EditProductViewModel>()
                .ForMember(outer => outer.Tags, opt => opt.MapFrom(inner => string.Join("-", inner.Tags)))
                .ForMember(outer => outer.Image, opt => opt.MapFrom(inner => inner.Images.SingleOrDefault(i => i.IsMainImages).Name))
                .ForMember(outer => outer.Description, opt => opt.MapFrom(inner => inner.Decription));

            CreateMap<EditProductViewModel, RequestEditProductDto>();

        }
    }
}
