using Store_Application.Domain.Enums;
using System;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings
{
    public class GetAdvertisingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
        public string LinkTo { get; set; }
        public AdvertisingPlaces Place { get; set; }
    }
}
