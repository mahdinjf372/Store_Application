using EndPoint.WebSite.Areas.Admin.Models.Common;
using System.Collections.Generic;

namespace EndPoint.WebSite.Areas.Admin.Models.Question.LoadQuestions
{
    public class LoadQuestionsViewModel
    {
        public List<QuestionViewModel> Questions { get; set; }

        public PagingViewModel Paging { get; set; }

    }
}
