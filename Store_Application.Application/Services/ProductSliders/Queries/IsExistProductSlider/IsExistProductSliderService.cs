using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.ProductSliders.Queries.IsExistProductSlider
{
    public class IsExistProductSliderService : IisExistProductSliderService
    {
        private readonly IDataBaseContext _db;
        public IsExistProductSliderService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int productId, int sliderId)
        {
            var res = _db.ProductSliders.Any(ps=> 
                        ps.ProductId.Equals(productId) && 
                        ps.SliderId.Equals(sliderId) &&
                        !ps.isRemoved);

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}
