using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisingsForAdmin
{
    public interface IGetAdvertisingsForAdminService
    {
        ResultDto<ResultGetAdvertisingForAdminDto> Execeute(int page, int take);
    }
}
