using System;

namespace Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin
{
    public class CommentsForAdminDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Recommend { get; set; }
        public byte Rate { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public bool Confirmed { get; set; }
        public DateTime InsertTime { get; set; }
    }
}