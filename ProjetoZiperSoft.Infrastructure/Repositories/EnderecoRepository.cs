using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class EnderecoRepository : IEnderecoRepoitory
    {

        private DataContext _context;
        public EnderecoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Endereco> CreateAsync(Endereco endereco)
        {
            _context.Add(endereco);
            await _context.SaveChangesAsync();
            return endereco;
        }

        public async Task<Endereco> GetByIdAsync(int? id)
        {
            return await _context.Enderecos.FindAsync(id);
        }

        public async Task<IEnumerable<Endereco>> GetEnderecoAsync()
        {
            return await _context.Enderecos.ToListAsync();
        }

        public async Task<Endereco> RemoveAsync(Endereco endereco)
        {
            _context.Remove(endereco);
            await _context.SaveChangesAsync();
            return endereco;
        }

        public async Task<Endereco> UpdateAsync(Endereco endereco)
        {
            _context.Update(endereco);
            await _context.SaveChangesAsync();
            return endereco;
        }
    }
}
