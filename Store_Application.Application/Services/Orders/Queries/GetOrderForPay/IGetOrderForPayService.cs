using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForPay
{
    public interface IGetOrderForPayService
    {
        ResultDto<ResultGetOrderForPayDto> Execute(int userId);
    }
}
