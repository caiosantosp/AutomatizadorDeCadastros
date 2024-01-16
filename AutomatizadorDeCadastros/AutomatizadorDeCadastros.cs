using AutomatizadorDeCadastros.Objetos;
using System;
using System.Windows.Forms;

namespace AutomatizadorDeCadastros
{
    public partial class AutomatizadorDeCadastros : Form
    {
        public static string nomeDoDiretorio = "";
        public static string nomeDoCadastro = "";

        public AutomatizadorDeCadastros()
        {
            InitializeComponent();
        }

        private void botaobuscararquivo_Click(object sender, EventArgs e)
        {
            //verifica arquivo
            OpenFileDialog itemParaCadastro = new OpenFileDialog();
            DialogResult result = itemParaCadastro.ShowDialog();

            textdiretoriodoarquivo.Text = itemParaCadastro.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CamposEstaoPreenchidosCorretamente())
            {
                nomeDoCadastro = combotipocadastro.SelectedItem.ToString();
                nomeDoDiretorio = textdiretoriodoarquivo.Text;

                Processamento.Arquivo.IniciarProcessamentoDoArquivo(nomeDoDiretorio, nomeDoCadastro);
            }
        }

        private bool CamposEstaoPreenchidosCorretamente()
        {
            if (textdiretoriodoarquivo.Text == "")
            {
                string mensagemDeErro = "Preencha o diretório corretamente.";

                Erro.ProcessarTelaDeErro(mensagemDeErro);

                return false;
            }

            if (combotipocadastro.SelectedItem == null)
            {
                string mensagemDeErro = "Selecione o Tipo de Cadastro corretamente.";

                //Consulta sql para ver os cadastros disponiveis

                Erro.ProcessarTelaDeErro(mensagemDeErro);

                return false;
            }

            return true;
        }
    }
}




