using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Commands.AddToCompare
{
    public interface IAddToCompareService
    {
        ResultDto Execute(int productId, Guid browserId, int? userId = null);
    }
}
