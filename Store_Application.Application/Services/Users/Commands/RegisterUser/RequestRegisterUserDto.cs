﻿namespace Store_Application.Application.Services.Users.Commands.RegisterUser
{
    public class RequestRegisterUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
