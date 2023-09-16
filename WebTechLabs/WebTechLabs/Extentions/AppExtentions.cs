using WebTechLabs.Middleware;
using Microsoft.AspNetCore.Builder;

namespace WebTechLabs.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
