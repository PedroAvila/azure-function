using Example.EntidadesDominio;

namespace Example.ServiciosDominio
{
    public interface ISdCliente
    {
        Task<IEnumerable<ClienteDto>> GetAllAsync();
        Task<ClienteDto> SingleAsync(int id);
        Task CreateAsync(ClienteDto entity);
        Task UpdateAsync(ClienteDto entity);
        Task DeleteAsync(int id);
    }
}
