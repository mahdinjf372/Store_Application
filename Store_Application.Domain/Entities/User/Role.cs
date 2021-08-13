using Store_Application.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.User
{
    public class Role:BaseEntity<int>
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
