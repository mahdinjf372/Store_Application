using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Store.EndPoint.UI.Site.Components
{
    public class Slider_AmazingViewComponent : ViewComponent
    {
        public Slider_AmazingViewComponent()
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Slider_Product_Amazing/Slider_Product_Amazing.cshtml");
        }
    }
}
