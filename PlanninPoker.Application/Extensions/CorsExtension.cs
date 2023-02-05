using Microsoft.Extensions.DependencyInjection;

namespace PlanningPoker.Application.Extensions
{
    public static class CorsExtension
    {
        public static void AddCustomCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", b =>
                {
                    b.AllowAnyOrigin();
                    b.AllowAnyMethod();
                    b.AllowAnyHeader();
                });
            });
        }
    }
}
