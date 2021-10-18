using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Order.Index;
using Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel;
using Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel;

namespace EndPoint.WebSite.Mapper.UserPanel
{
    public class OrderControllerMappers : Profile
    {
        public OrderControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetOrderForUserPanel, OrdersViewModel>();
            CreateMap<Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel.OrderDetailDto, OrderDetailViewModel>();

            CreateMap<ResultGetOrderForUserPanelDto, Areas.UserPanel.Models.Order.ShowOrderInfo.ShowOrderInfoViewModel>();
            CreateMap<Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel.OrderDetailDto,
                Areas.UserPanel.Models.Order.ShowOrderInfo.OrderDetailViewModel>();

        }
    }
}
