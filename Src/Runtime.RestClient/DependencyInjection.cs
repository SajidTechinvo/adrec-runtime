using ADREC.RestClient.Interfaces.Factory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Implementations.Unit;
using Runtime.RestClient.Interfaces;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.RestClient
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRestClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DmtSettings>(configuration.GetSection(DmtSettings.SectionName));
            services.Configure<AmazonClientOptions>(configuration.GetSection(AmazonClientOptions.SectionName));

            services.AddHttpClient();

            services.AddScoped<IRestClientUnit, RestClientUnit>();
            services.AddTransient<ICustomHttpFactory, CustomHttpFactory>();

            var currentEnv = $"{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}";
            if (currentEnv == "Production")
            {
                services.AddScoped<IAmazonClient, AmazonClient>();
            }
            else
            {
                services.AddScoped<IAmazonClient, MockAmazonClient>();
            }


            return services;
        }
    }
}