using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.ProductFeatures.Commands.DeleteProductFeature
{
    public class DeleteProductFeatureService : IDeleteProductFeatureService
    {

        private readonly IDataBaseContext _db;
        public DeleteProductFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int pf_Id)
        {
            try
            {
                var pf = _db.ProductFeatures.Find(pf_Id);
                pf.isRemoved = true;
                pf.RemovedTime = DateTime.Now;
                _db.ProductFeatures.Update(pf);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ویژگی موردنظر با موفقیت حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف ویژگی با شکست مواجه شد"
                };
            }
            
        }
    }
}
