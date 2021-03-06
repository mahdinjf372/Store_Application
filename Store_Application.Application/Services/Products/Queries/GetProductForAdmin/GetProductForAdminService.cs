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

        public ResultDto<ResultGetProductForAdminDto> Execute(int productId)
        {
            var query = _db.Products.IgnoreQueryFilters().AsQueryable();
            query = query.Include(p => p.Category).ThenInclude(c => c.ParentCategory).ThenInclude(c => c.ParentCategory);
            query = query.Include(p => p.Images).Include(p=> p.Tags);
            var product = query.Select(p=> new ResultGetProductForAdminDto
            {
                Id = p.Id,
                Title = p.Title,
                ShortDescription = p.ShortDescription,
                Decription = p.Description,
                Tags = p.Tags.Where(t=> !t.isRemoved).Select(t=> t.Title).ToList(),
                SubgroupId = p.Category.Id,
                GroupId = p.Category.ParentCategory.Id,
                CategoryId = p.Category.ParentCategory.ParentCategory.Id,
                BrandId = p.BrandId,
                Inventory = p.Inventory,
                Price = p.Price,
                DiscountAmount = p.DiscountAmount,
                Displayed = p.Displayed,
                Images = p.Images.Where(i=> !i.isRemoved).Select(i=> new ProductImageForAdminDto
                        {
                            Id = i.Id,
                            Name = i.Name,
                            IsMainImages = i.IsMainImage
                        }).ToList(),
            }).SingleOrDefault(p => p.Id.Equals(productId));
          
            product.Decription = DecodeDescriptionMedia(product.Decription);
            return new ResultDto<ResultGetProductForAdminDto>
            {
                Data = product,
                IsSuccess = true,
                Message = "محصول با موفقیت واکشی شد"
            };
        }

        private string DecodeDescriptionMedia(string des)
        {
            
            //encode Elements
            des = des.Replace("<div class=\"content-expert-img mr-auto ml-auto ", "<figure class=\"");
            des = des.Replace("</div>", "</figure>");
            des = des.Replace("><img class=\"w-100\" src=\"/images/page-single-product/tab-content/", "><img src=\"/images/page-single-product/tab-content/");
            return des;
        }

    }





}
