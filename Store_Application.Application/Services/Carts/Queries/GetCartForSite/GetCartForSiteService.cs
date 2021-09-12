using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Queries.GetCartForSite
{
    public class GetCartForSiteService : IGetCartForSiteService
    {
        private readonly IDataBaseContext _db;
        public GetCartForSiteService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<CartDto> Execute(int userId, Guid BrowserId)
        {
            try
            {
                var query = _db.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                    .ThenInclude(p => p.Images).AsQueryable();

                if (userId==0)
                {
                    query = query.Where(c => c.BrowserId == BrowserId && c.Finished == false).AsQueryable();
                }
                else
                {
                    query = query.Where(c => c.UserId == userId && c.Finished == false).AsQueryable();
                }

                var cart = query.OrderByDescending(p => p.InsertTime)
                    .FirstOrDefault();

                if (cart == null)
                {
                    return new ResultDto<CartDto>()
                    {
                        Data = new CartDto()
                        {
                            CartItems = new List<CartItemDto>(),
                        },
                        IsSuccess = true
                    };
                }

                var res = new CartDto();
                res.ProductCount = cart.CartItems.Count();
                res.CartId = cart.Id;
                res.CartItems = cart.CartItems.Select(i => new CartItemDto
                {
                    Count = i.Count,
                    Inventory = i.Product.Inventory,
                    DiscountAmount = i.Product.DiscountAmount,
                    Price = i.Product.Price,
                    Id = i.Id,
                    ProductId = i.Product.Id,
                    Title = i.Product.Title,
                    ImageName = i.Product.Images.SingleOrDefault(i => i.IsMainImage).Name,
                }).ToList();

                res.SumAmount = CalculateSumAmount(cart.CartItems);

                return new ResultDto<CartDto>()
                {
                    Data = res,
                    IsSuccess = true,
                };
            }
            catch (Exception e)
            {
                return new ResultDto<CartDto>()
                {
                    IsSuccess = false,
                };
            }
        }

        private decimal CalculateSumAmount(ICollection<CartItem> cartItems)
        {
            decimal totalAmount = 0;
            foreach (var item in cartItems)
            {
                if (item.Product.DiscountAmount > 0)
                {
                    totalAmount += (item.Product.Price - item.Product.DiscountAmount) * item.Count;
                }
                else
                {
                    totalAmount += item.Product.Price * item.Count;
                }
            }
            return totalAmount;
        }
    }

}
