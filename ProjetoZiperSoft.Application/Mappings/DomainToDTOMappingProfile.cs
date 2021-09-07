
using AutoMapper;

namespace ProjetoZiperSoft
{
    public class DomainToDTOMappingProfile :Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<ClientePF, ClientePFDTO>().ReverseMap();
            CreateMap<ClientePJ, ClientePJDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        }
    }
}
