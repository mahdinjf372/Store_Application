using Store_Application.Domain.Entities.Common;
using System;

namespace Store_Application.Domain.Entities.Product
{
    public class ProductSlider : BaseEntity<int>
    {
        public DateTime EndDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int SliderId { get; set; }
        public Slider Slider { get; set; }
    }
}
