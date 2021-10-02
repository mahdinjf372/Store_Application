using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Queries.LoginUser
{
    public class ResultLoginUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool isActive { get; set; }

        public List<RoleViewModel> Roles { get; set; }
    }

    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
