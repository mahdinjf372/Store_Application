using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.SiteRequest.Commands.AddRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestCounter
    {
        private readonly RequestDelegate _next;

        public RequestCounter(
            RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,
            ISiteRequestFacad siteRequestFacad,
            ClaimUtility claimUtility,
            CookiesManager cookiesManager)
        {

            ISiteRequestFacad _siteRequestFacad = siteRequestFacad;
            ClaimUtility _claimUtility = claimUtility;
            CookiesManager _cookiesManager = cookiesManager;

            int? userId = null;
            bool IsAuthenticated = _claimUtility.IsAuthenticated(httpContext.User);
            if (IsAuthenticated)
            {
                userId = _claimUtility.GetUserId(httpContext.User);
            }
            var browserId = _cookiesManager.GetBrowserId(httpContext);

            List<string> IgnorePaths = new List<string>()
            {
                "/Cart/LoadCart",
            };

            if (!IgnorePaths.Any(p => p == httpContext.Request.Path.ToString()))
            {
                _siteRequestFacad.AddRequestService.Execute(new RequestAddRequestDto
                {
                    Ip = httpContext.Connection.RemoteIpAddress.ToString(),
                    HasFormContentType = httpContext.Request.HasFormContentType,
                    HasJsonContentType = httpContext.Request.HasJsonContentType(),
                    IsHttps = httpContext.Request.IsHttps,
                    Methode = httpContext.Request.Method,
                    Path = httpContext.Request.Path.ToString(),
                    IsAuthenticated = IsAuthenticated,
                    UserId = userId,
                    BrowserId = browserId,
                });
            }
            await _next(httpContext);
        }
    }

    public static class RequestCounterExtensions
    {
        public static IApplicationBuilder UseRequestCounter(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCounter>();
        }
    }
}
