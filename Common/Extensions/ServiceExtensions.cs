using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
        
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection")));

    }
}