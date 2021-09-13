using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForSite
{
    public interface IGetProductsForSiteService
    {
        ResultDto<ResultGetProductsForSiteDto> Execute(RequestGetProductsForSiteDto req);
    }
}
