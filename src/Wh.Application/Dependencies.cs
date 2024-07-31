using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wh.Application.Db;
namespace Wh.Application
{
    public static class Dependencies
    {
        public static IServiceCollection ConfiguredDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlServer");

            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString, sqlServerOptions =>
                {
                    sqlServerOptions.UseNetTopologySuite();
                    sqlServerOptions.EnableRetryOnFailure();
                });
            });

            return services;
        }
    }
}
