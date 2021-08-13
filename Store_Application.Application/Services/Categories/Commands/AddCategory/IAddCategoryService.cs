using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Categories.Commands.AddCategory
{
    public interface IAddCategoryService
    {
        ResultDto Execute(RequestAddCategoryDto req);
    }
}
