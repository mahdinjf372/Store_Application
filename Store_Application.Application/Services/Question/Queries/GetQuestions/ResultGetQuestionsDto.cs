using System;

namespace Store_Application.Application.Services.Question.Queries.GetQuestions
{
    public class ResultGetQuestionsDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentQuestionId { get; set; }
        public DateTime InsertTime { get; set; }

        public UserDto User { get; set; }

    }
}
