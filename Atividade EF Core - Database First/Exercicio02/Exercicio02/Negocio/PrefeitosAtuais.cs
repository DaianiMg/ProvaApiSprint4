using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Negocio
{
    public class PrefeitosAtuais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime InicioMandato { get; set; }
        public DateTime FimMandato { get; set; }
        public Cidades Cidades { get; set; }
        public DateTime UltimaAtualizacao { get; set; }

    }
}
