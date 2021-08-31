using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductSliders.Queries.GetProductSliders
{
    public interface IGetProductSlidersService
    {
        ResultDto<List<ResultGetProductSlidersDto>> Execute(int productId);
    }
}
