using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature
{
    public class EditProductFeatureService : IEditProductFeatureService
    {
        private readonly IDataBaseContext _db;
        public EditProductFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestEditProductFeatureDto req)
        {
            try
            {
                var isExist = _db.ProductFeatures.Any(pf => pf.Value.Equals(req.Value) && !pf.Id.Equals(req.PF_Id));
                if (isExist)
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "ویژگی محصول دیگری با همین مقدار موجود میباشد!"
                    };
                }

                var pf = _db.ProductFeatures.Find(req.PF_Id);
                pf.Value = req.Value;
                pf.UpdateTime = DateTime.Now;
                _db.ProductFeatures.Update(pf);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ویژگی محصول با موفقیت ویزایش شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ویرایش ویژگی محصول با شکست مواجه شد"
                };
            }
        }
    }
}
