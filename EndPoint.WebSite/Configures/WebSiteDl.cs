using EndPoint.WebSite.Utilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Configures
{
    public static class WebSiteDl
    {
        public static void ConfigureWebSiteServices(this IServiceCollection services)
        {
            services.AddScoped<CookiesManager, CookiesManager>();
            services.AddScoped<ClaimUtility, ClaimUtility>();
        }
    }
}
