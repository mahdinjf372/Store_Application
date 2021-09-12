using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForSite
{
    public class GetOrderForSiteService : IGetOrderForSiteService
    {
        private readonly IDataBaseContext _db;
        public GetOrderForSiteService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetOrderDto> Execute(int userId)
        {
            try
            {
                var res = new ResultDto<ResultGetOrderDto>();
                var cart = _db.Carts
                        .Include(c => c.CartItems)
                        .SingleOrDefault(c => c.UserId.Equals(userId) && !c.Finished);
                if (cart == null || cart.CartItems == null)
                {
                    res.Data = null;
                    res.IsSuccess = false;
                    res.Message = "سبد خرید شما خالی میباشد";
                }
                else
                {
                    var isExist = _db.Orders.Any(o => o.UserId.Equals(userId) && !o.RequestPay.IsPay);
                    ResultGetOrderDto order = new ResultGetOrderDto();
                    if (!isExist)
                    {
                        order = CreateNewOrder(userId);
                    }

                    UpdateOrderDetails(userId);

                    order = GetOrder(userId);

                    res.Data = order;
                    res.IsSuccess = true;
                }

                return res;
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetOrderDto>
                {
                    Data = null,
                    IsSuccess = false,
                };
            }
        }

        private ResultGetOrderDto CreateNewOrder(int userId)
        {
            var order = new Order()
            {
                InsertTime = DateTime.Now,
                OrderState = Domain.Enums.OrderState.WaitingForPay,
                UserId = userId,
                RequestPay = new Domain.Entities.Finance.RequestPay
                {
                    InsertTime = DateTime.Now,
                    UserId = userId,
                    IsPay = false
                },
            };
            _db.Orders.Add(order);
            _db.SaveChanges();

            return new ResultGetOrderDto
            {
                Id = order.Id,
                OrderDetails = null
            };
        }

        private void UpdateOrderDetails(int userId)
        {
            var cart = _db.Carts
                .Include(c => c.CartItems)
                .SingleOrDefault(c => c.UserId.Equals(userId) && !c.Finished);

            var order = _db.Orders.Include(o=> o.OrderDetails).Single(o => o.UserId.Equals(userId) && !o.RequestPay.IsPay);

            foreach (var od in order.OrderDetails)
            {
                var cartItem = cart.CartItems.Where(i => i.ProductId.Equals(od.ProductId)).SingleOrDefault();
                
                if (cartItem == null)
                {
                    od.isRemoved = true;
                    od.RemovedTime = DateTime.Now;
                }
                else if(cartItem.Count != od.Count)
                {
                    od.Count = cartItem.Count;
                }
                
                _db.OrderDetails.Update(od);
                _db.SaveChanges();
            }

            List<OrderDetail> ods = new List<OrderDetail>();
            foreach (var item in cart.CartItems)
            {
                var isExist = order.OrderDetails.Any(od => od.ProductId == item.ProductId);
                if (!isExist)
                {
                    var od = new OrderDetail
                    {
                        Count = item.Count,
                        InsertTime = DateTime.Now,
                        OrderId = order.Id,
                        ProductId = item.ProductId ?? 0
                    };
                    ods.Add(od);
                }
            }

            _db.OrderDetails.AddRange(ods);
            _db.SaveChanges();
        }

        private ResultGetOrderDto GetOrder(int userId)
        {
            var order = _db.Orders
                           .Include(o => o.RequestPay)
                           .Include(o => o.User)
                           .Include(o => o.OrderDetails)
                           .ThenInclude(od => od.Product)
                           .Where(o => !o.RequestPay.IsPay && o.UserId.Equals(userId))
                           .Select(o => new ResultGetOrderDto
                           {
                               Id = o.Id,
                               Address = o.User.Address,
                               Description = o.Description,
                               PostCode = o.PostCode,
                               ReceiverName = o.User.FullName,
                               ReceiverPhone = o.User.Phone,
                               OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
                               {
                                   Id = od.Id,
                                   Count = od.Count,
                                   DiscountAmount = od.Product.DiscountAmount,
                                   Title = od.Product.Title,
                                   Price = od.Product.Price,
                                   SumPrice = (od.Product.Price - od.Product.DiscountAmount) * od.Count,
                                   ProductId = od.ProductId,
                                   PriceWithDiscount = od.Product.Price - od.Product.DiscountAmount,
                               }).ToList(),
                           })
                           .SingleOrDefault();

            order.TotalAmount = order.OrderDetails.Sum(od => od.SumPrice);

            return order;
        }
    }
}
