using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Queries.IsExistCartByUserId
{
    public class IsExistCartByUserIdService : IisExistCartByUserIdService
    {
        private readonly IDataBaseContext _db;
        public IsExistCartByUserIdService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int userId)
        {
            var res = _db.Carts.Any(c => c.UserId == userId && !c.Finished);

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}
