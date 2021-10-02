using Store_Application.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Comment
{
    public class Comment : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public bool IRecommended { get; set; }

        public bool AdminIsRead { get; set; }
        public bool ConfirmedByAdmin { get; set; }

        public int ProductId { get; set; }
        public Product.Product Product { get; set; }

        public int UserId { get; set; }
        public User.User User { get; set; }

        public ICollection<Like> Likes { get; set; }
        public ICollection<Dislike> Dislikes { get; set; }
    }
}
