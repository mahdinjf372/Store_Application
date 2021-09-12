using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Products.Commands.AddGalleryImage;
using Store_Application.Application.Services.Products.Commands.AddProduct;
using Store_Application.Application.Services.Products.Commands.DeleteImage;
using Store_Application.Application.Services.Products.Commands.DeleteProduct;
using Store_Application.Application.Services.Products.Commands.EditProduct;
using Store_Application.Application.Services.Products.Queries.GetGalleryImageForAdmin;
using Store_Application.Application.Services.Products.Queries.GetGalleryImagesForAdmin;
using Store_Application.Application.Services.Products.Queries.GetProductForAdmin;
using Store_Application.Application.Services.Products.Queries.GetProductForSite;
using Store_Application.Application.Services.Products.Queries.GetProductsBySliderId;
using Store_Application.Application.Services.Products.Queries.GetProductsForAdmin;
using Store_Application.Application.Services.Products.Queries.IsExistImage;
using Store_Application.Application.Services.Products.Queries.IsExistProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDataBaseContext _db;
        public ProductFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddProductService _addProductService;
        public IAddProductService AddProductService
        {
            get
            {
                return _addProductService = _addProductService ?? new AddProductService(_db);
            }
        }

        private IisExistProductService _isExistProductService;
        public IisExistProductService isExistProductService
        {
            get
            {
                return _isExistProductService = _isExistProductService ?? new isExistProductService(_db);
            }
        }

        private IGetProductsForAdminService _getProductsForAdminService;
        public IGetProductsForAdminService GetProductsForAdminService
        {
            get
            {
                return _getProductsForAdminService = _getProductsForAdminService ?? new GetProductsForAdminService(_db);
            }
        }

        private IGetGalleryImagesForAdminService _getGalleryImagesForAdminService;
        public IGetGalleryImagesForAdminService GetGalleryImagesForAdminService
        {
            get
            {
                return _getGalleryImagesForAdminService = _getGalleryImagesForAdminService ?? new GetGalleryImagesForAdminService(_db);
            }
        }


        private IAddGalleryImageService _addGalleryImageService;
        public IAddGalleryImageService AddGalleryImageService
        {
            get
            {
                return _addGalleryImageService = _addGalleryImageService ?? new AddGalleryImageService(_db);
            }
        }

        private IisExistImageService _isExistImageService;
        public IisExistImageService isExistImageService
        {
            get
            {
                return _isExistImageService = _isExistImageService ?? new isExistImageService(_db);
            }
        }

        private IDeleteImageService _deleteImageService;
        public IDeleteImageService DeleteImageService
        {
            get
            {
                return _deleteImageService = _deleteImageService ?? new DeleteImageService(_db);
            }
        }

        private IGetGalleryImageForAdminService _getGalleryImageForAdminService;
        public IGetGalleryImageForAdminService GetGalleryImageForAdminService
        {
            get
            {
                return _getGalleryImageForAdminService = _getGalleryImageForAdminService ?? new GetGalleryImageForAdminService(_db);
            }
        }
        

        private IDeleteProductService _deleteProductService;
        public IDeleteProductService DeleteProductService
        {
            get
            {
                return _deleteProductService = _deleteProductService ?? new DeleteProductService(_db);
            }
        }

        private IGetProductForAdminService _getProductForAdminService;
        public IGetProductForAdminService GetProductForAdminService
        {
            get
            {
                return _getProductForAdminService = _getProductForAdminService ?? new GetProductForAdminService(_db);
            }
        }

        private IGetProductForSiteService _getProductForSiteService;
        public IGetProductForSiteService GetProductForSiteService
        {
            get
            {
                return _getProductForSiteService = _getProductForSiteService ?? new GetProductForSiteService(_db);
            }
        }


        private IEditProductService _editProductService;
        public IEditProductService EditProductService
        {
            get
            {
                return _editProductService = _editProductService ?? new EditProductService(_db);
            }
        }
        

        private IGetProductsBySliderIdService _getProductsBySliderIdService;
        public IGetProductsBySliderIdService GetProductsBySliderIdService
        {
            get
            {
                return _getProductsBySliderIdService = _getProductsBySliderIdService ?? new GetProductsBySliderIdService(_db);
            }
        }

    }
}

