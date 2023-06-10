using AutoMapper;
using Example.ContratoRepositorio;
using Example.EntidadesDominio;

namespace Example.ServiciosDominio
{
    public class SdCliente : ISdCliente
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public SdCliente(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<ClienteDto> SingleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(ClienteDto entity)
        {
            var cliente = _mapper.Map<Cliente>(entity);
            await _clienteRepository.CreateAsync(cliente);
        }

        public Task UpdateAsync(ClienteDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
