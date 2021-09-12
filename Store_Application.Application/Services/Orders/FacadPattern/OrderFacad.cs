using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Orders.Commands.EditOrderForSite;
using Store_Application.Application.Services.Orders.Commands.FinalizeOrder;
using Store_Application.Application.Services.Orders.Queries.GetOrderForPay;
using Store_Application.Application.Services.Orders.Queries.GetOrderForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Orders.FacadPattern
{
    public class OrderFacad : IOrderFacad
    {
        private readonly IDataBaseContext _db;
        public OrderFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetOrderForSiteService _getOrderForSiteService;
        public IGetOrderForSiteService GetOrderForSiteService
        {
            get
            {
                return _getOrderForSiteService = _getOrderForSiteService ?? new GetOrderForSiteService(_db);
            }
        }
        

        private IEditOrderForSiteService _editOrderForSiteService;
        public IEditOrderForSiteService EditOrderForSiteService
        {
            get
            {
                return _editOrderForSiteService = _editOrderForSiteService ?? new EditOrderForSiteService(_db);
            }
        }
        
        private IGetOrderForPayService _getOrderForPayService;
        public IGetOrderForPayService GetOrderForPayService
        {
            get
            {
                return _getOrderForPayService = _getOrderForPayService ?? new GetOrderForPayService(_db);
            }
        }

        private IFinalizeOrderService _finalizeOrderService;
        public IFinalizeOrderService FinalizeOrderService
        {
            get
            {
                return _finalizeOrderService = _finalizeOrderService ?? new FinalizeOrderService(_db);
            }
        }

    }
}
