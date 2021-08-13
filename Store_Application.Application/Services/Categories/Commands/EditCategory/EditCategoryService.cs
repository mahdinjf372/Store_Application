using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Categories.Commands.EditCategory
{
    //TODO add image 

    public class EditCategoryService : IEditCategoryService
    {
        private readonly IDataBaseContext _db;
        public EditCategoryService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id, string newTitle)
        {
            var cat = _db.Categories.Find(id);
            cat.Title = newTitle;

            _db.Categories.Update(cat);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت ویرایش شد"
            };
        }
    }
}
