using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class PrefeitosAtuaisConfiguration : IEntityTypeConfiguration<PrefeitosAtuais>
    {
        public void Configure(EntityTypeBuilder<PrefeitosAtuais> builder)
        {
            builder
                .ToTable("PrefeitosAtuais");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id");

            builder
                .Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property<DateTime>("InicioMandato")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder
               .Property<DateTime>("FimMandato")
               .HasColumnType("datetime2")
               .HasDefaultValueSql("getdate()")
               .IsRequired();

            //FK CIDADEId
            builder.Property<Guid>("CidadeId").IsRequired();

            builder
               .HasOne(a => a.Cidades)
               .WithOne(b => b.PrefeitosAtuais)
               .HasForeignKey<PrefeitosAtuais>("CidadeId");

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

        }
    }
}
