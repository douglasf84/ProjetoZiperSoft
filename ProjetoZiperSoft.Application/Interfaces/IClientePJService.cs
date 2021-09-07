using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IClientePJService
    {
        Task<IEnumerable<ClientePJDTO>> GetClientesPJ();
        Task<ClientePJDTO> GetById(int? id);
        Task Create(ClientePJDTO clientePJDTO);
        Task Update(ClientePJDTO clientePJDTO);
        Task Remove(int? id);
    }
}
