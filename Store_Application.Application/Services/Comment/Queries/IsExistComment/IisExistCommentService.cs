using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.Queries.IsExistComment
{
    public interface IisExistCommentService
    {
        ResultDto<bool> Execute(int commentId);
    }
}
