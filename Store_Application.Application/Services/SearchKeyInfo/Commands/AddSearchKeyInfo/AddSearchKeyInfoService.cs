using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.SearchKeyInfo.Commands.AddSearchKeyInfo
{
    public class AddSearchKeyInfoService : IAddSearchKeyInfoService
    {
        private readonly IDataBaseContext _db;
        public AddSearchKeyInfoService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(string searchKey)
        {
            _db.SearchKeysInfo.Add(new Domain.Entities.Statistic.SearchKeyInfo
            {
                InsertTime = DateTime.Now,
                SearchKey = searchKey
            });
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true
            };
        }
    }

}
