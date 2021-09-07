using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public interface IEnderecoRepoitory
    {
        Task<IEnumerable<Endereco>> GetEnderecoAsync();
        Task<Endereco> GetByIdAsync(int? id);
        Task<Endereco> CreateAsync(Endereco endereco);
        Task<Endereco> UpdateAsync(Endereco endereco);
        Task<Endereco> RemoveAsync(Endereco endereco);
    }
}
