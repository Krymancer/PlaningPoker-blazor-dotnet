using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PlanningPoker.Data.Extensions
{
    public static class DatabaseExtension
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AppContext>();
        }
    }
}
