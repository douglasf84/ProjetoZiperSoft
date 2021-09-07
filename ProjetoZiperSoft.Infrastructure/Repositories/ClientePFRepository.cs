using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePFRepository : IClientePFRepository
    {

        private DataContext _context;
        public ClientePFRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ClientePF> CreateAsync(ClientePF clientePF)
        {
            _context.Add(clientePF);
            await _context.SaveChangesAsync();
            return clientePF;
        }

        public async Task<ClientePF> GetByIdAsync(int? id)
        {
            return await _context.ClientesPF.FindAsync(id);
        }

        public async Task<IEnumerable<ClientePF>> GetClientePFsAsync()
        {
            return await _context.ClientesPF.ToListAsync();
        }

        public async Task<ClientePF> RemoveAsync(ClientePF clientePF)
        {
            _context.Remove(clientePF);
            await _context.SaveChangesAsync();
            return clientePF;
        }

        public async Task<ClientePF> UpdateAsync(ClientePF clientePF)
        {
            _context.Update(clientePF);
            await _context.SaveChangesAsync();
            return clientePF;
        }
    }
}
