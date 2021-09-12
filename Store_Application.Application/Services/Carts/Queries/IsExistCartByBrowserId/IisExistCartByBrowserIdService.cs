using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Queries.IsExistCartByBrowserId
{
    public interface IisExistCartByBrowserIdService
    {
        ResultDto<bool> Execute(Guid browserId);
    }
}
