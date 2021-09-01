using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.MainSlider.Create
{
    public class CreateViewModel
    {
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
        public IFormFile Image { get; set; }
    }
}
