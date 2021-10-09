using System;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Commads.ChangeStatusForAdmin
{
    public class ChangeStatusForAdminService : IChangeStatusForAdminService
    {
        private readonly IDataBaseContext _db;
        public ChangeStatusForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int commentId)
        {
            var comment = _db.Comments.Find(commentId);

            comment.AdminIsRead = true;
            comment.ConfirmedByAdmin = !comment.ConfirmedByAdmin;
            comment.UpdateTime = DateTime.Now;

            _db.Comments.Update(comment);
            _db.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"وضعیت کامنت {commentId} با موفقیت تغییر یافت"
            };
        }
    }
}