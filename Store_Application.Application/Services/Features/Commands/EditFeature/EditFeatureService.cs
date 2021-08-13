using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Features.Commands.EditFeature
{
    public class EditFeatureService : IEditFeatureService
    {
        private readonly IDataBaseContext _db;
        public EditFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id, string featureName)
        {

            var res = new ResultDto();

            var feature = _db.Features.Find(id);
            if (feature == null)
            {
                res.IsSuccess = false;
                res.Message = "شناسه ویژگی یافت نشد";
            }
            else
            {
                var isExist = _db.Features.Any(f=> f.Title.Equals(featureName));
                if (isExist)
                {
                    res.IsSuccess = false;
                    res.Message = "قبلا ویژگی با این نام ثبت شده است";
                }
                else
                {
                    feature.Title = featureName;
                    feature.UpdateTime = DateTime.Now;

                    _db.Features.Update(feature);
                    _db.SaveChanges();

                    res.IsSuccess = true;
                    res.Message = "ویژگی با موفقیت ویرایش شد";
                }
            }

            return res;
        }
    }
}
