using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HandleStatusCodes
    {
        private readonly RequestDelegate _next;

        public HandleStatusCodes(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);

            if (httpContext.Response.StatusCode == 404 && !httpContext.Response.HasStarted)
            {
                httpContext.Response.Redirect("/NotFound");
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HandleStatusCodesExtensions
    {
        public static IApplicationBuilder UseHandleStatusCodes(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandleStatusCodes>();
        }
    }
}
