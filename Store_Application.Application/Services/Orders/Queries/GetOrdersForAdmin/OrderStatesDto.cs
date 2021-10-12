namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public enum OrderStatesDto
    {
        NotFinally = 0,
        WaitingForPay = 1,
        Canceled = 2,
        Delivered = 3,
        Processing = 4,
        None = 5
    }

}


