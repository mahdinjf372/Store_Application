using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime
{
    public class GetSiteRequestsPerTimeService : IGetSiteRequestsPerTimeService
    {
        private readonly IDataBaseContext _db;
        public GetSiteRequestsPerTimeService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetSiteRequestDto>> Execute(RequestGetSiteRequestDto req)
        {
            var query = _db.SiteRequests.AsQueryable();

            var timeList = HandleTimeOfStatistic(req.PerTime);

            List<ResultGetSiteRequestDto> res = new List<ResultGetSiteRequestDto>();

            foreach (var time in timeList)
            {
                res.Add(new ResultGetSiteRequestDto
                {
                    Count = query.Where(r => r.InsertTime > time.FromTime && r.InsertTime < time.ToTime).LongCount(),
                    TimeRange = time
                });
            }

            return new ResultDto<List<ResultGetSiteRequestDto>>
            {
                Data = res,
                IsSuccess = true
            };
        }

        private List<TimeRange> HandleTimeOfStatistic(PerTime perTime)
        {
            DateTime nowTime = DateTime.Now;

            List<TimeRange> timeList = new List<TimeRange>();

            switch (perTime)
            {
                case PerTime.Minutely:
                    for (int i = 6*60; i > 0; i--)
                    {
                        var time = new TimeRange();

                        time.FromTime = nowTime.AddMinutes(-i);
                        time.ToTime = nowTime.AddMinutes(-(i - 1));

                        time.ToTimeForView = time.ToTime.Hour + ":" + time.ToTime.Minute;

                        timeList.Add(time);
                    }
                    break;
                case PerTime.Hourly:
                    for (int i = 24; i > 0; i--)
                    {
                        var time = new TimeRange();

                        time.FromTime = nowTime.AddHours(-i);
                        time.ToTime = nowTime.AddHours(-(i - 1));

                        time.ToTimeForView = time.ToTime.Hour + ":00";

                        timeList.Add(time);
                    }
                    break;
                case PerTime.Daily:
                    for (int i = 30; i > 0; i--)
                    {
                        var time = new TimeRange();

                        time.FromTime = nowTime.AddDays(-i);
                        time.ToTime = nowTime.AddDays(-(i-1));

                        time.ToTimeForView = time.ToTime.Day.ToString();
                        
                        timeList.Add(time);
                    } 
                    break;
                case PerTime.Weekly:
                    for (int i = 26; i > 0; i--)
                    {
                        var time = new TimeRange();

                        time.FromTime = nowTime.AddDays(-(i*7));
                        time.ToTime = nowTime.AddDays(-((i*7) - 7));

                        time.ToTimeForView = time.ToTime.DayOfYear.ToString();

                        timeList.Add(time);
                    }
                    break;
                case PerTime.Monthly:
                    for (int i = 12; i > 0; i--)
                    {
                        var time = new TimeRange();

                        time.FromTime = nowTime.AddMonths(-i);
                        time.ToTime = nowTime.AddMonths(-(i - 1));

                        time.ToTimeForView = time.ToTime.Month.ToString();

                        timeList.Add(time);
                    }
                    break;
            }

            return timeList;
        }
    }

}
