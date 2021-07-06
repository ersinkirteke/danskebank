using Microsoft.Extensions.DependencyInjection;

namespace danske.scheduler.producer.api.extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

                // I can specify the domains like that for cors
                /*options.AddPolicy(name: MyAllowSpecificOrigins,
                              builder =>
                              {
                                  builder.WithOrigins("http://example.com",
                                                      "http://www.contoso.com");
                              });*/
            });
        }
    }
}
