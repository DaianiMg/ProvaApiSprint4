using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Negocio
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }
        public float TaxaCriminalidade { get; set; }
        public float Imposto { get; set; }
        public bool EstadoCalamidade { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public IList<Funcionario> Funcionarios { get; set; }
        public PrefeitosAtuais PrefeitosAtuais { get; set; }

        public Cidades()
        {
            Funcionarios = new List<Funcionario>();
        }

        public override string ToString()
        {
            return $"Cidade ({Id} - {Nome}): {Populacao}, {TaxaCriminalidade}, {Imposto}, {EstadoCalamidade}";
        }
    }
    
}
