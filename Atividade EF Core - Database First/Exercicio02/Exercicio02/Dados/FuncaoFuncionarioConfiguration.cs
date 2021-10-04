using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Dados
{
    public class FuncaoFuncionarioConfiguration : IEntityTypeConfiguration<FuncaoFuncionario>
    {
        public void Configure(EntityTypeBuilder<FuncaoFuncionario> builder)
        {
            builder.ToTable("FuncoesFuncionarios");

            builder.Property<Guid>("FuncionarioId")
                .IsRequired();
            builder.Property<int>("FuncaoId")
                .IsRequired();
            

            builder.HasKey("FuncionarioId", "FuncaoId");

            builder
                .HasOne(a => a.Funcionario)
                .WithMany(b => b.Empregados)
                .HasForeignKey("FuncionarioId");

            builder
                .HasOne(a => a.Funcao)
                .WithMany(b => b.Funcoes)
                .HasForeignKey("FuncaoId");
        }
    }
}