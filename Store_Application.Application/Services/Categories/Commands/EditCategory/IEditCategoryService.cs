using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Categories.Commands.EditCategory
{
    public interface IEditCategoryService
    {
        ResultDto Execute(int id, string newTitle);
    }
}
