using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Negocio
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<FuncaoFuncionario> Empregados { get; set; }
        public Cidades CidadeQueTrabalha { get; set; }


        public Funcionario()
        {
            Empregados = new List<FuncaoFuncionario>();
        }
        public override string ToString()
        {
            return $"Funcionario ({Nome}): {DataNascimento}, {CidadeQueTrabalha}";
        }
    }
    
}
