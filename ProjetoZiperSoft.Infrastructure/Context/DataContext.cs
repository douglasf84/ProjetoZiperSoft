using Microsoft.EntityFrameworkCore;

namespace ProjetoZiperSoft
{
    public class DataContext : DbContext
    {
        public DbSet<ClientePF> ClientesPF { get; set; }
        public DbSet<ClientePJ> ClientesPJ { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
