using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Advertinig.Queries.IsExist
{
    public interface IisExistAdvertisingService
    {
        ResultDto<bool> Execute(int id); 
    }

    public class IsExistAdvertisingService : IisExistAdvertisingService
    {
        private readonly IDataBaseContext _db;
        public IsExistAdvertisingService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            var res = _db.Advertisings.Any(a=> a.Id.Equals(id));

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
