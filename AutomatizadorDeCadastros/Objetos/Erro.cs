using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizadorDeCadastros.Objetos
{
    public class Erro
    {
        public static void ProcessarTelaDeErro(string mensagemdeerro)
        {
            MessageBox.Show(mensagemdeerro);
        }
    }
}
