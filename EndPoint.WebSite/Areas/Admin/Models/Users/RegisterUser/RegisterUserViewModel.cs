using System.Collections.Generic;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser
{
    public class RegisterUserViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public List<int> Roles { get; set; }
    }

}
