using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForAdmin
{
    public interface IGetProductsForAdminService
    {
        ResultDto<ResultGetProductsDto> Execute(RequestGetProductsDto req);
    }
}
