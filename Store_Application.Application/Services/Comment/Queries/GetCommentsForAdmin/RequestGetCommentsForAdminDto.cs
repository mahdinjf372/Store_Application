using System;

namespace Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin
{
    public class RequestGetCommentsForAdminDto
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;

        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? CommentId { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}