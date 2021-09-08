using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Collections.Generic;
using EndPoint.WebSite.Models.Components.Slider_Products;
using System.Linq;

namespace Store.EndPoint.UI.Site.Components
{
    public class Slider_ProductsViewComponent : ViewComponent
    {
        private IProductFacad _productFacad;
        public Slider_ProductsViewComponent(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public async Task<IViewComponentResult> InvokeAsync(RequestSlider_Products req)
        {
            var res = _productFacad.GetProductsBySliderIdService.Execute(req.SliderId);

            List<SliderProductViewModel> model = res.Data.Products.Select(p => new SliderProductViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Price = p.Price,
                ImageName = p.ImageTitle,
                DiscountAmount = p.DiscountAmount,
                PriceWithDiscount = (p.Price - p.DiscountAmount)
            }).ToList();
            ViewBag.SliderTitle = res.Data.SliderTitle;
            return View($"/Views/Shared/Components/Slider_Product_{req.SliderName}/Slider_Product_{req.SliderName}.cshtml", model);
        }
    }


}
