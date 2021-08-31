using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.LoadProductSliders
{
    public class LoadProductSlidersViewModel
    {
        public List<SliderViewModel> Sliders { get; set; }
        public List<ProductSlidersViewModel> productSliders { get; set; }

    }
}
