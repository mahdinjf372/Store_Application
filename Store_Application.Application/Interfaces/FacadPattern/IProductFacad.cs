using Store_Application.Application.Services.Products.Commands.AddGalleryImage;
using Store_Application.Application.Services.Products.Commands.AddProduct;
using Store_Application.Application.Services.Products.Commands.DeleteImage;
using Store_Application.Application.Services.Products.Commands.DeleteProduct;
using Store_Application.Application.Services.Products.Commands.EditProduct;
using Store_Application.Application.Services.Products.Queries.GetGalleryImageForAdmin;
using Store_Application.Application.Services.Products.Queries.GetGalleryImagesForAdmin;
using Store_Application.Application.Services.Products.Queries.GetProductForAdmin;
using Store_Application.Application.Services.Products.Queries.GetProductsForAdmin;
using Store_Application.Application.Services.Products.Queries.IsExistImage;
using Store_Application.Application.Services.Products.Queries.IsExistProduct;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IProductFacad
    {
        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductsForAdminService GetProductsForAdminService { get; }
        IGetGalleryImageForAdminService GetGalleryImageForAdminService { get; }
        IGetGalleryImagesForAdminService GetGalleryImagesForAdminService { get; }
        IAddGalleryImageService AddGalleryImageService { get; }
        IAddProductService AddProductService { get; }
        IisExistProductService isExistProductService { get; }
        IisExistImageService isExistImageService { get; }
        IDeleteImageService DeleteImageService { get; }
        IDeleteProductService DeleteProductService { get; }
        IEditProductService EditProductService { get; }
    }
}
