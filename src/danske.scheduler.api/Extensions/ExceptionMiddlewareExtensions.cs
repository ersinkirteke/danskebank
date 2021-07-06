using danske.scheduler.producer.api.middlewares;
using Microsoft.AspNetCore.Builder;

namespace danske.scheduler.producer.api.extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
