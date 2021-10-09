using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Queries.GetUserComments
{
    public class GetUserCommentsService : IGetUserCommentsService
    {
        private readonly IDataBaseContext _db;
        public GetUserCommentsService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetUserCommentDto>> Execute(int userId)
        {
            var res = _db.Comments
                .Where(c => c.UserId == userId)
                .Include(c => c.Product)
                .Select(c => new ResultGetUserCommentDto()
                {
                    Id = c.Id,
                    ProductId = c.ProductId,
                    Title = c.Title,
                    Text = c.Text,
                    Recommend = c.IRecommended,
                    Rate = c.Rate,
                    ConfirmedByAdmin = c.ConfirmedByAdmin,
                    AdminIsRead = c.AdminIsRead,
                    Product = new ProductDto()
                    {
                        Id = c.ProductId,
                        Title = c.Product.Title,
                        ImageName = c.Product.Images.Single(i => i.IsMainImage).Name
                    }
                }).ToList();


            return new ResultDto<List<ResultGetUserCommentDto>>()
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}