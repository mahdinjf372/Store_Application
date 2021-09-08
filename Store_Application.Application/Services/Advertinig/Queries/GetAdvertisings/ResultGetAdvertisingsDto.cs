using Store_Application.Domain.Enums;
using System;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings
{
    public class ResultGetAdvertisingsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
        public AdvertisingPlaces Place { get; set; }
    }
}
