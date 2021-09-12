using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Commands.MergeUserCartAndBrowserCart
{
    public class MergeUserCartAndBrowserCartService : IMergeUserCartAndBrowserCartService
    {
        private readonly IDataBaseContext _db;
        public MergeUserCartAndBrowserCartService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int userId, Guid browserId)
        {
            if (_db.Users.Any(u => u.Id == userId))
            {
                var userCart = _db.Carts.Include(c => c.CartItems).Where(c => c.UserId == userId && !c.Finished).SingleOrDefault();
                //var uc = _db.Carts.Where(c => c.UserId == userId && !c.Finished).SingleOrDefault();
                //if (uc.CartItems.Any())
                //{
                //    userQuery = userQuery.Include(c => c.CartItems).AsQueryable();
                //}

                //var userCart = userQuery.SingleOrDefault();

                var browserCart = _db.Carts.Include(c => c.CartItems).Where(c => c.BrowserId == browserId && !c.Finished).SingleOrDefault();
                //var bc = _db.Carts.Where(c => c.UserId == userId && !c.Finished).SingleOrDefault();
                //if (bc.CartItems.Any())
                //{
                //    browserQuery = browserQuery.Include(c => c.CartItems).AsQueryable();
                //}

                //var browserCart = browserQuery.SingleOrDefault();


                if (userCart == null)
                {
                    userCart = new Cart
                    {
                        Finished = false,
                        InsertTime = DateTime.Now,
                        UserId = userId
                    };

                    _db.Carts.Add(userCart);
                    _db.SaveChanges();
                }

                if (browserCart != null && browserCart.CartItems.Any())
                {
                    foreach (var item in browserCart.CartItems)
                    {
                        var isExist = userCart.CartItems.Any(i => i.ProductId.Equals(item.ProductId));
                        if (!isExist)
                        {
                            item.CartId = userCart.Id;
                        }
                        else
                        {
                            item.isRemoved = true;
                            item.RemovedTime = DateTime.Now;
                        }
                        _db.CartItems.Update(item);
                        _db.SaveChanges();
                    }
                }
            }
            return new ResultDto
            {
                IsSuccess = true,
            };
        }

    }
}
