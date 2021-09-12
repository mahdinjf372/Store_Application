using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Queries.IsExistCartByBrowserId
{
    public class IsExistCartByBrowserIdService : IisExistCartByBrowserIdService
    {
        private readonly IDataBaseContext _db;
        public IsExistCartByBrowserIdService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(Guid browserId)
        {
            var res = _db.Carts.Any(c => c.BrowserId == browserId && !c.Finished);

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}
