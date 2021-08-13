using Store_Application.Application.Services.Categories.Commands.AddCategory;
using Store_Application.Application.Services.Categories.Commands.EditCategory;
using Store_Application.Application.Services.Categories.Commands.RemoveCategory;
using Store_Application.Application.Services.Categories.Queries.GetCategories;
using Store_Application.Application.Services.Categories.Queries.IsExistCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ICategoryFacad
    {
        IGetCategoriesService GetCategoriesService { get; }
        IAddCategoryService AddCategoryService { get; }
        IEditCategoryService EditCategoryService { get; }
        IisExistCategoryService isExistCategoryService { get; }
        IRemoveCategoryService removeCategoryService { get; }
    }
}
