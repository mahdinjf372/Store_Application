using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Orders.Commands.FinalizeOrder
{
    public interface IFinalizeOrderService
    {
        ResultDto<bool> Execute(int orderId, string authority);
    }
}
