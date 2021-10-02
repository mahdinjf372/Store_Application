using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.Comment.Queries.IsExistComment
{
    public class IsExistCommentService : IisExistCommentService
    {
        private readonly IDataBaseContext _db;
        public IsExistCommentService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int commentId)
        {
            var isExist = _db.Comments.Any(c=> c.Id.Equals(commentId));

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
            };
        }
    }
}
