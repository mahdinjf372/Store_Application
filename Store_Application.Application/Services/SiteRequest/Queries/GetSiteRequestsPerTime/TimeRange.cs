using System;

namespace Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime
{
    public class TimeRange
    {
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string FromTimeForView { get; set; }
        public string ToTimeForView { get; set; }
    }

}
