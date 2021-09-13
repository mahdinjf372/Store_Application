using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel
{
    public interface IGetOrdersForUserPanelService
    {
        ResultDto<List<ResultGetOrderForUserPanel>> Execute(int userId);
    }
}
