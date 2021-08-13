namespace Store_Application.Application.Services.Users.Queries.LoginUser
{
    public class ResultLoginUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public bool isActive { get; set; }
    }
}
