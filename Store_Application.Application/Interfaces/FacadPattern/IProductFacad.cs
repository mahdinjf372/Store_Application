using Store_Application.Application.Services.Products.Commands.AddGalleryImage;
using Store_Application.Application.Services.Products.Commands.AddProduct;
using Store_Application.Application.Services.Products.Commands.DeleteImage;
using Store_Application.Application.Services.Products.Commands.DeleteProduct;
using Store_Application.Application.Services.Products.Commands.EditProduct;
using Store_Application.Application.Services.Products.Queries.GetGalleryImage;
using Store_Application.Application.Services.Products.Queries.GetGalleryImages;
using Store_Application.Application.Services.Products.Queries.GetProductForAdmin;
using Store_Application.Application.Services.Products.Queries.GetProductsForAdmin;
using Store_Application.Application.Services.Products.Queries.IsExistImage;
using Store_Application.Application.Services.Products.Queries.IsExistProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IProductFacad
    {
        IAddProductService AddProductService { get; }
        IisExistProductService isExistProductService { get; }
        IGetProductsForAdminService GetProductsForAdminService { get; }
        IGetGalleryImagesService GetGalleryImagesService { get; }
        IAddGalleryImageService AddGalleryImageService { get; }
        IisExistImageService isExistImageService { get; }
        IDeleteImageService DeleteImageService { get; }
        IGetGalleryImageService GetGalleryImageService { get; }
        IDeleteProductService DeleteProductService { get; }
        IGetProductForAdminService GetProductForAdminService { get; }
        IEditProductService EditProductService { get; }
    }
}
