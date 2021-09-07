using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Logradouro).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Numero).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(20).IsRequired();            
            builder.Property(x => x.Cep).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Estado).HasMaxLength(20).IsRequired(); ;
          
        }
       
    }
}