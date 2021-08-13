using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Commands.RecoveryPasswordByActivationCode
{
    public interface IRecoveryPasswordByActivationCodeService
    {
        ResultDto Execute(string activationCode, string password);
    }
}
