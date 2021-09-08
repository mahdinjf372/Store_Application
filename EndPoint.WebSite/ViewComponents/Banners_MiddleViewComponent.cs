using EndPoint.WebSite.Models.Components.Banners_Middle;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.EndPoint.UI.Site.Components
{
    public class Banners_MiddleViewComponent : ViewComponent
    {
        private IAdvertisingFacad _advertisingFacad;
        public Banners_MiddleViewComponent(IAdvertisingFacad advertisingFacad)
        {
            _advertisingFacad = advertisingFacad;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ads = _advertisingFacad.GetAdvertisingsService.Execeute();

            List<BannerViewModel> model = ads.Data.Select(b => new BannerViewModel
            {
                Id = b.Id,
                Title = b.Title,
                ImageName = b.ImageName,
                LinkTo = b.LinkTo,
                Place = b.Place
            }).ToList();

            return View("/Views/Shared/Components/Banners_Middle/Banners_Middle.cshtml", model);
        }
    }
}
