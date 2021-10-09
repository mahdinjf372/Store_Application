using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.Admin.Models.Common;

namespace EndPoint.WebSite.Areas.Admin.Models.Comment.LoadComments
{
    public class LoadCommentsViewModel
    {
        public List<CommentViewModel> Comments { get; set; }

        public PagingViewModel Paging { get; set; }

    }

    public class CommentViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Recommend { get; set; }
        public byte Rate { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public bool Confirmed { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
