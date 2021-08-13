using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Categories.Commands.RemoveCategory
{
    public interface IRemoveCategoryService
    {
        ResultDto Execute(int categoryId);
    }
}
