using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Categories.Queries.GetCategoriesForAdmin
{
    public class GetCategoriesForAdminService : IGetCategoriesForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetCategoriesForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetCategoriesForAdminDto>> Execute(int? parentCategoryId = null, bool IgnoreFilters = false)
        {
            IQueryable<Category> cats = _db.Categories;
            if (IgnoreFilters)
            {
                cats = cats.IgnoreQueryFilters();
            }

            List<ResultGetCategoriesForAdminDto> res = cats
                .Where(c=> c.ParentCategoryId.Equals(parentCategoryId))
                .Include(c => c.ParentCategory)
                .Include(c => c.SubCategories)
                .Select(c=> new ResultGetCategoriesForAdminDto 
                {
                    Id = c.Id,
                    Title = c.Title,
                    ImageName = c.ImageName,
                    ParentCategory = c.ParentCategory,
                    ParentCategoryId = c.ParentCategoryId,
                    SubCategories = c.SubCategories,
                    isRemoved = c.isRemoved
                })
                .ToList();

            return new ResultDto<List<ResultGetCategoriesForAdminDto>>
            {
                Data = res,
                IsSuccess = true,
                Message = "دسته بندی ها با موفقیت از دیتابیس واکشی شدند"
            };
        }
    }
}
