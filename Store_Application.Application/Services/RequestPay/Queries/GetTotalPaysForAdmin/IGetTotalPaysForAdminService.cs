using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.RequestPay.Queries.GetTotalPaysForAdmin
{
    public interface IGetTotalPaysForAdminService
    {
        ResultDto<decimal> Execute();
    }
}
