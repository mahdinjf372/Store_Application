using Store_Application.Domain.Entities.User;

namespace Store_Application.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isRemoved { get; set; }
        public string RoleName { get; set; }
    }
}
