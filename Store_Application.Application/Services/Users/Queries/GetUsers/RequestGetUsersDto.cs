namespace Store_Application.Application.Services.Users.Queries.GetUsers
{
    public class RequestGetUsersDto
    {
        public string Searchkey { get; set; }
        public int Page { get; set; }
        public int Take { get; set; }
    }
}
