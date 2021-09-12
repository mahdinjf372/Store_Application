namespace Store_Application.Application.Services.Orders.Commands.EditOrderForSite
{
    public class RequestEditOrerForSiteDto 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
