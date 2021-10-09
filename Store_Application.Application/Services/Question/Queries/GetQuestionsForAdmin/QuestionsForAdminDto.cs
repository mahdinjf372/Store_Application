using System;

namespace Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin
{
    public class QuestionsForAdminDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int? ParentQuestionId { get; set; }
        public string parentQuestionText { get; set; }
        public string Text { get; set; }
        public bool Confirmed { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
