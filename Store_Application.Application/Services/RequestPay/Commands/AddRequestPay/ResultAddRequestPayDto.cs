using System;

namespace Store_Application.Application.Services.RequestPay.Commands.AddRequestPay
{
    public class ResultAddRequestPayDto
    {
        public Guid guid { get; set; }
        public decimal Amount { get; set; }
        public string Email { get; set; }
        public long RequestPayId { get; set; }
    }
}
