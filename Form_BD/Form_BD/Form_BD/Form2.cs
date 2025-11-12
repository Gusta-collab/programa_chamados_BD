using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Form_BD
{
    public partial class Form2 : Form
    {
        string ConnectionDataBase = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ti\\Documents\\PROJETO_BANCO_DE_DADOS\\BANCO_DE_DADOS\\DB_gustavo.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public Form2()
        {
            InitializeComponent();
            CarregarChamados();
        }
        private void CarregarChamados()
        {
            string sql = "SELECT id, colaborador, setor, causa FROM chamados ORDER BY id ASC";

            DataTable tabelaChamados = new DataTable();

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(comando);

                        adapter.Fill(tabelaChamados);

                        dgvChamados.DataSource = tabelaChamados;

                        dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        //vai fazer com que seja a ultima coluna da tabela, as tabelas por padrão ficam por ordem de criação.
                        dgvChamados.Columns["Acoes"].DisplayIndex = dgvChamados.Columns.Count - 1;
                        dgvChamados.Columns["Detalhes"].DisplayIndex = dgvChamados.Columns.Count - 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CriarChamado_Click(object sender, EventArgs e)
        {
            Form1 FormCriacao = new Form1();
            FormCriacao.ShowDialog();
        }
        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string nomeColuna = dgvChamados.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "Acoes")
            {
                object ValorCelula = dgvChamados.CurrentRow.Cells[2].Value;

                editarChamado destino = new editarChamado(ValorCelula.ToString());
                destino.ShowDialog();
            }

            if(nomeColuna == "Detalhes")
            {
                string valor = dgvChamados.Rows[e.RowIndex].Cells["causa"].Value?.ToString();

                MessageBox.Show("Detalhes:" + valor);
            }
        }
        private void BTNatualizar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, colaborador, setor, causa FROM chamados ORDER BY id ASC";

            DataTable tabelaChamados = new DataTable();

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(comando);

                        adapter.Fill(tabelaChamados);

                        dgvChamados.DataSource = tabelaChamados;

                        dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
