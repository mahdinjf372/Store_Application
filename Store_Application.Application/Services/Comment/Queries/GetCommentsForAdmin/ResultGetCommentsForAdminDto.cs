using System.Collections.Generic;

namespace Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin
{
    public class ResultGetCommentsForAdminDto
    {
        public List<CommentsForAdminDto> Comments { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}