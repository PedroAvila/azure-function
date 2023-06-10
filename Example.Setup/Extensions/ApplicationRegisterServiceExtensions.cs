using Example.ContratoRepositorio;
using Example.Repositorios;
using Example.ServiciosDominio;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Setup
{
    public static class ApplicationRegisterServiceExtensions
    {
        public static void AddRegisterService(this IServiceCollection services, string sqlConnection)
        {
            /*Repository*/
            services.AddScoped<IClienteRepository>(provider => new ClienteRepository(sqlConnection));

            /*Service*/
            services.AddScoped(typeof(ISdCliente), typeof(SdCliente));
        }
    }
}
