using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Form_BD
{
    public partial class editarChamado : Form
    {


        private readonly string ConnectionDataBase = ConfigurationHelper.GetConnectionString("DB_Chamados");
        private string IDarmazenado;

        public editarChamado()
        {
            InitializeComponent();

        }
        public editarChamado(string ValorCelula)
        {
            InitializeComponent();
            this.IDarmazenado = ValorCelula;

            string sql = "SELECT colaborador, setor, causa FROM chamados WHERE id = @IDarmazenado";

            DataTable tabelaChamados = new DataTable();

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (int.TryParse(IDarmazenado, out int idChamado))
                    {
                        comando.Parameters.Add("@IDarmazenado", SqlDbType.Int).Value = idChamado;
                    }
                    else
                    {
                        MessageBox.Show("O ID é invalido", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    try
                    {
                        conexao.Open();
                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            TBSetor.Text = reader["setor"].ToString();
                            TBColbaborador.Text = reader["colaborador"].ToString();
                            TBCausa.Text = reader["causa"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Chamado com o ID" + IDarmazenado + "não encontrado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar os dados:" + ex.Message);
                    }
                }
            }
        }
        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            string IDsalvar = this.IDarmazenado;

            if (string.IsNullOrWhiteSpace(TBSetor.Text) ||
                string.IsNullOrWhiteSpace(TBColbaborador.Text) ||
                string.IsNullOrWhiteSpace(TBCausa.Text))
            {
                MessageBox.Show("por favor, preencha todos os campos antes de salvar.");
                return;
            }

            string setor = TBSetor.Text.Trim();
            string colaborador = TBColbaborador.Text.Trim();
            string causa = TBCausa.Text.Trim();

            string sql = "UPDATE chamados SET setor = @setor, colaborador = @colaborador, causa = @causa WHERE id = @IDarmazenado";

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@setor", setor);
                    comando.Parameters.AddWithValue("@colaborador", colaborador);
                    comando.Parameters.AddWithValue("@causa", causa);

                    if (int.TryParse(IDsalvar, out int ID))
                    {
                        comando.Parameters.AddWithValue("@IDarmazenado", ID);
                    }
                    else
                    {
                        MessageBox.Show("Erro interno: ID invalido." + MessageBoxButtons.OK + MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        conexao.Open();

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Chamado atualizado com sucesso.");
                            //Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BTNexcluir_Click(object sender, EventArgs e)
        {
            string IDdeletar = this.IDarmazenado;

            if (string.IsNullOrWhiteSpace(TBSetor.Text) ||
                string.IsNullOrWhiteSpace(TBColbaborador.Text) ||
                string.IsNullOrWhiteSpace(TBCausa.Text))
            {
                MessageBox.Show("por favor, preencha todos os campos antes de salvar.");
                return;
            }

            string sql = "DELETE FROM chamados WHERE id = @IDarmazenado";

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if(int.TryParse(IDdeletar, out int ID))
                    {
                        comando.Parameters.AddWithValue("@IDarmazenado", ID);
                    }
                    else
                    {
                        MessageBox.Show("Erro interno: ID invalido" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                    }

                    try
                    {
                        conexao.Open();

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Chamado excluido com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string conexao = ConfigurationHelper.GetConnectionString("DB_Chamados");
            MessageBox.Show("Conexão lida do JSON:\n" + conexao);
        }


    }
}
