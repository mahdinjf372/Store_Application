using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Categories.Queries.IsExistCategory
{
    public interface IisExistCategoryService
    {
        ResultDto<bool> Execute(int id);
    }
}
