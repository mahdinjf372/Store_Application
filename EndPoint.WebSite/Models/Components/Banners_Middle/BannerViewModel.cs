using Store_Application.Domain.Enums;

namespace EndPoint.WebSite.Models.Components.Banners_Middle
{
    public class BannerViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
        public AdvertisingPlaces Place { get; set; }
    }
}
