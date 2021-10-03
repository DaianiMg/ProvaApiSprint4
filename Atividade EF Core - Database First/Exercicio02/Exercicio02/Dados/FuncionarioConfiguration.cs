using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder
                .ToTable("Funcionarios");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id");

            builder
                .Property(b => b.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property<DateTime>("DataNascimento")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()")
                .IsRequired();


            builder.Property<int>("CidadeId").IsRequired();

            builder
                .HasOne(a => a.CidadeQueTrabalha)
                .WithMany(b => b.Funcionarios)
                .HasForeignKey("CidadeId");

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            
        }
    }
}
