using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Orders.Commands.FinalizeOrder;
using Store_Application.Application.Services.RequestPay.Commands.AddRequestPay;
using Store_Application.Application.Services.RequestPay.Queries.GetRequestPay;
using Store_Application.Application.Services.RequestPay.Queries.GetTotalPaysForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.RequestPay.FacadPattern
{
    public class RequestPayFacad : IRequestPayFacad
    {
        private readonly IDataBaseContext _db;
        public RequestPayFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddRequestPayService _addRequestPayService;
        public IAddRequestPayService AddRequestPayService
        {
            get
            {
                return _addRequestPayService = _addRequestPayService ?? new AddRequestPayService(_db);
            }
        }

        private IGetRequestPayService _getRequestPayService;
        public IGetRequestPayService GetRequestPayService
        {
            get
            {
                return _getRequestPayService = _getRequestPayService ?? new GetRequestPayService(_db);
            }
        }

        private IGetTotalPaysForAdminService _getTotalPaysForAdminService;
        public IGetTotalPaysForAdminService GetTotalPaysForAdminService
        {
            get
            {
                return _getTotalPaysForAdminService ??= new GetTotalPaysForAdminService(_db);
            }
        }




    }
}
