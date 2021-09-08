using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Components.Slider_Products
{
    public class SliderProductViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal PriceWithDiscount { get; set; }

        public string ImageName { get; set; }

    }
}
