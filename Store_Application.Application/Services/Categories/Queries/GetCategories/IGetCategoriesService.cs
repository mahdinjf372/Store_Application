using Store_Application.Common.ViewModels;
using System.Collections.Generic;

namespace Store_Application.Application.Services.Categories.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<ResultGetCategoriesDto>> Execute(int? parentCategoryId = null);
    }
}
