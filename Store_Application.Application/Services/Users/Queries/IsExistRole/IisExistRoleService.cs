using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.IsExistRole
{
    public interface IisExistRoleService
    {
        ResultDto<bool> Execute(int id);
    }
}
