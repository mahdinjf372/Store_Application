using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings
{
    public class GetAdvertisingsService : IGetAdvertisingsService
    {
        private readonly IDataBaseContext _db;
        public GetAdvertisingsService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetAdvertisingsDto>> Execeute()
        {
            var nowDate = DateTime.Now;
            var res = _db.Advertisings
                .Where(a=> a.EndDate >= nowDate && a.StartDate <= nowDate)
                .Select(a => new ResultGetAdvertisingsDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Place = a.Place,
                    ImageName = a.ImageName,
                    LinkTo = a.LinkTo,
                }).ToList();

            return new ResultDto<List<ResultGetAdvertisingsDto>>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}
