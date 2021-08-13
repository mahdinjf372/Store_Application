using Store_Application.Common.ViewModels;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Queries.GetFeature
{
    public interface IGetFeatureService
    {
        ResultDto<ResultGetFeatureDto> Execute(int id);
    }
}
