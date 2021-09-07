using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IEnderecoService
    {
        Task<IEnumerable<EnderecoDTO>> GetEnderecos();
        Task<EnderecoDTO> GetById(int? id);
        Task Create(EnderecoDTO enderecoDTO);
        Task Update(EnderecoDTO enderecoDTO);
        Task Remove(int? id);
    }
}
