using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;
using Runtime.API.Caching;
using Runtime.Common;
using Runtime.Common.Helpers;
using Runtime.Common.Settings;
using Runtime.RestClient;
using StackExchange.Redis;

namespace Runtime.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddCors(builder =>
            {
                builder.AddDefaultPolicy(options =>
                {
                    options.AllowAnyHeader();
                    options.WithOrigins(AppSettingHelper.GetOrigins());
                    options.AllowAnyMethod();
                    options.AllowCredentials();
                });
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Adrec", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = "Bearer",
                    Type = SecuritySchemeType.Http
                });

                // XML Doc
                //string xmlDocFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //string xmlDocFilePath = Path.Combine(AppContext.BaseDirectory, xmlDocFileName);
                //c.IncludeXmlComments(xmlDocFilePath);
            });

            services.AddRestClientServices(configuration);
            services.AddCommon(configuration);

            services.Configure<UaePassSettings>(configuration.GetSection(UaePassSettings.SectionName));

            services.AddResponseCompression(option =>
            {
                option.Providers.Add<GzipCompressionProvider>();
            });

            if (AppSettingHelper.UseRedis())
            {
                services.AddScoped<IRedisCacheService, RedisCacheService>();
            }
            else
            {
                services.AddMemoryCache();
                services.AddScoped<IRedisCacheService, InMemoryCacheService>();
            }
            services.AddSingleton<IConnectionMultiplexer>(sp =>
                {
                    var configuration = AppSettingHelper.GetRedisConnection();
                    return ConnectionMultiplexer.Connect(configuration);
                });

            return services;
        }
    }
}