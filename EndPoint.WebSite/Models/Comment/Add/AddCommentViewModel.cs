using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Comment.Add
{
    public class AddCommentViewModel
    {
        public int ProductId { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public byte Rate { get; set; }
        public string IRecommend { get; set; }
    }
}
