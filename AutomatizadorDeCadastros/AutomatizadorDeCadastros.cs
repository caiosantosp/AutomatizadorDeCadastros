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
            }


            var nomeDoDiretorio3 = nomeDoDiretorio;
            var nomeDoDiretorio4 = nomeDoCadastro;
        }

        private bool CamposEstaoPreenchidosCorretamente()
        {
            string mensagemDeErro = "";

            if (textdiretoriodoarquivo.Text == "")
            {
                mensagemDeErro = "Preencha o diretório corretamente.";

                MessageBox.Show(mensagemDeErro);

                return false;
            }

            if (combotipocadastro.SelectedItem == null)
            {
                mensagemDeErro = "Selecione o Tipo de Cadastro corretamente.";

                MessageBox.Show(mensagemDeErro);

                return false;
            }

            return true;
        }
    }
}




