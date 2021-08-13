using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.LoadUsers
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isRemoved { get; set; }
        public string RoleName { get; set; }
    }
}
