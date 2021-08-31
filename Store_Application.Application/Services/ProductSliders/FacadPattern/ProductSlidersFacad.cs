using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.ProductSliders.Commands.AddProductSlider;
using Store_Application.Application.Services.ProductSliders.Commands.DeleteProductSlider;
using Store_Application.Application.Services.ProductSliders.Queries.GetProductSliders;
using Store_Application.Application.Services.ProductSliders.Queries.IsExistProductSlider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductSliders.FacadPattern
{
    public class ProductSlidersFacad : IProductSlidersFacad
    {
        private readonly IDataBaseContext _db;
        public ProductSlidersFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetProductSlidersService _getProductSlidersService;
        public IGetProductSlidersService GetProductSlidersService
        {
            get
            {
                return _getProductSlidersService = _getProductSlidersService ?? new GetProductSlidersService(_db);
            }
        }


        private IDeleteProductSliderService _deleteProductSliderService;
        public IDeleteProductSliderService DeleteProductSliderService
        {
            get
            {
                return _deleteProductSliderService = _deleteProductSliderService ?? new DeleteProductSliderService(_db);
            }
        }

        private IAddProductSliderService _addProductSliderService;
        public IAddProductSliderService AddProductSliderService
        {
            get
            {
                return _addProductSliderService = _addProductSliderService ?? new AddProductSliderService(_db);
            }
        }
        

        private IisExistProductSliderService _isExistProductSliderService;
        public IisExistProductSliderService IsExistProductSliderService
        {
            get
            {
                return _isExistProductSliderService = _isExistProductSliderService ?? new IsExistProductSliderService(_db);
            }
        }

    }

}
