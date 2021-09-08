using Store_Application.Domain.Enums;

namespace EndPoint.WebSite.Models.Components.Slider_Products
{
    public class RequestSlider_Products
    {
        public ProductSliders SliderId { get; set; }
        public string SliderName { get; set; }
    }
}
