using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Account.ChangePassword
{
    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
