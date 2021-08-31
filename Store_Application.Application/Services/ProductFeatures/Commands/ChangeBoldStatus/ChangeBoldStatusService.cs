using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.ProductFeatures.Commands.ChangeBoldStatus
{
    public class ChangeBoldStatusService : IChangeBoldStatusService
    {
        private readonly IDataBaseContext _db;
        public ChangeBoldStatusService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int pfId)
        {
            try
            {
                var pf = _db.ProductFeatures.Find(pfId);
                pf.isBold = !pf.isBold;
                pf.UpdateTime = DateTime.Now;
                _db.ProductFeatures.Update(pf);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = pf.isBold ? "ویژگی با موفقیت برجسته شد" : "برجستگی ویژگی با موفقیت برداشته شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تغییر وضعیت برجستگی ویژگی با شکست مواجه شد"
                };
            }
            
        }
    }
}
