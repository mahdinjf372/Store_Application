using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Favorite.Queries.GetFavoriteList
{
    public class GetFavoriteListService : IGetFavoriteListService
    {
        private readonly IDataBaseContext _db;
        public GetFavoriteListService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetFavoriteListDto>> Execute(Guid browserId, int? userId = null)
        {
            var query = _db.Favorites.Include(f=> f.Product).AsQueryable();
            if (userId != null)
            {
                query = query.Where(f => f.UserId == userId).AsQueryable();
            }
            else
            {
                query = query.Where(f => f.UserId == null && f.BrowserId == browserId).AsQueryable();
            }

            var res = query.Select(f => new ResultGetFavoriteListDto
            {
                Id = f.Id,
                Price = f.Product.Price,
                DiscountAmount = f.Product.DiscountAmount,
                PriceWithDiscount = f.Product.Price - f.Product.DiscountAmount,
                Title = f.Product.Title,
                ProductId = f.ProductId,
                ImageName = f.Product.Images.Single(i=> i.IsMainImage).Name
                
            }).ToList();

            return new ResultDto<List<ResultGetFavoriteListDto>>()
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}