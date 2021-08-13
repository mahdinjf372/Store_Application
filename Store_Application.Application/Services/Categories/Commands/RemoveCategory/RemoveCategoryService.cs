using Microsoft.EntityFrameworkCore;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Categories.Commands.RemoveCategory
{
    public class RemoveCategoryService : IRemoveCategoryService
    {
        private readonly IDataBaseContext _db;
        public RemoveCategoryService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int categoryId)
        {
            var cat = _db.Categories
                .Include(c => c.SubCategories)
                .ThenInclude(c => c.SubCategories)
                .SingleOrDefault(c => c.Id.Equals(categoryId));
                

            cat.isRemoved = true;
            cat.RemovedTime = DateTime.Now;

            foreach(var subCat in cat.SubCategories)
            {
                subCat.isRemoved = true;
                subCat.RemovedTime = DateTime.Now;

                foreach (var subgroup in subCat.SubCategories)
                {
                    subgroup.isRemoved = true;
                    subgroup.RemovedTime = DateTime.Now;
                }
            }

            _db.Categories.Update(cat);
            _db.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت حذف شد"
            };
        }
    }
}
