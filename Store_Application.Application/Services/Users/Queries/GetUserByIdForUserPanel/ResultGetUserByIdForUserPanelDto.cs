using System;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForUserPanel
{
    public class ResultGetUserByIdForUserPanelDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? age { get; set; }
        public string RegisterDate { get; set; }
        public bool IsActive { get; set; }


    }

}
