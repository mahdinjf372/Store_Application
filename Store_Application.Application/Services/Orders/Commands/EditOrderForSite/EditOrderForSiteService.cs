using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Commands.EditOrderForSite
{
    public class EditOrderForSiteService : IEditOrderForSiteService
    {
        private readonly IDataBaseContext _db;
        public EditOrderForSiteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestEditOrerForSiteDto req)
        {
            try
            {
                var order = _db.Orders
                           .Where(o => !o.RequestPay.IsPay && o.UserId.Equals(req.UserId))
                           .SingleOrDefault();

                order.ReceiverName = req.ReceiverName;
                order.ReceiverPhone = req.ReceiverPhone;
                order.Address = req.Address;
                order.PostCode = req.PostCode;
                order.Description = req.Description;
                order.UpdateTime = DateTime.Now;
                order.OrderState = OrderState.WaitingForPay;


                _db.Orders.Update(order);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "فاکتور شما با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ثبت فاکتور شما با شکست مواجه شد"
                };
            }
        }
    }
}
