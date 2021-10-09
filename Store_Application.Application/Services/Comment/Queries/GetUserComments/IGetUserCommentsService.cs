using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Queries.GetUserComments
{
    public interface IGetUserCommentsService
    {
        ResultDto<List<ResultGetUserCommentDto>> Execute(int userId);
    }
}
