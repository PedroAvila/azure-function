using Example.Setup;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Example.Api.Startup))]
namespace Example.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            DefaultFunctionApplication.Configure(builder);
        }
    }
}
