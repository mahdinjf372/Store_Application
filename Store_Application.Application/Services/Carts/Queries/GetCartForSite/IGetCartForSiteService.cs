using Store_Application.Common.ViewModels;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Queries.GetCartForSite
{
    public interface IGetCartForSiteService
    {
        ResultDto<CartDto> Execute(int userId, Guid BrowserId);
    }

}
