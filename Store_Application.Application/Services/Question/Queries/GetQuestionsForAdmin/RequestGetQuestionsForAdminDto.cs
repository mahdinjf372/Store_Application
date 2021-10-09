using System;

namespace Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin
{
    public class RequestGetQuestionsForAdminDto
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;

        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? QuestionId { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
