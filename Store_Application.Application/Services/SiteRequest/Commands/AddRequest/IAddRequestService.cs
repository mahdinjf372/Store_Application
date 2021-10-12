using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Statistic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.SiteRequest.Commands.AddRequest
{
    public interface IAddRequestService
    {
        ResultDto Execute(RequestAddRequestDto req);
    }
}
