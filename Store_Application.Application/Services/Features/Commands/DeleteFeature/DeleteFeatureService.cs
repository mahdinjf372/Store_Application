using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Features.Commands.DeleteFeature
{
    public class DeleteFeatureService : IDeleteFeatureService
    {
        private readonly IDataBaseContext _db;
        public DeleteFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id)
        {
            var feature = _db.Features.Find(id);

            feature.isRemoved = true;
            feature.RemovedTime = DateTime.Now;

            _db.Features.Update(feature);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "ویژگی با موفقیت حذف شد"
            };
        }
    }
}
