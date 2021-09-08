using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Collections.Generic;
using System.Linq;
using EndPoint.WebSite.Models.Components.Slider_Brands;

namespace Store.EndPoint.UI.Site.Components
{
    public class Slider_BrandsViewComponent : ViewComponent
    {
        private IBrandSliderFacad _brandSliderFacad;
        public Slider_BrandsViewComponent(IBrandSliderFacad brandSliderFacad)
        {
            _brandSliderFacad = brandSliderFacad;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var res = _brandSliderFacad.GetSlidesService.Execute();

            List<Slider_BrandViewModel> model = res.Data.Select(b => new Slider_BrandViewModel
            {
                Id = b.Id,
                Title = b.Title,
                ImageName = b.ImageName,
                LinkTo = b.LinkTo
                
            }).ToList();

            return View($"/Views/Shared/Components/Slider_Brands/Slider_Brands.cshtml", model);
        }
    }
}
