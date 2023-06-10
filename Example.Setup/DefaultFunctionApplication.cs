using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Example.Setup.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Setup
{
    public static class DefaultFunctionApplication
    {
        public static void Configure(IFunctionsHostBuilder builder)
        {
            var keyVaultUrl = new Uri(Environment.GetEnvironmentVariable("KeyVaultUrl"));
            var secretClient = new SecretClient(keyVaultUrl, new DefaultAzureCredential());
            var secret = secretClient.GetSecret("ConnectionString");
            //var sql = secret.Value.Value;

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddAutoMapperConfiguration();
            builder.Services.AddRegisterService(secret.Value.Value);  
        }
    }
}
