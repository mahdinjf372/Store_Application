using Microsoft.AspNetCore.Http;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Advertising.Edit
{
    public class EditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AdvertisingPlaces Place { get; set; }
        public string ImageName { get; set; }
        public IFormFile Image { get; set; }
    }
}
