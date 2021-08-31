using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Sliders.Queries.GetSliders
{
    public class GetSlidersService : IGetSlidersService
    {
        private readonly IDataBaseContext _db;
        public GetSlidersService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetSlidersDto>> Execute()
        {
            var res = _db.Sliders.Select(s => new ResultGetSlidersDto
            {
                Id = s.Id,
                Title = s.Title
            }).ToList();

            return new ResultDto<List<ResultGetSlidersDto>>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
