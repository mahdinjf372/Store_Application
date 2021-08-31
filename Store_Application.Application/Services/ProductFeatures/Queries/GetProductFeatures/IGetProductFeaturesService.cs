using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeatures
{
    public interface IGetProductFeaturesService
    {
        ResultDto<List<ResultGetProductFeaturesDto>> Execute(int productId);
    }
}
