using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePJRepository : IClientePJRepository
    {
        private DataContext _context;
        public ClientePJRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ClientePJ> CreateAsync(ClientePJ clientePJ)
        {
            _context.Add(clientePJ);
            await _context.SaveChangesAsync();
            return clientePJ;
        }

        public async Task<ClientePJ> GetByIdAsync(int? id)
        {
            return await _context.ClientesPJ.FindAsync(id);
        }

        public async Task<IEnumerable<ClientePJ>> GetClientePJsAsync()
        {
            return await _context.ClientesPJ.ToListAsync();
        }

        public async Task<ClientePJ> RemoveAsync(ClientePJ clientePJ)
        {
            _context.Remove(clientePJ);
            await _context.SaveChangesAsync();
            return clientePJ;
        }

        public async Task<ClientePJ> UpdateAsync(ClientePJ clientePJ)
        {
            _context.Update(clientePJ);
            await _context.SaveChangesAsync();
            return clientePJ;
        }
    }
}
