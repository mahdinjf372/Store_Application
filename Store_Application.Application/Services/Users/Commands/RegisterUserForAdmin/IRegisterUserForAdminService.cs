using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin
{
    public interface IRegisterUserForAdminService
    {
        ResultDto Execute(RequestRegisterUserForAdminDto req);
    }
}
