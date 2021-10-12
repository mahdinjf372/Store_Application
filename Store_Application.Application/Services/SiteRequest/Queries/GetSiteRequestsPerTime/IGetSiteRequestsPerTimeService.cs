using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime
{
    public interface IGetSiteRequestsPerTimeService
    {
        ResultDto<List<ResultGetSiteRequestDto>> Execute(RequestGetSiteRequestDto req);
    }

}
