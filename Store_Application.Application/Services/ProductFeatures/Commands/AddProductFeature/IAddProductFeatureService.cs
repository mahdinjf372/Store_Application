using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature
{
    public interface IAddProductFeatureService
    {
        ResultDto Execute(RequestAddProductFeatureDto req);
    }
}
