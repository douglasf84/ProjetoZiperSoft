using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IClientePFService
    {
        Task<IEnumerable<ClientePFDTO>> GetClientesPF();
        Task<ClientePFDTO> GetById(int? id);
        Task Create(ClientePFDTO clientePFDTO);
        Task Update(ClientePFDTO clientePFDTO);
        Task Remove(int? id);
    }
}
