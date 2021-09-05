using Store_Application.Domain.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Advertising.LoadAdvertisings
{
    public class AdvertisingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string LinkTo { get; set; }
        public bool isRemoved { get; set; }
        public AdvertisingPlaces Place { get; set; }
    }
}
