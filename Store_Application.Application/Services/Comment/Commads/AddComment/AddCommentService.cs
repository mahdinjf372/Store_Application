using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Comment.Commads.AddComment
{
    public class AddCommentService : IAddCommentService
    {
        private readonly IDataBaseContext _db;
        public AddCommentService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddCommentDto req)
        {
            try
            {
                var comment = new Domain.Entities.Comment.Comment()
                {
                    InsertTime = DateTime.Now,
                    IRecommended = req.IRecomended,
                    ProductId = req.ProductId,
                    Rate = req.Rate,
                    Text = req.Text,
                    Title = req.Title,
                    UserId = req.UserId
                };

                _db.Comments.Add(comment);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "افزودن نظز شما با شکست مواجه شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "افزودن نظز شما با شکست مواجه شد"
                };
            }
        }
    }
}
