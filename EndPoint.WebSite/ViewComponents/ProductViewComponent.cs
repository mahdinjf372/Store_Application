using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Components.Product;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductFacad _productFacad;
        public ProductViewComponent(IProductFacad productFacad)
        {
            _productFacad = productFacad;
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

            return View("/Views/Shared/Components/Product/Product.cshtml", model);
        }
    }
}
