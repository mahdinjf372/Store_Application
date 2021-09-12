using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Components
{
    public class ProfileBoxViewModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}
