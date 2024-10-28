using Microsoft.Extensions.DependencyInjection;
using SamanKish.Agg.Interfaces;
using SamanKish.App.Services;

namespace SamanKish.App
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSamanKish(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPosService), typeof(PosService));
            return services;
        }
    }
}
