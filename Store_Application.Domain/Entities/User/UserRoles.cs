using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.User
{
    public class UserRoles : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
