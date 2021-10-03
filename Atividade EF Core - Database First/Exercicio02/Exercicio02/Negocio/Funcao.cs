using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Negocio
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int NivelAcesso { get; set; }
        public DateTime UltimaAtualizacao { get; set; }

        public IList<FuncaoFuncionario> Funcoes { get; set; }
        public Funcao()
        {
            Funcoes = new List<FuncaoFuncionario>();
        }
    }
    
}
