using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Carts.Commands.AddCart;
using Store_Application.Application.Services.Carts.Commands.AddProductToCart;
using Store_Application.Application.Services.Carts.Commands.DeleteProduct;
using Store_Application.Application.Services.Carts.Commands.MergeUserCartAndBrowserCart;
using Store_Application.Application.Services.Carts.Queries.GetCartForSite;
using Store_Application.Application.Services.Carts.Queries.IsExistCartByBrowserId;
using Store_Application.Application.Services.Carts.Queries.IsExistCartByUserId;

namespace Store_Application.Application.Services.Carts.FacadPattern
{
    public class CartFacad : ICartFacad
    {
        private readonly IDataBaseContext _db;
        public CartFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddProductToCartService _addProductToCartService;
        public IAddProductToCartService AddProductToCartService
        {
            get
            {
                return _addProductToCartService = _addProductToCartService ?? new AddProductToCartService(_db);
            }
        }

        private IAddCartService _addCartService;
        public IAddCartService AddCartService
        {
            get
            {
                return _addCartService = _addCartService ?? new AddCartService(_db);
            }
        }

        private IGetCartForSiteService _getCartForSiteService;
        public IGetCartForSiteService GetCartForSiteService
        {
            get
            {
                return _getCartForSiteService = _getCartForSiteService ?? new GetCartForSiteService(_db);
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


        private IMergeUserCartAndBrowserCartService _mergeUserCartAndBrowserCartService;
        public IMergeUserCartAndBrowserCartService MergeUserCartAndBrowserCartService
        {
            get
            {
                return _mergeUserCartAndBrowserCartService = _mergeUserCartAndBrowserCartService ?? new MergeUserCartAndBrowserCartService(_db);
            }
        }
        

            private IisExistCartByUserIdService _isExistCartByUserIdService;
        public IisExistCartByUserIdService IsExistCartByUserIdService
        {
            get
            {
                return _isExistCartByUserIdService = _isExistCartByUserIdService ?? new IsExistCartByUserIdService(_db);
            }
        }

        private IisExistCartByBrowserIdService _isExistCartByBrowserIdService;
        public IisExistCartByBrowserIdService IsExistCartByBrowserIdService
        {
            get
            {
                return _isExistCartByBrowserIdService = _isExistCartByBrowserIdService ?? new IsExistCartByBrowserIdService(_db);
            }
        }
    }
}
