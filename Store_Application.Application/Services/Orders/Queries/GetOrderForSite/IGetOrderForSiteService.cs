using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForSite
{
    public interface IGetOrderForSiteService
    {
        ResultDto<ResultGetOrderDto> Execute(int userId);
    }
}
