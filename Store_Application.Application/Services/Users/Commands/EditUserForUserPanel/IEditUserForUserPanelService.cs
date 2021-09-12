using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Commands.EditUserForUserPanel
{
    public interface IEditUserForUserPanelService
    {
        ResultDto Execute(RequestEditUserForUserPanelDto req);
    }
}
