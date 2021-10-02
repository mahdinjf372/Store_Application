using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Commands.EditUserForAdmin
{
    public class RequestEditUserForAdminDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? age { get; set; }
        public List<EditRoleDto> Roles { get; set; }

    }

    public class EditRoleDto
    {
        public int Id { get; set; }
    }
}
