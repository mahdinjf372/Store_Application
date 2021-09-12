using System.Collections.Generic;

namespace EndPoint.WebSite.Models.Components.Product
{
    public class FeatureViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductFeatureViewModel> ProductFeatures { get; set; }
    }
}
