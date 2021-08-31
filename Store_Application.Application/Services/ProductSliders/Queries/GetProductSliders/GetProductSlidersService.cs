using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.ProductSliders.Queries.GetProductSliders
{
    public class GetProductSlidersService : IGetProductSlidersService
    {
        private readonly IDataBaseContext _db;
        public GetProductSlidersService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetProductSlidersDto>> Execute(int productId)
        {
            var res = _db.ProductSliders
                .Where(ps => ps.ProductId.Equals(productId) && !ps.isRemoved)
                .Select(ps => new ResultGetProductSlidersDto
                {
                    Id = ps.Id,
                    StartDate = ps.InsertTime,
                    EndDate = ps.EndDate,
                    SliderId = ps.SliderId
                }).ToList();

            return new ResultDto<List<ResultGetProductSlidersDto>>
            {
                Data = res,
                IsSuccess = true
            };

        }
    }
}
