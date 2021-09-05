using System.Collections.Generic;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisingsForAdmin
{
    public class ResultGetAdvertisingForAdminDto
    {
        public IEnumerable<GetAdvertisingForAdminDto> Ads { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
