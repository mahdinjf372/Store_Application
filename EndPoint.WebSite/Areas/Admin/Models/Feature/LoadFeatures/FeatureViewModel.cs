using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Feature.LoadFeatures
{
    public class FeatureViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool isRemoved { get; set; }
    }
}
