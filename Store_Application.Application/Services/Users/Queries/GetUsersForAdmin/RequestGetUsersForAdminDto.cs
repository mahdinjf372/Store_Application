namespace Store_Application.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class RequestGetUsersForAdminDto
    {
        public string Searchkey { get; set; }
        public int Page { get; set; }
        public int Take { get; set; }
    }
}
