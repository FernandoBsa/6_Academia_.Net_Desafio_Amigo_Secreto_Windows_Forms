using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class TelaCadastro : Form
    {
        private List<Pessoa> lista = new List<Pessoa>();
        private List<Pessoa> listaSorteada = new List<Pessoa>();
        public TelaCadastro()
        {
            InitializeComponent();
            Persistencia.CriarArquivo();
            List<Pessoa> dadosArquivo = Persistencia.LerDadosDoArquivo();

            if (dadosArquivo.Count > 0)
            {
                if (Persistencia.PerguntarDados())
                {
                    lista.AddRange(dadosArquivo);

                    foreach (var pessoa in dadosArquivo)
                    {
                        ListViewItem item = new ListViewItem(pessoa.Nome);
                        item.SubItems.Add(pessoa.Email);
                        listView1.Items.Add(item);
                    }

                    MessageBox.Show("Dados carregados com sucesso.");
                }
                else
                {
                    Persistencia.LimparArquivo();
                }
            }
        }

        private void button_Cadastro_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text;
            string email = textBox_Email.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!Util.EmailValido(email))
            {
                MessageBox.Show("Por favor, insira um endereço de e-mail válido.");
                return;
            }

            nome = nome.ToUpper();

            if (lista.Any(p => p.Email == email))
            {
                MessageBox.Show("Este e-mail já foi cadastrado. Por favor, insira um e-mail diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pessoa pessoa = new Pessoa(nome, email);
            lista.Add(pessoa);
            lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            ListViewItem item = new ListViewItem(nome);
            item.SubItems.Add(email);
            listView1.Items.Add(item);

            listView1.Sorting = SortOrder.Ascending;
            listView1.Sort();

            textBox_Nome.Clear();
            textBox_Email.Clear();

            Persistencia.AdicionarAoArquivo(pessoa);
        }

        private void button_Sorteio_Click(object sender, EventArgs e)
        {
            if (lista.Count < 2)
            {
                MessageBox.Show("É necessário ter pelo menos dois amigos cadastrados antes de sortear.");
                return;
            }

            listaSorteada = new List<Pessoa>(lista);

            bool deuCerto;
            do
            {
                deuCerto = true;
                listaSorteada = listaSorteada.OrderBy(x => Random.Shared.Next()).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] == listaSorteada[i])
                    {
                        deuCerto = false;
                        break;
                    }
                }
            } while (!deuCerto);

            MessageBox.Show("Amigo Secreto gerado com sucesso, clique ok para salvar o arquivo.");

            if (listaSorteada.Count == 0)
            {
                MessageBox.Show("Não há dados para salvar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo CSV|*.csv";
                saveFileDialog.Title = "Salvar Amigo Secreto";
                saveFileDialog.FileName = "amigoSecreto.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Persistencia.SalvarDados(lista, listaSorteada, filePath);
                }
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            listaSorteada.Clear();
            listView1.Items.Clear();
            try
            {
                List<string> linhas = File.ReadAllLines(Persistencia.filePath).ToList();
                linhas.RemoveRange(1, linhas.Count - 1);
                File.WriteAllLines(Persistencia.filePath, linhas);

                MessageBox.Show("Dados e arquivo limpos com sucesso.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int indiceSelecionado = listView1.Items.IndexOf(listView1.SelectedItems[0]);

                if (indiceSelecionado >= 0 && indiceSelecionado < lista.Count)
                {
                    Pessoa pessoaRemovida = lista[indiceSelecionado];
                    listView1.Items.RemoveAt(indiceSelecionado);
                    lista.RemoveAt(indiceSelecionado);
                    Persistencia.RemoverDoArquivo(pessoaRemovida);
                    MessageBox.Show("Amigo removido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Índice inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
