using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Queries.GetUsers
{
    public class ResultGetUsersDto
    {
        public IEnumerable<GetUsersDto> users { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }

    }
}
