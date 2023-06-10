using Example.EntidadesDominio;
using Example.ServiciosDominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Example.Api.Funciones
{
    public class ClienteFunction 
    {
        private readonly ISdCliente _sdCliente;

        public ClienteFunction(ISdCliente sdCliente)
        {
            _sdCliente = sdCliente;
        }

        [FunctionName("ClienteCreate")]
        public async Task<IActionResult> Create([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "cliente/create")] HttpRequest request)
        {
            string requestBody = await request.ReadAsStringAsync();
            var clienteDto = JsonConvert.DeserializeObject<ClienteDto>(requestBody);
            await _sdCliente.CreateAsync(clienteDto);

            return new OkObjectResult(clienteDto);
        }
    }
}
