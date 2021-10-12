using Store_Application.Application.Services.SiteRequest.Commands.AddRequest;
using Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ISiteRequestFacad
    {
        IAddRequestService AddRequestService { get; }
        IGetSiteRequestsPerTimeService GetSiteRequestsPerTimeService { get; }
    }
}
