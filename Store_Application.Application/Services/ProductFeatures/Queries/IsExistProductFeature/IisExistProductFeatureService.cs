using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature
{
    public interface IisExistProductFeatureService
    {
        ResultDto<bool> Execute(RequestIsExistProductFeatureDto req);
        ResultDto<bool> Execute(int pfId);

    }
}
