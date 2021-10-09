using System;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Question.LoadQuestions
{
    public class RequestLoadQuestionsViewModel
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;
        public string Searchkey { get; set; }

        public int? ProductId { get; set; } = null;
        public int? UserId { get; set; } = null;
        public int? QuestionId { get; set; } = null;
        public QuestionStatus Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
