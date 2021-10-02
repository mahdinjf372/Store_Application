using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Comment.Queries.GetComments
{
    public class GetCommentsService : IGetCommentsService
    {
        private readonly IDataBaseContext _db;
        public GetCommentsService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetCommentsDto>> Execute(int productId, int page, int take)
        {
            List<ResultGetCommentsDto> comments = _db.Comments
                    .Where(c => c.AdminIsRead && c.ConfirmedByAdmin && c.ProductId.Equals(productId))
                    .Include(c => c.User)
                    .Include(c=> c.Likes)
                    .Select(c => new ResultGetCommentsDto
                    {
                        Id = c.Id,
                        InsertTime = c.InsertTime,
                        Title = c.Title,
                        Text = c.Text,
                        Rate = c.Rate,
                        IRecommended = c.IRecommended,
                        LikesCount = c.Likes.Count(),
                        DislikesCount = c.Dislikes.Count(),
                        User = new UserDto
                        {
                            Id = c.UserId,
                            Username = c.User.Username, 
                            Email = c.User.Email
                        }
                    }).OrderBy(q => q.InsertTime).Skip((page - 1) * take).Take(take).ToList();

            foreach (var comment in comments)
            {
                if (string.IsNullOrEmpty(comment.User.Username))
                {
                    comment.User.Username = comment.User.Email.Split("@")[0];
                }
            }

            return new ResultDto<List<ResultGetCommentsDto>>
            {
                Data = comments,
                IsSuccess = true
            };
        }
    }
}
