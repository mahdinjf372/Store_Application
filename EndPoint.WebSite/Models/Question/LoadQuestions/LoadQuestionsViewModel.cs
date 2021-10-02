using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Question.LoadQuestions
{
    public class LoadQuestionsViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentQuestionId { get; set; }
        public DateTime InsertTime { get; set; }

        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
