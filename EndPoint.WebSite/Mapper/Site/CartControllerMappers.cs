using AutoMapper;
using Store_Application.Application.Services.Carts.Queries.GetCartForSite;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Mapper.Site
{
    public class CartControllerMappers : Profile
    {
        public CartControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<CartDto, Models.Cart.Index.CartViewModel>();
            CreateMap<CartItemDto, Models.Cart.Index.CartItemViewModel>()
                .ForMember(outer=> outer.PriceWithDiscount, opt => opt.MapFrom(inner => inner.Price - inner.DiscountAmount));

            CreateMap<CartDto, Models.Cart.LoadCart.CartViewModel>();
            CreateMap<CartItemDto, Models.Cart.LoadCart.CartItemViewModel>()
                .ForMember(outer => outer.PriceWithDiscount, opt => opt.MapFrom(inner => inner.Price - inner.DiscountAmount));

        }
    }
}
