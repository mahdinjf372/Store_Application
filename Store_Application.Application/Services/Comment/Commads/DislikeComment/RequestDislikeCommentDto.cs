namespace Store_Application.Application.Services.Comment.Commads.DislikeComment
{
    public class RequestDislikeCommentDto
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}
