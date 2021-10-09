using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Commands.MergeCompare
{
    public class MergeCompareService : IMergeCompareService
    {
        private readonly IDataBaseContext _db;
        public MergeCompareService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int userId, Guid browserId)
        {
            var userCompares = _db.Compares.Where(f => f.UserId == userId).ToList();
            var browserCompares = _db.Compares.Where(f => f.UserId == null && f.BrowserId == browserId).ToList();

            if (browserCompares.Any())
            {
                foreach (var bc in browserCompares)
                {
                    var compare = userCompares.SingleOrDefault(f => f.ProductId.Equals(bc.ProductId));

                    if (compare == null)
                    {
                        bc.UserId = userId;
                    }
                    else
                    {
                        bc.isRemoved = true;
                        bc.RemovedTime = DateTime.Now;
                    }
                    _db.Compares.Update(bc);
                    _db.SaveChanges();
                }
            }

            return new ResultDto
            {
                IsSuccess = true,
            };
        }
    }
}