using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Question.Add
{
    public class AddQuestionViewModel
    {
        public int ProductId { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }
    }
}
