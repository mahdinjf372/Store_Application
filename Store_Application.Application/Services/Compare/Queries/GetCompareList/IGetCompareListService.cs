using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public interface IGetCompareListService
    {
        ResultDto<List<ResultGetCompareDto>> Execute(Guid browserId, int? userId);
    }
}
