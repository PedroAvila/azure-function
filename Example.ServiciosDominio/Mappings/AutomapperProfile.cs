using AutoMapper;
using Example.EntidadesDominio;

namespace Example.ServiciosDominio.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}
