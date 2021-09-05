using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Categories.Commands.AddCategory;
using Store_Application.Application.Services.Categories.Commands.EditCategory;
using Store_Application.Application.Services.Categories.Commands.RemoveCategory;
using Store_Application.Application.Services.Categories.Queries.GetCategoriesForAdmin;
using Store_Application.Application.Services.Categories.Queries.IsExistCategory;

namespace Store_Application.Application.Services.Categories.FacadPattern
{
    public class CategoryFacad : ICategoryFacad
    {
        private readonly IDataBaseContext _db;
        public CategoryFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetCategoriesForAdminService _getCategoriesForAdminService;
        public IGetCategoriesForAdminService GetCategoriesForAdminService
        {
            get
            {
                return _getCategoriesForAdminService = _getCategoriesForAdminService ?? new GetCategoriesForAdminService(_db);
            }
        }


        private IAddCategoryService _addCategoryService;
        public IAddCategoryService AddCategoryService
        {
            get
            {
                return _addCategoryService = _addCategoryService ?? new AddCategoryService(_db);
            }
        }


        private IEditCategoryService _editCategoryService;
        public IEditCategoryService EditCategoryService
        {
            get
            {
                return _editCategoryService = _editCategoryService ?? new EditCategoryService(_db);
            }
        }

        private IisExistCategoryService _isExistCategoryService;
        public IisExistCategoryService isExistCategoryService
        {
            get
            {
                return _isExistCategoryService = _isExistCategoryService ?? new isExistCategoryService(_db);
            }
        }

        private IRemoveCategoryService _removeCategoryService;
        public IRemoveCategoryService removeCategoryService
        {
            get
            {
                return _removeCategoryService = _removeCategoryService ?? new RemoveCategoryService(_db);
            }
        }
    }
}
