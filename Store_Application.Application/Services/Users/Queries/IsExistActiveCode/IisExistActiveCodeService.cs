using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.IsExistActiveCode
{
    public interface IisExistActiveCodeService
    {
        ResultDto<bool> Execute(string activationCode);
    }

    public class isExistActiveCodeService : IisExistActiveCodeService
    {
        private readonly IDataBaseContext _db;
        public isExistActiveCodeService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(string activationCode)
        {
            var res = _db.Users.Any(u => u.ActiveCode.Equals(activationCode));

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
                Message = "جستوجوی دیتابیس برای وجود کد فعالسازی با موفیت انجام شد"
            };
        }
    }
}
