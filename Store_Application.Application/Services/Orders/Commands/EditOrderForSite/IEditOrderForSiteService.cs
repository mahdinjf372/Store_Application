using Microsoft.EntityFrameworkCore;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.Commands.EditOrderForSite
{
    public interface IEditOrderForSiteService
    {
        ResultDto Execute(RequestEditOrerForSiteDto req);
    }
}
