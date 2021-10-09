using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Comment.LoadComments
{
    public class RequestLoadCommentsViewModel
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;
        public string Searchkey { get; set; }

        public int? ProductId { get; set; } = null;
        public int? UserId { get; set; } = null;
        public int? CommentId { get; set; } = null;
        //public bool? Confirmed { get; set; } = null;
        public CommentStatus Status  { get; set; }
        public DateTime? FromDate  { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
