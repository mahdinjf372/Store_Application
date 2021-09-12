﻿using Store_Application.Application.Services.Orders.Commands.FinalizeOrder;
using Store_Application.Application.Services.RequestPay.Commands.AddRequestPay;
using Store_Application.Application.Services.RequestPay.Queries.GetRequestPay;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IRequestPayFacad
    {
        IAddRequestPayService AddRequestPayService { get;  }
        IGetRequestPayService GetRequestPayService { get; }
    }
}
