namespace Store_Application.Application.Services.Users.Commands.EditUserForUserPanel
{
    public class RequestEditUserForUserPanelDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? age { get; set; }
    }
}
