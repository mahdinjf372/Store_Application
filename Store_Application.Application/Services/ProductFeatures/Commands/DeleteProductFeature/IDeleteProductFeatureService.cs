using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Commands.DeleteProductFeature
{
    public interface IDeleteProductFeatureService
    {
        ResultDto Execute(int pf_Id);
    }
}
