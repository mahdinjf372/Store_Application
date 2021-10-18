using AutoMapper;
using Store_Application.Application.Services.Orders.Commands.EditOrderForSite;
using Store_Application.Application.Services.Orders.Queries.GetOrderForSite;

namespace EndPoint.WebSite.Mapper.Site
{
    public class CheckoutControllerMappers : Profile
    {
        public CheckoutControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetOrderDto, Models.Checkout.Index.CheckoutViewModel>();
            CreateMap<OrderDetailDto, Models.Checkout.Index.OrderDetailViewModel>();

            CreateMap<Models.Checkout.Index.CheckoutViewModel, RequestEditOrerForSiteDto>();

        }
    }
}
