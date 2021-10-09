using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Commads.RemoveComment
{
    public class RemoveCommentService : IRemoveCommentService
    {
        private readonly IDataBaseContext _db;
        public RemoveCommentService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int userId, int commentId)
        {
            var comment = _db.Comments.SingleOrDefault(c => c.UserId == userId && c.Id == commentId);

            var res = new ResultDto();
            res.IsSuccess = false;

            if (comment != null)
            {
                comment.isRemoved = true;
                comment.RemovedTime = DateTime.Now;
                _db.Comments.Update(comment);
                _db.SaveChanges();

                res.IsSuccess = true;
            }

            return res;
        }
    }
}