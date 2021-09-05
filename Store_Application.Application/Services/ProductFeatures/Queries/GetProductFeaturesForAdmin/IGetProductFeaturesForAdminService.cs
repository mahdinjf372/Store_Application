using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeaturesForAdmin
{
    public interface IGetProductFeaturesForAdminService
    {
        ResultDto<List<ResultGetProductFeaturesForAdminDto>> Execute(int productId);
    }
}
