namespace Store_Application.Application.Services.Question.Queries.GetUserQuestions
{
    public class ResultGetUserQuestionDto
    {
        public int Id { get; set; }

        public string ParentQuestionText { get; set; }
        public string Text { get; set; }
        public bool ConfirmedByAdmin { get; set; }
        public bool AdminIsRead { get; set; }

        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}