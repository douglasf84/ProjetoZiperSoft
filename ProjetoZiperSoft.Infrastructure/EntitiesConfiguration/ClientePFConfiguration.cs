using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePFConfiguration : IEntityTypeConfiguration<ClientePF>
    {
        public void Configure(EntityTypeBuilder<ClientePF> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Rg).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Foto).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(250);
            builder.Property(x => x.Situacao).IsRequired();

            builder.Property(x => x.Telefone).HasMaxLength(20);
            builder.Property(x => x.Celular).HasMaxLength(20);

            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataUltimaAtualizacao).IsRequired();

            builder.HasOne(e => e.Endereco).WithMany(e => e.ClientesPF).HasForeignKey(e => e.EnderecoId);  

        }
    }
}
