using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Queries.GetUserByEmail
{
    public class ResultGetUserbyEmailDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? age { get; set; }
        public List<GetEmailRoleDto> Roles { get; set; }

    }

    public class GetEmailRoleDto
    {
        public int Id { get; set; }
    }
}
