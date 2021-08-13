using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Categories.Commands.AddCategory
{
    public class AddCategoryService : IAddCategoryService
    {
        private readonly IDataBaseContext _db;
        public AddCategoryService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddCategoryDto req)
        {
            Category cat = new Category()
            {
                Title = req.Title,
                ImageName = req.ImageName,
                ParentCategoryId = isExistCategory(req.ParentCategoryId) ? req.ParentCategoryId : null,
                InsertTime = DateTime.Now
            };

            _db.Categories.Add(cat);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت اضافه شد"
            };
        }

        private bool isExistCategory(int? categoryId)
        {
            return _db.Categories.Any(c => c.Id.Equals(categoryId));
        }
    }
}
