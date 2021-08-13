using System.Collections.Generic;
using System.Linq;
using Store_Application.Common.ViewModels;
using Store_Application.Application.Interfaces.Context;
using System;

namespace Store_Application.Application.Services.Brands.Queries.GetBrands
{
    public class GetBrandsService : IGetBrandsService
    {
        private readonly IDataBaseContext _db;
        public GetBrandsService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetBrandsDto>> Execute()
        {
            
            var res = _db.Brands.Select(b => new ResultGetBrandsDto
            {
                Id = b.Id,
                Name = b.Title
            }).ToList();

            return new ResultDto<List<ResultGetBrandsDto>>
            {
                Data = res,
                IsSuccess = true,
                Message = "با موفقیت واکشی شد"
            };
        }
    }
}
