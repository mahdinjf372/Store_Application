using EndPoint.WebSite.Areas.Admin.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.LoadUsers
{
    public class LoadUsersViewModel
    {
        public List<UserViewModel> Users { get; set; }
        public PagingViewModel Paging { get; set; }

    }
}
