using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.SiteRequest.Commands.AddRequest
{
    public class AddRequestService : IAddRequestService
    {
        private readonly IDataBaseContext _db;
        public AddRequestService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddRequestDto req)
        {
            _db.SiteRequests.Add(new Domain.Entities.Statistic.SiteRequest()
            {
                Ip = req.Ip,
                BrowserId = req.BrowserId,
                UserId = req.UserId,
                IsAuthenticated = req.IsAuthenticated,
                HasFormContentType = req.HasFormContentType,
                HasJsonContentType = req.HasJsonContentType,
                IsHttps = req.IsHttps,
                Methode = req.Methode,
                Path = req.Path,
                InsertTime = DateTime.Now,
            });
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true
            };
        }
    }
}
