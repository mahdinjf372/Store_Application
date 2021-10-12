using Store_Application.Common.ViewModels;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public interface IGetOrdersForAdminService
    {
        ResultDto<ResultGetOrdersForAdminDto> Execute(RequestGetOrderForAdminDto req);
    }
}


