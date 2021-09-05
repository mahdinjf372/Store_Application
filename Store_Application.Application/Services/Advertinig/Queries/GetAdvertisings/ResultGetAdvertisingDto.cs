using System.Collections.Generic;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings
{
    public class ResultGetAdvertisingDto
    {
        public IEnumerable<GetAdvertisingDto> Ads { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
