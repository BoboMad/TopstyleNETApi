using Microsoft.EntityFrameworkCore;
using Topstyle.Data.Repos.Contexts;

namespace TopStyleApi.Extensions
{
    public static class ContextExtensions
    {
        public static IServiceCollection AddContext(this IServiceCollection services)
        {

            var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();

            string connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<TopstyleContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
