using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Question.Queries.GetUserQuestions
{
    public class GetUserQuestionService : IGetUserQuestionService
    {
        private readonly IDataBaseContext _db;
        public GetUserQuestionService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetUserQuestionDto>> Execute(int userId)
        {
            var res = _db.Questions
                .Where(q => q.UserId == userId)
                .Include(q => q.Product)
                .Include(q=> q.ParentQuestion)
                .Select(q => new ResultGetUserQuestionDto()
                {
                    Id = q.Id,
                    ProductId = q.ProductId,
                    Text = q.Text,
                    ParentQuestionText = q.ParentQuestion.Text,
                    ConfirmedByAdmin = q.ConfirmedByAdmin,
                    AdminIsRead = q.AdminIsRead,
                    Product = new ProductDto()
                    {
                        Id = q.ProductId,
                        Title = q.Product.Title,
                        ImageName = q.Product.Images.Single(i => i.IsMainImage).Name
                    }
                }).ToList();

            return new ResultDto<List<ResultGetUserQuestionDto>>()
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}