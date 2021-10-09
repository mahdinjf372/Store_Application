using System;

namespace EndPoint.WebSite.Areas.Admin.Models.Question.LoadQuestions
{
    public class QuestionViewModel
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
