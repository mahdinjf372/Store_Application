using Store_Application.Common.ViewModels;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Queries.GetFeatureForAdmin
{
    public interface IGetFeatureForAdminService
    {
        ResultDto<ResultGetFeatureForAdminDto> Execute(int id);
    }
}
