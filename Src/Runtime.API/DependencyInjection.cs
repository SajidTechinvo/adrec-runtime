using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;
using Runtime.API.Caching;
using Runtime.Common.Helpers;
using Runtime.RestClient;
using StackExchange.Redis;
using System.Reflection;

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
                c.AddSecurityRequirement(new OpenApiSecurityRequirement{{
                        new OpenApiSecurityScheme{
                            Reference = new OpenApiReference{
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },new List<string>()
                    }
                });
                // XML Doc
                string xmlDocFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlDocFilePath = Path.Combine(AppContext.BaseDirectory, xmlDocFileName);
                c.IncludeXmlComments(xmlDocFilePath);
            });

            services.AddRestClientServices(configuration);

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