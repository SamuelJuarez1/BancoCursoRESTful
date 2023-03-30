using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApiVersioningExtensions(this IServiceCollection services)
        {
            services.AddApiVersioning(Config =>
            {
                Config.DefaultApiVersion = new ApiVersion(1, 0);
                Config.AssumeDefaultVersionWhenUnspecified = true;
                Config.ReportApiVersions = true;
            });
        }
    }
}
