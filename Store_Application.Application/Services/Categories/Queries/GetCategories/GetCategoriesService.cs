using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
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

        public ResultDto<List<ResultGetCategoriesDto>> Execute()
        {
            List<ResultGetCategoriesDto> res = _db.Categories
                .Include(c => c.ParentCategory)
                .Include(c => c.SubCategories)
                .Select(c=> new ResultGetCategoriesDto 
                {
                    Id = c.Id,
                    Title = c.Title,
                    ImageName = c.ImageName,
                    ParentCategoryId = c.ParentCategoryId,
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
