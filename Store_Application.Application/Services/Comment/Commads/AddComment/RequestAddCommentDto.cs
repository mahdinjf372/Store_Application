namespace Store_Application.Application.Services.Comment.Commads.AddComment
{
    public class RequestAddCommentDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public bool IRecomended { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
