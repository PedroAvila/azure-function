using AutoMapper;
using Example.ServiciosDominio.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Setup.Extensions
{
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
