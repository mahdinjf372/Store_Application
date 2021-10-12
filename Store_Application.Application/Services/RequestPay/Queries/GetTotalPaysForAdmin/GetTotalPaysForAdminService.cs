using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.RequestPay.Queries.GetTotalPaysForAdmin
{
    public class GetTotalPaysForAdminService : IGetTotalPaysForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetTotalPaysForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<decimal> Execute()
        {
            var totalAmount = _db.RequestPays.Where(r => r.IsPay).Sum(r => r.Amount);

            return new ResultDto<decimal>
            {
                Data = totalAmount,
                IsSuccess = true,
            };
        }
    }
}
