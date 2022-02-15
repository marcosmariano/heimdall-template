using Heimdall.UseCase.Interfaces;
using Heimdall.UseCase.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Heimdall.UseCase.Extensions
{
    public static class UseCaseExtensions
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<ICreateWorld, CreateWorld>();
            services.AddTransient<IDeleteWorld, DeleteWorld>();
            services.AddTransient<IUpdateWorld, UpdateWorld>();
            services.AddTransient<IGetWorldById, GetWorldById>();
            services.AddTransient<IGetWorlds, GetWorlds>();
        }
    }
}