using System.Linq;
using Contracts;
using Entities;
using LoggerService;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

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
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection"), 
                    opt => opt.MigrationsAssembly("Common")));

        public static void ConfigureRepositoryManager(this IServiceCollection service) =>
            service.AddScoped<IRepositoryManager, RepositoryManager>();
        
        public static IMvcBuilder AddCustomCsvFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config => config.OutputFormatters.Add(new
                CsvOutputFormatter()));
        
        public static void AddCustomMediaTypes(this IServiceCollection services)
        {
            services.Configure<MvcOptions>(config =>
            {
                var newtonsoftJsonOutputFormatter = config.OutputFormatters
                    .OfType<NewtonsoftJsonOutputFormatter>()
                    .FirstOrDefault();

                newtonsoftJsonOutputFormatter?.SupportedMediaTypes.Add("application/vnd.codemaze.hateoas+json");
                newtonsoftJsonOutputFormatter?.SupportedMediaTypes.Add("application/vnd.codemaze.apiroot+json");

                var xmlOutputFormatter = config.OutputFormatters
                    .OfType<XmlDataContractSerializerOutputFormatter>()
                    .FirstOrDefault();

                xmlOutputFormatter?.SupportedMediaTypes.Add("application/vnd.codemaze.hateoas+xml");
                xmlOutputFormatter?.SupportedMediaTypes.Add("application/vnd.codemaze.apiroot+xml");
            });
        }

        public static void ConfigureVersioning(this IServiceCollection service)
        {
            service.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
            });
        }

        public static void ConfigureResponseCaching(this IServiceCollection service) => service.AddResponseCaching();
        
        public static void ConfigureHttpCacheHeaders(this IServiceCollection service) => service.AddHttpCacheHeaders(
            (expirationOpt) =>
            {
                expirationOpt.MaxAge = 65;
                expirationOpt.CacheLocation = CacheLocation.Private;
            },
            (validationOpt) =>
            {
                validationOpt.MustRevalidate = true;
            }
            );
    }
}