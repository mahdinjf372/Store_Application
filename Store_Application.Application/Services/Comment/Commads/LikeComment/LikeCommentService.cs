using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Comment;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Comment.Commads.LikeComment
{
    public class LikeCommentService : ILikeCommentService
    {
        private readonly IDataBaseContext _db;
        public LikeCommentService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultLikeCommentDto> Execute(RequestLikeCommentDto req)
        {
            var isLiked = _db.Likes.Any(l => l.CommentId.Equals(req.CommentId) && l.UserId.Equals(req.UserId));
            var isDisliked = _db.Dislikes.Any(d => d.CommentId.Equals(req.CommentId) && d.UserId.Equals(req.UserId));

            if (!isLiked)
            {
                ResultLikeCommentDto res = new ResultLikeCommentDto();

                Like like = new Like()
                {
                    UserId = req.UserId,
                    CommentId = req.CommentId,
                    InsertTime = DateTime.Now
                };

                _db.Likes.Add(like);
                _db.SaveChanges();

                res.DiffrenceLikes = 1;

                if (isDisliked)
                {
                    var dislike = _db.Dislikes.SingleOrDefault(d => d.CommentId.Equals(req.CommentId) && d.UserId.Equals(req.UserId));
                    dislike.isRemoved = true;
                    dislike.RemovedTime = DateTime.Now;
                    _db.Dislikes.Update(dislike);
                    _db.SaveChanges();

                    res.DiffrenceDislikes = -1;
                }

                return new ResultDto<ResultLikeCommentDto>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "کامنت مورد نظر شما با موفقیت لایک شد"
                };
            }
            else
            {
                return new ResultDto<ResultLikeCommentDto>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "شما قبلا این کامنت را لایک کرده اید"
                };
            }
        }
    }

    public class ResultLikeCommentDto
    {
        public int DiffrenceLikes { get; set; }
        public int DiffrenceDislikes { get; set; }
    }
}
