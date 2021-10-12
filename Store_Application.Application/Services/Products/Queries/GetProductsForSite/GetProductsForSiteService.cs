using Store_Application.Common.ViewModels;
using Store_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForSite
{
    public class GetProductsForSiteService : IGetProductsForSiteService
    {
        private readonly IDataBaseContext _db;
        public GetProductsForSiteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetProductsForSiteDto> Execute(RequestGetProductsForSiteDto req)
        {
            try
            {
                var products = _db.Products.AsQueryable();

                if (!string.IsNullOrEmpty(req.Searchkey))
                {
                    string tagSearchKey = req.Searchkey.Trim();
                    while (tagSearchKey.Contains(" "))
                    {
                        tagSearchKey = tagSearchKey.Replace(" ", "_");
                    }

                    products = products.Where(p => p.Title.Contains(req.Searchkey) || p.TagsForSearch.Contains(tagSearchKey));
                }

                if (req.CategoryId != null && _db.Categories.Any(c=> c.Id.Equals(req.CategoryId)))
                {
                    products = products.Where(p => p.CategoryId.Equals(req.CategoryId));
                }

                switch (req.SortBy)
                {
                    case "جدیدترین":
                        products = products.OrderByDescending(p => p.InsertTime).AsQueryable();
                        break;

                    case "ارزانترین":
                        products = products.OrderBy(p => p.Price).AsQueryable();
                        break;

                    case "گرانترین":
                        products = products.OrderByDescending(p => p.Price).AsQueryable();
                        break;

                    default:
                        products = products.OrderByDescending(p => p.InsertTime).AsQueryable();
                        break;
                }

                int rowCount = 0;

                var productsDto = products
                    .Where(p=> p.Displayed)
                    .Include(p => p.Category).ThenInclude(c => c.ParentCategory).ThenInclude(c => c.ParentCategory)
                    .Select(p => new GetProductsForSiteDto
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Price = p.Price,
                        CategoryTitle = p.Category.ParentCategory.ParentCategory.Title,
                        GroupTitle = p.Category.ParentCategory.Title,
                        SubgroupTitle = p.Category.Title,
                        ImageTitle = p.Images.SingleOrDefault(i => i.IsMainImage).Name,
                        PriceWihtDiscount = p.Price - p.DiscountAmount,
                        DiscountAmount = p.DiscountAmount
                    }).ToPaged(req.Page, req.Take, out rowCount).ToList();



                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int)Math.Ceiling(ee);

                ResultGetProductsForSiteDto res = new ResultGetProductsForSiteDto()
                {
                    Products = productsDto,
                    CurrentPage = req.Page,
                    PageCount = pageCount
                };

                return new ResultDto<ResultGetProductsForSiteDto>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "محصولات با موفقیت واکشی شدند"
                };
            }
            catch (Exception)
            {
                return new ResultDto<ResultGetProductsForSiteDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی محصولات با شکست مواجه شد"
                };
            }
            
        }
    }
}
