using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Queries.IsExistFeature
{
    public interface IisExistFeatureService
    {
        ResultDto<bool> Execute(string featureName);
        ResultDto<bool> Execute(int id);

    }
}
