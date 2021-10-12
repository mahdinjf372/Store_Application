using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.SearchKeyInfo.FacadPattern;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Middlewares
{
    public class SearchKeysCounter
    {
        private readonly RequestDelegate _next;

        public SearchKeysCounter(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ISearchKeyInfoFacad searchKeyInfoFacad)
        {
            ISearchKeyInfoFacad _searchKeyInfoFacad = searchKeyInfoFacad;
            var x = httpContext.Request.Path.ToString().ToLower().Contains("/search");
            if (x)
            {
                var key = httpContext.Request.Query["searchTitle"];
                _searchKeyInfoFacad.AddSearchKeyInfoService.Execute(key);
            }

            await _next(httpContext);
        }
    }

    public static class SearchKeysCounterExtensions
    {
        public static IApplicationBuilder UseSearchKeysCounter(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SearchKeysCounter>();
        }
    }
}
