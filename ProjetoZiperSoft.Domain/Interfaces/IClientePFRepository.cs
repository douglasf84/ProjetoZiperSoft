using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IClientePFRepository
    {
        Task<IEnumerable<ClientePF>> GetClientePFsAsync();
        Task<ClientePF> GetByIdAsync(int? id);
        Task<ClientePF> CreateAsync(ClientePF clientePF);
        Task<ClientePF> UpdateAsync(ClientePF clientePF);
        Task<ClientePF> RemoveAsync(ClientePF clientePF);
    }
}
