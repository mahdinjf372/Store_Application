using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.IsExistUserForAdmin
{
    public interface IisExistUserForAdminService
    {
        ResultDto<bool> Execute(int id);
    }
}
