using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings
{
    public interface IGetAdvertisingsService
    {
        ResultDto<List<ResultGetAdvertisingsDto>> Execeute();
    }
}
