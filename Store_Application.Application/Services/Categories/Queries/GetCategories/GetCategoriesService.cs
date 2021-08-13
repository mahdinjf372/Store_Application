using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Categories.Queries.GetCategories
{
    public class GetCategoriesService : IGetCategoriesService
    {
        private readonly IDataBaseContext _db;
        public GetCategoriesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetCategoriesDto>> Execute(int? parentCategoryId = null)
        {
            List<ResultGetCategoriesDto> res = _db.Categories.IgnoreQueryFilters()
                .Where(c=> c.ParentCategoryId.Equals(parentCategoryId))
                .Include(c => c.ParentCategory)
                .Include(c => c.SubCategories)
                .Select(c=> new ResultGetCategoriesDto 
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

            return new ResultDto<List<ResultGetCategoriesDto>>
            {
                Data = res,
                IsSuccess = true,
                Message = "دسته بندی ها با موفقیت از دیتابیس واکشی شدند"
            };
        }
    }
}
