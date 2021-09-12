using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.GetProductForSite
{
    public class GetProductForSiteService : IGetProductForSiteService
    {
        private readonly IDataBaseContext _db;
        public GetProductForSiteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetProductForSiteDto> Execute(int productId)
        {
            if (!_db.Products.Any(p => p.Id.Equals(productId) && p.Displayed))
            {
                return new ResultDto<ResultGetProductForSiteDto>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }

            var product = _db.Products
            .Include(p => p.Category).ThenInclude(c => c.ParentCategory).ThenInclude(c => c.ParentCategory)
            .Include(p => p.Images)
            .Include(p => p.Brand)
            .Include(p => p.Features).ThenInclude(pf => pf.Feature)
            .Where(p => p.Id.Equals(productId))
            .Select(p => new ResultGetProductForSiteDto
            {
                Id = p.Id,
                Title = p.Title,
                ShortDescription = p.ShortDescription,
                Description = p.Description,
                SubgroupId = p.Category.Id,
                SubgroupTitle = p.Category.Title,
                GroupId = p.Category.ParentCategory.Id,
                GroupTitle = p.Category.ParentCategory.Title,
                CategoryId = p.Category.ParentCategory.ParentCategory.Id,
                CategoryTitle = p.Category.ParentCategory.ParentCategory.Title,
                Brand = new BrandDto
                {
                    Id = p.Brand.Id,
                    Title = p.Brand.Title
                },
                Inventory = p.Inventory,
                Price = p.Price,
                DiscountAmount = p.DiscountAmount,
                PriceWithDiscount = p.Price - p.DiscountAmount,
                Images = p.Images.Select(i => new ImageDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    IsMainImage = i.IsMainImage,
                }).ToList(),
                ProductFeatures = p.Features.Select(f => new ProductFeatureDto
                {
                    Id = f.Id,
                    IsBold = f.isBold,
                    FeatureId = f.FeatureId,
                    ProductId = f.ProductId,
                    Value = f.Value,
                    Feature = new FeatureDto
                    {
                        Id = f.Feature.Id,
                        Title = f.Feature.Title
                    }
                }).ToList()
            }).SingleOrDefault();

            return new ResultDto<ResultGetProductForSiteDto>
            {
                Data = product,
                IsSuccess = true,
                Message = "محصول با موفقیت واکشی شد"
            };
        }
    }





}
