using System.Collections.Generic;

namespace Store_Application.Application.Services.Users.Queries.GetUsersForAdmin
{
    public class ResultGetUsersForAdminDto
    {
        public IEnumerable<GetUsersForAdminDto> users { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }

    }
}
