using Store_Application.Common.ViewModels;
using System.Collections.Generic;

namespace Store_Application.Application.Services.Categories.Queries.GetCategoriesForAdmin
{
    public interface IGetCategoriesForAdminService
    {
        ResultDto<List<ResultGetCategoriesForAdminDto>> Execute(int? parentCategoryId = null, bool IgnoreFilters = false);
    }
}
