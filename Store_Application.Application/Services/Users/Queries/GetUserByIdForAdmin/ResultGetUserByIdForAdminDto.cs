using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin
{
    public class ResultGetUserByIdForAdminDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? age { get; set; }
        public List<UserRolesDto> Roles { get; set; }
    }

    public class UserRolesDto
    {
        public int Id { get; set; }
    }

}
