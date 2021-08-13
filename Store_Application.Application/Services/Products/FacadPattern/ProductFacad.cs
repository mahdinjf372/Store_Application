using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Products.Commands.AddProduct;
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
    }
}
