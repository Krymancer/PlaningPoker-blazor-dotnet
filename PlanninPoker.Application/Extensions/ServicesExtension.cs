using Microsoft.Extensions.DependencyInjection;
using PlanningPoker.Application.Services;
using PlanningPoker.Application.Services.Abstractions;

namespace PlanningPoker.Application.Extensions
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomService, RoomService>();
        }
    }
}
