using System.Collections.Generic;
using System.Linq;
using Store_Application.Common.ViewModels;
using Store_Application.Application.Interfaces.Context;
using System;
using Store_Application.Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Brands.Queries.GetBrandsForAdmin
{
    public class GetBrandsForAdminService : IGetBrandsForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetBrandsForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetBrandsForAdminDto>> Execute(bool IgnoreFilters = false)
        {
            IQueryable<Brand> brands = _db.Brands;
            if (IgnoreFilters)
            {
                brands = brands.IgnoreQueryFilters();
            }

            var res = brands.Select(b => new ResultGetBrandsForAdminDto
            {
                Id = b.Id,
                Name = b.Title
            }).ToList();

            return new ResultDto<List<ResultGetBrandsForAdminDto>>
            {
                Data = res,
                IsSuccess = true,
                Message = "با موفقیت واکشی شد"
            };
        }
    }
}
