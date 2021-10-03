using Exercicio02.Negocio;
using Microsoft.EntityFrameworkCore;


namespace Exercicio02.Dados
{
    public class CidadesContext : DbContext
    {
        public DbSet<Cidades> Cidades { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<FuncaoFuncionario> FuncaoFuncionario { get; set; }
        #region DbSet
        public DbSet<Funcionario> Funcionario { get; set; }
        #endregion
        public DbSet<PrefeitosAtuais> PrefeitosAtuais { get; set; }
        public DbSet<HistoriaMigracao> HistoriaMigracao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cidades;Trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Funcionario>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("VW_ALL_FUNCIONARIOS");
                        eb.Property(v => v.Nome).HasColumnName("Nome");
                        eb.Property(v => v.DataNascimento).HasColumnName("DataNascimento");
                    });
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new FuncaoConfiguration());
            modelBuilder.ApplyConfiguration(new FuncaoFuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new PrefeitosAtuaisConfiguration());
            modelBuilder.ApplyConfiguration(new HistoriaMigracaoConfiguration());

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new CidadeConfiguration());
        //    modelBuilder.ApplyConfiguration(new FuncaoConfiguration());
        //    modelBuilder.ApplyConfiguration(new FuncaoFuncionarioConfiguration());
        //    modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        //    modelBuilder.ApplyConfiguration(new PrefeitosAtuaisConfiguration());
        //    modelBuilder.ApplyConfiguration(new HistoriaMigracaoConfiguration());
        //}
    }
}
