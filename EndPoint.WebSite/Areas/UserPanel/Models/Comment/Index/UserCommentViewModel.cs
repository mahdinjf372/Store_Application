using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Comment.Index
{
    public class UserCommentViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public bool Recommend { get; set; }
        public bool AdminIsRead { get; set; }
        public bool ConfirmedByAdmin { get; set; }

        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
    }
}
