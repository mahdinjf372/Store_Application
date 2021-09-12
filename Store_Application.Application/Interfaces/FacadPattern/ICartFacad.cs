using Store_Application.Application.Services.Carts.Commands.AddCart;
using Store_Application.Application.Services.Carts.Commands.AddProductToCart;
using Store_Application.Application.Services.Carts.Commands.DeleteProduct;
using Store_Application.Application.Services.Carts.Commands.MergeUserCartAndBrowserCart;
using Store_Application.Application.Services.Carts.Queries.GetCartForSite;
using Store_Application.Application.Services.Carts.Queries.IsExistCartByBrowserId;
using Store_Application.Application.Services.Carts.Queries.IsExistCartByUserId;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ICartFacad
    {
        IAddProductToCartService AddProductToCartService { get; }
        IGetCartForSiteService GetCartForSiteService { get; }
        IDeleteProductService DeleteProductService { get; }
        IMergeUserCartAndBrowserCartService MergeUserCartAndBrowserCartService { get; }
        IisExistCartByUserIdService IsExistCartByUserIdService { get; }
        IisExistCartByBrowserIdService IsExistCartByBrowserIdService { get; }
        IAddCartService AddCartService { get; }
    }
}
