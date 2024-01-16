using AutomatizadorDeCadastros.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutomatizadorDeCadastros.Processamento
{
    public class Arquivo
    {
        public static void IniciarProcessamentoDoArquivo(string diretorio, string tipodecadastro)
        {
            ArquivoDeCadastro arquivoCarregado = new ArquivoDeCadastro();

            if (!ArquivoExiste(diretorio))
                return;

            arquivoCarregado = MontarEstruturaDoArquivo(diretorio, tipodecadastro);

            if (arquivoCarregado == null)
                return;

            CriarEstruturaDoJson(arquivoCarregado);


        }

        public static ArquivoDeCadastro MontarEstruturaDoArquivo(string diretorio, string tipocadastro)
        {
            string[] linhas = File.ReadAllLines(diretorio);

            try
            {
                if (linhas.Count() < 0)
                {
                    Erro.ProcessarTelaDeErro("O arquivo deve ter no minimo uma linha para cabeçalho e uma linha de dados");

                    return null;
                }

                if (!diretorio.Contains(".csv"))
                {
                    Erro.ProcessarTelaDeErro("O arquivo deve estar no formato '.CSV'. Outros formatos não são aceitos");

                    return null;
                }


                else
                {
                    return new ArquivoDeCadastro()
                    {
                        Cabecalho = linhas[0],
                        Id = 1,
                        Linhas = linhas.Skip(1).ToArray(),
                        TipoDeCadastro = tipocadastro
                    };
                }
            }
            catch (Exception erro)
            {
                Erro.ProcessarTelaDeErro($"Verifique o arquivo carregado e tente novamente. Detalhes: {erro.Message}");

                return null;
            }
        }
        public static bool ArquivoExiste(string diretorio)
        {
            if (!File.Exists(diretorio))
            {
                Erro.ProcessarTelaDeErro("Arquivo inexistente!!");

                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidarSeEstruturaPertenceAoTipo(ArquivoDeCadastro estrutura)
        {
            //////Mudar para uma consulta sql/////
            Dictionary<string, string> cadastro = new Dictionary<string, string>
            {
                {"Produto", "Codigo;Nome;Tipo;Quantidade;Preco;Tamanho;Cor"}
            };
            ///////////
            

            // Precisa de um sql
            return true;
        }

        public static void CriarEstruturaDoJson(ArquivoDeCadastro arquivo)
        {
            string jsonSerealizado = JsonSerializer.Serialize(arquivo);
        }
    }


}
