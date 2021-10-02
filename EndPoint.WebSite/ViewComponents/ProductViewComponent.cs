using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Components.Product;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductFacad _productFacad;
        private readonly IFavoriteFacad _favoriteFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly CookiesManager _cookiesManager;

        public ProductViewComponent(
            IProductFacad productFacad,
            IFavoriteFacad favoriteFacad,
            ClaimUtility claimUtility,
            CookiesManager cookiesManager)
        {
            _productFacad = productFacad;
            _favoriteFacad = favoriteFacad;
            _claimUtility = claimUtility;
            _cookiesManager = cookiesManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var product = _productFacad.GetProductForSiteService.Execute(productId).Data;

            if (product == null)
            {
                return View("/Views/Error/NotFound.cshtml");
            }

            ProductViewModel model = new ProductViewModel()
            {
                Id = product.Id,
                Title = product.Title,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                SubgroupId = product.SubgroupId,
                SubgroupTitle = product.SubgroupTitle,
                GroupId = product.GroupId,
                GroupTitle = product.GroupTitle,
                CategoryId = product.CategoryId,
                CategoryTitle = product.CategoryTitle,
                Brand = new BrandViewModel
                {
                    Id = product.Brand.Id,
                    Title = product.Title
                },
                Inventory = product.Inventory,
                Price = product.Price,
                DiscountAmount = product.DiscountAmount,
                PriceWithDiscount = product.Price - product.DiscountAmount,
                Images = product.Images.Select(i => new ImageViewModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    IsMainImage = i.IsMainImage,
                }).ToList(),
                ProductFeatures = product.ProductFeatures.Select(f => new ProductFeatureViewModel
                {
                    Id = f.Id,
                    IsBold = f.IsBold,
                    FeatureId = f.FeatureId,
                    ProductId = f.ProductId,
                    Value = f.Value,
                    Feature = new FeatureViewModel
                    {
                        Id = f.Feature.Id,
                        Title = f.Feature.Title
                    }
                }).ToList()
            };

            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }
            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            model.IsFavorite = _favoriteFacad.IsFavoriteProductService.Execute(productId,browserId,userId).Data;

            return View("/Views/Shared/Components/Product/Product.cshtml", model);
        }
    }
}
