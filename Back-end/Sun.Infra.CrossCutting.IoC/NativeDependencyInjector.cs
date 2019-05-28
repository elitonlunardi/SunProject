using Sun.Domain;
using Sun.Application;
using Sun.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using Sun.Infra.CrossCutting.Rest;

namespace Sun.Infra.CrossCutting.IoC
{
    public class NativeDependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IWeatherRepository, WeatherRepository>();
            services.AddScoped<SunContext>();

            services.AddScoped<ICityAppService, CityAppService>();
            services.AddScoped<CityValidator>();

            services.AddScoped<IRestClient, RestClient>();
        }
    }
}
