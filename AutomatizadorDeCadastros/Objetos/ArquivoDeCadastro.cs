using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizadorDeCadastros.Objetos
{
    public class ArquivoDeCadastro
    {
        public int Id { get; set; }
        public string Cabecalho { get; set; }
        public string TipoDeCadastro { get; set;}
        public string[] Linhas { get; set; }
    }
}
