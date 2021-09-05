using Store_Application.Common.ViewModels;
using Store_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForAdmin
{
    public class GetProductsForAdminService : IGetProductsForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetProductsForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetProductsForAdminDto> Execute(RequestGetProductsForAdminDto req)
        {
            try
            {
                var products = _db.Products.IgnoreQueryFilters().AsQueryable();

                if (!string.IsNullOrEmpty(req.Searchkey))
                {
                    products = products.Where(p => p.Title.Contains(req.Searchkey));
                }
                
                int rowCount = 0;

                var productsDto = products
                    .Include(p => p.Category).ThenInclude(c => c.ParentCategory).ThenInclude(c => c.ParentCategory)
                    .Select(p => new GetProductsForAdminDto
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Price = p.Price,
                        Inventory = p.Inventory,
                        Displayed = p.Displayed,
                        CategoryTitle = p.Category.ParentCategory.ParentCategory.Title,
                        GroupTitle = p.Category.ParentCategory.Title,
                        SubgroupTitle = p.Category.Title,
                        ImageTitle = p.Images.SingleOrDefault(i => i.IsMainImage && !i.isRemoved).Name,
                        IsRemoved = p.isRemoved
                    }).ToPaged(req.Page, req.Take, out rowCount).ToList();

                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int)Math.Ceiling(ee);

                ResultGetProductsForAdminDto res = new ResultGetProductsForAdminDto()
                {
                    Products = productsDto,
                    CurrentPage = req.Page,
                    PageCount = pageCount
                };

                return new ResultDto<ResultGetProductsForAdminDto>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "محصولات با موفقیت واکشی شدند"
                };
            }
            catch (Exception)
            {
                return new ResultDto<ResultGetProductsForAdminDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی محصولات با شکست مواجه شد"
                };
            }
            
        }
    }
}
