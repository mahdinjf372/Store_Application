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

        public void BinSearchValuesToFields()
        {

            string[] filters = new string[6];
            filters = Searchkey?.Split(',');

            if (filters != null && !string.IsNullOrEmpty(filters[0]))
                QuestionId = int.Parse(filters[0]);

            if (filters != null && !string.IsNullOrEmpty(filters[1]))
                ProductId = int.Parse(filters[1]);

            if (filters != null && !string.IsNullOrEmpty(filters[2]))
                UserId = int.Parse(filters[2]);

            if (filters != null && !string.IsNullOrEmpty(filters[4]))
                FromDate = DateTime.Parse(filters[4]);

            if (filters != null && !string.IsNullOrEmpty(filters[5]))
                ToDate = DateTime.Parse(filters[5]);

            switch (filters?[3])
            {
                case "0":
                    Status = QuestionStatus.None;
                    break;
                case "1":
                    Status = QuestionStatus.Confirmed;
                    break;
                case "2":
                    Status = QuestionStatus.Unconfirmed;
                    break;
            }
        }
    }
}
