using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.SiteRequest.Commands.AddRequest;
using Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.SiteRequest.FacadPattern
{
    public class SiteRequestFacad : ISiteRequestFacad
    {
        private readonly IDataBaseContext _db;
        public SiteRequestFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddRequestService _addRequestService;
        public IAddRequestService AddRequestService
        {
            get
            {
                return _addRequestService ??= new AddRequestService(_db);
            }
        }

        private IGetSiteRequestsPerTimeService _getSiteRequestsPerTimeService;
        public IGetSiteRequestsPerTimeService GetSiteRequestsPerTimeService
        {
            get
            {
                return _getSiteRequestsPerTimeService ??= new GetSiteRequestsPerTimeService(_db);
            }
        }
        
    }
}
