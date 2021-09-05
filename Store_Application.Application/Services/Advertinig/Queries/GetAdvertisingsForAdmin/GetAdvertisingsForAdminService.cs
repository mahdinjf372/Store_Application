using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Advertinig.Queries.GetAdvertisingsForAdmin
{
    public class GetAdvertisingsForAdminService : IGetAdvertisingsForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetAdvertisingsForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetAdvertisingForAdminDto> Execeute(int page, int take)
        {
            int rowCount = 0;
            var ads = _db.Advertisings.IgnoreQueryFilters()
                .Select(a => new GetAdvertisingForAdminDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    StartDate = a.StartDate,
                    EndDate = a.EndDate,
                    Place = a.Place,
                    ImageName = a.ImageName,
                    LinkTo = a.LinkTo,
                    IsRemoved = a.isRemoved
                }).ToPaged(page,take,out rowCount).ToList();

            double ee = ((double)rowCount) / ((double)take);
            int pageCount = (int)Math.Ceiling(ee);

            ResultGetAdvertisingForAdminDto res = new ResultGetAdvertisingForAdminDto
            {
                Ads = ads,
                CurrentPage = page,
                PageCount = pageCount
            };

            return new ResultDto<ResultGetAdvertisingForAdminDto>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}
