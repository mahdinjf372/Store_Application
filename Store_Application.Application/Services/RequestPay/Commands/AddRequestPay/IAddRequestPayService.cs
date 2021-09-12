using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.Finance;

namespace Store_Application.Application.Services.RequestPay.Commands.AddRequestPay
{
    public interface IAddRequestPayService
    {
        ResultDto<ResultAddRequestPayDto> Execute(int userId, decimal totalAmount);
    }
}
