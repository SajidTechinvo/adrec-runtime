using ADREC.RestClient.Implementations.Factory;
using ADREC.RestClient.Interfaces.Factory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Unit;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.RestClient
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRestClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DmtSettings>(configuration.GetSection(DmtSettings.SectionName));

            services.AddHttpClient();

            services.AddScoped<IRestClientUnit, RestClientUnit>();
            services.AddTransient<ICustomHttpFactory, CustomHttpFactory>();

            return services;
        }
    }
}