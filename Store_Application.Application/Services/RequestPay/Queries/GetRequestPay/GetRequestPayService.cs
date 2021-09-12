using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.RequestPay.Queries.GetRequestPay
{
    public class GetRequestPayService : IGetRequestPayService
    {
        private readonly IDataBaseContext _db;
        public GetRequestPayService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetRequestPayDto> Execute(Guid guid)
        {
            var requestPay = _db.RequestPays.Where(p => p.Guid == guid).FirstOrDefault();

            if (requestPay != null)
            {
                return new ResultDto<ResultGetRequestPayDto>()
                {
                    Data = new ResultGetRequestPayDto()
                    {
                        Amount = requestPay.Amount,
                        Id = requestPay.Id,
                    },
                    IsSuccess = true
                };
            }
            else
            {
                return new ResultDto<ResultGetRequestPayDto>()
                {
                    IsSuccess = true,
                    Message = "فاکتور شما یافت نشد"
                };
            }
        }
    }
}
