using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.ProductFeatures.LoadProductFeatures
{
    public class LoadProductFeaturesViewModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }
        public string FeatureName { get; set; }
        public bool IsRemoved { get; set; }
    }
}
