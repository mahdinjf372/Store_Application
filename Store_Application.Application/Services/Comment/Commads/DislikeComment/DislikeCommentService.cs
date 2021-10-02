using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Comment;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Comment.Commads.DislikeComment
{
    public class DislikeCommentService : IDislikeCommentService
    {
        private readonly IDataBaseContext _db;
        public DislikeCommentService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultDislikeCommentDto> Execute(RequestDislikeCommentDto req)
        {
            var isDisliked = _db.Dislikes.Any(d => d.CommentId.Equals(req.CommentId) && d.UserId.Equals(req.UserId));
            var isLiked = _db.Likes.Any(l => l.CommentId.Equals(req.CommentId) && l.UserId.Equals(req.UserId));

            ResultDislikeCommentDto res = new ResultDislikeCommentDto();

            if (!isDisliked)
            {
                var dislike = new Dislike()
                {
                    UserId = req.UserId,
                    CommentId = req.CommentId,
                    InsertTime = DateTime.Now
                };

                _db.Dislikes.Add(dislike);
                _db.SaveChanges();

                res.DiffrenceDislikes = 1;

                if (isLiked)
                {
                    var like = _db.Likes.SingleOrDefault(d => d.CommentId.Equals(req.CommentId) && d.UserId.Equals(req.UserId));
                    like.isRemoved = true;
                    like.RemovedTime = DateTime.Now;
                    _db.Likes.Update(like);
                    _db.SaveChanges();
                    res.DiffrenceLikes = -1;
                }

                return new ResultDto<ResultDislikeCommentDto>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "کامنت مورد نظر شما با موفقیت دیس لایک شد"
                };
            }
            else
            {
                return new ResultDto<ResultDislikeCommentDto>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "شما قبلا این کامنت را دیس لایک کرده اید"
                };
            }
        }
    }
    public class ResultDislikeCommentDto
    {
        public int DiffrenceLikes { get; set; }
        public int DiffrenceDislikes { get; set; }
    }
}
