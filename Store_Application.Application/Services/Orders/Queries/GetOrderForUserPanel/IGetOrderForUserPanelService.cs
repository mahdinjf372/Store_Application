using Store_Application.Common.ViewModels;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel
{
    public interface IGetOrderForUserPanelService
    {
        ResultDto<ResultGetOrderForUserPanelDto> Execute(int orderId);
    }
}
