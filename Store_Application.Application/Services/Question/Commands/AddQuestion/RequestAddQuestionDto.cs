namespace Store_Application.Application.Services.Question.Commands.AddQuestion
{
    public class RequestAddQuestionDto
    {
        public string Text { get; set; }
        public int? ParentQuestionId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
