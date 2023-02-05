using Microsoft.Extensions.DependencyInjection;
using PlanningPoker.Data.Repositories;
using PlanningPoker.Data.Repositories.Abstractions;

namespace PlanningPoker.Data.Extensions
{
    public static class RepositoryExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
        }
    }
}
