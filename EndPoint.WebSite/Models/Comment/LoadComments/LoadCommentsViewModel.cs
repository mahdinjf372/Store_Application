using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Comment.LoadComments
{
    public class LoadCommentsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IRecommended { get; set; }
        public DateTime InsertTime { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public byte Rate { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
