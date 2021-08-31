using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.ChangeProductSliders
{
    public class ChangeProductSlidersViewModel
    {
        public int ProductId { get; set; }
        public List<SliderViewModel> Sliders { get; set; }
    }

    public class SliderViewModel
    {
        public int SliderId { get; set; }
        public bool Checked { get; set; }
    }
}
