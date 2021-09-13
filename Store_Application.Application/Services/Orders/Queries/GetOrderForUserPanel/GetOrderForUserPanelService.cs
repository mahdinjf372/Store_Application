using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel
{
    public class GetOrderForUserPanelService : IGetOrderForUserPanelService
    {
        private readonly IDataBaseContext _db;
        public GetOrderForUserPanelService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetOrderForUserPanelDto> Execute(int orderId)
        {
            try
            {
                var order = _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .Include(o => o.RequestPay)
                .Select(o => new ResultGetOrderForUserPanelDto
                {
                    Id = o.Id,
                    Address = o.Address,
                    PostCode = o.PostCode,
                    ReceiverName = o.ReceiverName,
                    ReceiverPhone = o.ReceiverPhone,
                    totalAmount = o.OrderDetails.Sum(od => od.Count * od.Price),
                    OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
                    {
                        Id = od.Id,
                        Title = od.Product.Title,
                        Count = od.Count,
                        DiscountAmount = o.RequestPay.IsPay ? 0 : od.Product.DiscountAmount,
                        Price = o.RequestPay.IsPay ? od.Price : od.Product.Price,
                        PriceWithDiscount = o.RequestPay.IsPay ? od.Product.Price : od.Product.Price - od.Product.DiscountAmount,
                    }).ToList()
                }).SingleOrDefault(o=> o.Id.Equals(orderId));

                return new ResultDto<ResultGetOrderForUserPanelDto>
                {
                    Data = order,
                    IsSuccess = true,
                    Message = "فاکتور با موفقیت واکشی شد"
                };
            }
            catch (Exception)
            {

                return new ResultDto<ResultGetOrderForUserPanelDto>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "فاکتور مورد نظر یافت نشد"
                };
            }

        }
    }
}
