using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePJConfiguration : IEntityTypeConfiguration<ClientePJ>
    {
        public void Configure(EntityTypeBuilder<ClientePJ> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Ie).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cnpj).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Foto).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(250);
            builder.Property(x => x.Situacao).IsRequired();
            builder.Property(x => x.Site).HasMaxLength(50);

            builder.Property(x => x.Telefone).HasMaxLength(20);
            builder.Property(x => x.Celular).HasMaxLength(20);

            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataUltimaAtualizacao).IsRequired();

            builder.HasOne(e => e.Endereco).WithMany(e => e.ClientesPJ).HasForeignKey(e => e.EnderecoId);
        }
    }
}
