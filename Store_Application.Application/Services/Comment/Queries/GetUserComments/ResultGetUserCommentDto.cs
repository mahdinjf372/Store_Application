namespace Store_Application.Application.Services.Comment.Queries.GetUserComments
{
    public class ResultGetUserCommentDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public bool Recommend { get; set; }
        public bool ConfirmedByAdmin { get; set; }
        public bool AdminIsRead { get; set; }

        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}