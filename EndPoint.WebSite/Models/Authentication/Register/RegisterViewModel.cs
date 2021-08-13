using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Authentication.Register
{
    public class RegisterViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public bool AgreeToTermsAndConditions { get; set; } = false;
    }
}
