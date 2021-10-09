using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public class GetCompareListService : IGetCompareListService
    {
        private readonly IDataBaseContext _db;
        public GetCompareListService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetCompareDto>> Execute(Guid browserId, int? userId)
        {
            var query = _db.Compares.AsQueryable();

            if (userId != null)
            {
                query = query.Where(c => c.UserId == userId).AsQueryable();
            }
            else
            {
                query = query.Where(c => c.UserId == null && c.BrowserId == browserId).AsQueryable();
            }

            var list = query
                .Include(c => c.Product)
                .ThenInclude(p => p.Features)
                .ThenInclude(pf => pf.Feature)
                .OrderByDescending(c => c.InsertTime)
                .Take(3)
                .Select(c => new ResultGetCompareDto
                {
                    Product = new ProductCompareDto
                    {
                        Id = c.ProductId,
                        Title = c.Product.Title,
                        DiscountAmount = c.Product.DiscountAmount,
                        Price = c.Product.Price,
                        PriceWithDiscount = (c.Product.Price - c.Product.DiscountAmount),
                        ImageName = c.Product.Images.SingleOrDefault(i => i.IsMainImage).Name,
                        Inventory = c.Product.Inventory
                    },
                    ProductFeature = c.Product.Features.Select(pf => new ProductFeatureDto
                    {
                        Id = pf.Id,
                        Value = pf.Value,
                        IsBold = pf.isBold,
                        ProductId = pf.ProductId,
                        FeatureId = pf.FeatureId
                    }).ToList(),
                    Feature = c.Product.Features.Select(pf => new FeatureDto
                    {
                        Id = pf.FeatureId,
                        Title = pf.Feature.Title,
                    }).ToList()
                }).ToList();

            return new ResultDto<List<ResultGetCompareDto>>
            {
                Data = list,
                IsSuccess = true
            };
        }
    }
}