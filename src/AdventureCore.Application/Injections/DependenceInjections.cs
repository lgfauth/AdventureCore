using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace AdventureCore.Application.Injections
{
    public class DependenceInjections
    {
        public static void Injections(IServiceCollection services, string mongoDbConnectionString)
        {

            services.AddSingleton<IMongoClient>(sp => new MongoClient(mongoDbConnectionString));

            //services.AddScoped<IApiLog<ApiLogModel>, ApiLog<ApiLogModel>>();

            //services.AddScoped<IRegisterService, RegisterService>();
            //services.AddScoped<IRegisterRepository, RegisterRepository>();
            //services.AddScoped<IAuthRepository, AuthRepository>();
            //services.AddScoped<IAuthService, AuthService>();

            //services.AddSingleton<IRabbitMqPublisher, RabbitMqPublisher>();
        }
    }
}
