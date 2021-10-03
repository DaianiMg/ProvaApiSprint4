using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class FuncaoConfiguration : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder
                .ToTable("Funcoes");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id");

            builder
                .Property(a => a.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(a => a.NivelAcesso)
                .HasColumnName("NivelAcesso")
                .IsRequired();

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            
        }
    }
}