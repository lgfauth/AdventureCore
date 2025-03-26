using AdventureCore.Application.Injections;
using AdventureCore.Domain.Settings;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace AdventureCore.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var variables = builder.Configuration.Get<EnvirolmentVariables>();
            builder.Services.AddSingleton(variables);

            DependenceInjections.Injections(builder.Services, variables.MONGODBSETTINGS_CONNECTIONSTRING);

            var isDevelopment = builder.Environment.IsDevelopment();
            if (!isDevelopment)
            {
                var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
                builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
            }

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.EnableAnnotations();

                var domainXmlPath = Path.Combine(AppContext.BaseDirectory, "AdventureCore.Domain.xml");
                var apiXmlPath = Path.Combine(AppContext.BaseDirectory,
                    $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");

                options.IncludeXmlComments(domainXmlPath);
                options.IncludeXmlComments(apiXmlPath);

                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Adventure Core API", Version = "v1" });
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            //await HeathChecker.CheckMongoDbConnection(variables);

            app.Run();
        }
    }
}