using System.Collections.Generic;

namespace Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin
{
    public class ResultGetQuestionsForAdminDto
    {
        public List<QuestionsForAdminDto> Questions { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
