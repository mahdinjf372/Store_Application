using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Comment
{
    public class Like : BaseEntity<int>
    {
        public int UserId { get; set; }
        public User.User User { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
