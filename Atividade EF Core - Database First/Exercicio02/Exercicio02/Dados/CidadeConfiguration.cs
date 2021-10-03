using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidades>
    {
        public void Configure(EntityTypeBuilder<Cidades> builder)
        {
            builder
                .ToTable("Cidades");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id");

            builder
                .Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(a => a.Populacao)
                .HasColumnName("Populacao")
                .IsRequired();

            builder
                .Property(a => a.TaxaCriminalidade)
                .HasColumnName("TaxaCriminalidade")
                .HasColumnName("float")
                .IsRequired();

            builder
                .Property(a => a.Imposto)
                .HasColumnName("ImpostoSobreProduto")
                .HasColumnName("float")
                .IsRequired();

            builder
                .Property(a => a.EstadoCalamidade)
                .HasColumnName("EstadoCalamidade")
                .HasColumnName("bit")
                .IsRequired();

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
      
        }
    }
}
