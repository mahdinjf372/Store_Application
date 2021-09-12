using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Commands.MergeUserCartAndBrowserCart
{
    public interface IMergeUserCartAndBrowserCartService
    {
        ResultDto Execute(int userId, Guid browserId);
    }
}
