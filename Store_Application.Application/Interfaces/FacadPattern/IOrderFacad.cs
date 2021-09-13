using Store_Application.Application.Services.Orders.Commands.EditOrderForSite;
using Store_Application.Application.Services.Orders.Commands.FinalizeOrder;
using Store_Application.Application.Services.Orders.Queries.GetOrderForPay;
using Store_Application.Application.Services.Orders.Queries.GetOrderForSite;
using Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel;
using Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IOrderFacad
    {
        IGetOrderForSiteService GetOrderForSiteService { get; }
        IEditOrderForSiteService EditOrderForSiteService { get; }
        IGetOrderForPayService GetOrderForPayService { get; }
        IFinalizeOrderService FinalizeOrderService { get; }
        IGetOrdersForUserPanelService GetOrdersForUserPanelService { get; }
        IGetOrderForUserPanelService GetOrderForUserPanelService { get; }

    }
}
