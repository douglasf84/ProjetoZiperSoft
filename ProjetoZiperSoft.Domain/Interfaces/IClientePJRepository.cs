using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IClientePJRepository
    {
        Task<IEnumerable<ClientePJ>> GetClientePJsAsync();
        Task<ClientePJ> GetByIdAsync(int? id);
        Task<ClientePJ> CreateAsync(ClientePJ clientePJ);
        Task<ClientePJ> UpdateAsync(ClientePJ clientePJ);
        Task<ClientePJ> RemoveAsync(ClientePJ clientePJ);
    }
}
