using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Authentication.PasswordRecovery
{
    public class RecoveryPasswordViewModel
    {
        public string ActivationCode { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
