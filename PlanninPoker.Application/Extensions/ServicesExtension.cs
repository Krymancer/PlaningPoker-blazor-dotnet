using Microsoft.Extensions.DependencyInjection;
using PlanningPoker.Application.Services.Abstractions;

namespace PlanningPoker.Application.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomService, IRoomService>();
            return services;
        }
    }
}
