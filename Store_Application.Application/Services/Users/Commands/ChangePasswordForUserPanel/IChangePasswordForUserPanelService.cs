using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Commands.ChangePasswordForUserPanel
{
    public interface IChangePasswordForUserPanelService
    {
        ResultDto Execute(RequestChangePasswordForUserPanelDto req);
    }
}
