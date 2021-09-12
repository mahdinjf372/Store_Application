using Store_Application.Common.ViewModels;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {
        ResultDto<ResultGetProductForSiteDto> Execute(int productId);
    }
}
