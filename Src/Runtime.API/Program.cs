using Runtime.API;
using Runtime.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddApi(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.ConfigureExceptionHandler();

app.UseStaticFiles();

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.UseResponseCompression();

app.UseSwagger();
app.UseSwaggerUI(option =>
{
    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(option.RoutePrefix) ? "." : "..";
    option.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "DMT");
    option.InjectStylesheet($"{swaggerJsonBasePath}/swagger-ui/SwaggerDark.css");
});

app.MapControllers();

await app.RunAsync();