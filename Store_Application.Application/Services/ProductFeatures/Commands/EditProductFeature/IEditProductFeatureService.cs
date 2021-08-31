using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature
{
    public interface IEditProductFeatureService
    {
        ResultDto Execute(RequestEditProductFeatureDto req);
    }
}
