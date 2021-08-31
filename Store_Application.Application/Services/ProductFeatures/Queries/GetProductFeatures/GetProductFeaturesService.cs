﻿using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeatures
{
    public class GetProductFeaturesService : IGetProductFeaturesService
    {
        private readonly IDataBaseContext _db;
        public GetProductFeaturesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetProductFeaturesDto>> Execute(int productId)
        {
            var res = _db.ProductFeatures
                .Where(pf => pf.ProductId.Equals(productId))
                .Include(pf => pf.Feature)
                .Select(pf => new ResultGetProductFeaturesDto
                {
                    Id = pf.Id,
                    FeatureName = pf.Feature.Title,
                    IsBold = pf.isBold,
                    Value = pf.Value,
                    IsRemoved = pf.isRemoved
                })
                .ToList();

            return new ResultDto<List<ResultGetProductFeaturesDto>>
            {
                Data = res,
                IsSuccess = true,
                Message = "ویژگی های محصول با موفقیت واکشی شد"
            };

        }
    }
}
