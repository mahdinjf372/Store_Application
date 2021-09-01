using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.MainSlider.Index
{
    public class MainSlideViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
    }
}
