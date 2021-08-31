using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.GetProductForAdmin
{
    public class GetProductForAdminService : IGetProductForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetProductForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetProductDto> Execute(int productId)
        {
            var query = _db.Products.IgnoreQueryFilters().AsQueryable();
            query = query.Include(p => p.Category).ThenInclude(c => c.ParentCategory).ThenInclude(c => c.ParentCategory);
            query = query.Include(p => p.Images);
            var product = query.Select(p=> new ResultGetProductDto
            {
                Id = p.Id,
                Title = p.Title,
                ShortDescription = p.ShortDescription,
                Decription = p.Description,
                SubgroupId = p.Category.Id,
                GroupId = p.Category.ParentCategory.Id,

                CategoryId = p.Category.ParentCategory.ParentCategory.Id,
                BrandId = p.BrandId,
                Inventory = p.Inventory,
                Price = p.Price,
                DiscountAmount = p.DiscountAmount,
                Displayed = p.Displayed,
                Images = p.Images.Where(i=> !i.isRemoved).Select(i=> new ProductImage
                        {
                            Id = i.Id,
                            Name = i.Name,
                            IsMainImages = i.IsMainImage
                        }).ToList(),
            }).SingleOrDefault(p => p.Id.Equals(productId));

            return new ResultDto<ResultGetProductDto>
            {
                Data = product,
                IsSuccess = true,
                Message = "محصول با موفقیت واکشی شد"
            };
        }
    }





}
