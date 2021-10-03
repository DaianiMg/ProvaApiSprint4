using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class HistoriaMigracaoConfiguration : IEntityTypeConfiguration<HistoriaMigracao>
    {
        public void Configure(EntityTypeBuilder<HistoriaMigracao> builder)
        {
            
            builder
                .ToTable("_EFMigrationsHistory");

            builder
                .Property(a => a.MigrationId)
                .HasColumnName("MigrationId");

            builder
                .Property(b => b.ProductVersion)
                    .HasColumnName("ProductVersion")
                    .IsRequired();


        }
    }
}
