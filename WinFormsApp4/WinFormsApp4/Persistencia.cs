using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public  class Persistencia
    {
        public static string filePath = "amigos.csv";
        public static void CriarArquivo()
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter escritor = new StreamWriter(filePath))
                {
                    escritor.WriteLine("Nome;Email");
                }
            }
        }

        public static void AdicionarAoArquivo(Pessoa pessoa)
        {
            List<Pessoa> dados = LerDadosDoArquivo();
            dados.Add(pessoa);
            dados.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            try
            {
                using (StreamWriter escritor = new StreamWriter(filePath))
                {
                    escritor.WriteLine("Nome;Email");

                    foreach (var pessoaAtual in dados)
                    {
                        escritor.WriteLine($"{pessoaAtual.Nome};{pessoaAtual.Email}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao adicionar ao arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Pessoa> LerDadosDoArquivo()
        {
            List<Pessoa> dados = new List<Pessoa>();

            try
            {
                using (StreamReader leitor = new StreamReader(filePath))
                {
                    string linha;
                    leitor.ReadLine();

                    while ((linha = leitor.ReadLine()) != null)
                    {
                        string[] partes = linha.Split(';');
                        if (partes.Length == 2)
                        {
                            string nome = partes[0].Trim();
                            string email = partes[1].Trim();
                            dados.Add(new Pessoa(nome, email));
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dados;
        }

        public static bool PerguntarDados()
        {
            DialogResult resultado = MessageBox.Show("Deseja carregar a lista anterior?", "Carregar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado == DialogResult.Yes;
        }

        public static void RemoverDoArquivo(Pessoa pessoa)
        {
            try
            {
                List<string> linhas = File.ReadAllLines(filePath).ToList();
                linhas.RemoveAt(0);

                for (int i = 0; i < linhas.Count; i++)
                {
                    string[] partes = linhas[i].Split(';');
                    if (partes.Length == 2)
                    {
                        string nome = partes[0].Trim();
                        string email = partes[1].Trim();

                        if (nome == pessoa.Nome && email == pessoa.Email)
                        {
                            linhas.RemoveAt(i);
                            break;
                        }
                    }
                }

                linhas.Insert(0, "Nome;Email");

                File.WriteAllLines(filePath, linhas);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao remover do arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SalvarDados(List<Pessoa> lista, List<Pessoa> listaSorteada, string filePath)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(filePath))
                {
                    for (int i = 0; i < listaSorteada.Count; i++)
                    {
                        escritor.WriteLine($"{lista[i].Nome};{lista[i].Email} ; {listaSorteada[i].Nome};{listaSorteada[i].Email}");
                    }
                }

                MessageBox.Show("Dados salvos com sucesso.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LimparArquivo()
        {
            try
            {
                File.WriteAllText(filePath, "Nome;Email");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
