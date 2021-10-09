using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Commands.MergeCompare
{
    public interface IMergeCompareService
    {
        ResultDto Execute(int userId, Guid browserId);
    }
}
