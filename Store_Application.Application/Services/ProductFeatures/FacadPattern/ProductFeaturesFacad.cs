using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature;
using Store_Application.Application.Services.ProductFeatures.Commands.ChangeBoldStatus;
using Store_Application.Application.Services.ProductFeatures.Commands.DeleteProductFeature;
using Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature;
using Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeatures;
using Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.FacadPattern
{
    public class ProductFeaturesFacad : IProductFeaturesFacad
    {
        private readonly IDataBaseContext _db;
        public ProductFeaturesFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetProductFeaturesService _getProductFeaturesService;
        public IGetProductFeaturesService GetProductFeaturesService
        {
            get
            {
                return _getProductFeaturesService = _getProductFeaturesService ?? new GetProductFeaturesService(_db);
            }
        }

        private IAddProductFeatureService _addProductFeatureService;
        public IAddProductFeatureService AddProductFeatureService
        {
            get
            {
                return _addProductFeatureService = _addProductFeatureService ?? new AddProductFeatureService(_db);
            }
        }


        private IisExistProductFeatureService _isExistProductFeatureService;
        public IisExistProductFeatureService isExistProductFeatureService
        {
            get
            {
                return _isExistProductFeatureService = _isExistProductFeatureService ?? new isExistProductFeatureService(_db);
            }
        }


        private IChangeBoldStatusService _changeBoldStatusService;
        public IChangeBoldStatusService ChangeBoldStatusService
        {
            get
            {
                return _changeBoldStatusService = _changeBoldStatusService ?? new ChangeBoldStatusService(_db);
            }
        }

        private IDeleteProductFeatureService _deleteProductFeatureService;
        public IDeleteProductFeatureService DeleteProductFeatureService
        {
            get
            {
                return _deleteProductFeatureService = _deleteProductFeatureService ?? new DeleteProductFeatureService(_db);
            }
        }

        private IEditProductFeatureService _editProductFeatureService;
        public IEditProductFeatureService EditProductFeatureService
        {
            get
            {
                return _editProductFeatureService = _editProductFeatureService ?? new EditProductFeatureService(_db);
            }
        }
    }
}
