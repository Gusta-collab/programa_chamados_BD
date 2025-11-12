using System.Configuration;
using Microsoft.Data.SqlClient;// Essencial para conectar ao SQL Server

namespace Form_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Salvar_Click_1(object sender, EventArgs e)
        {
            string connectionDataBase = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ti\\Documents\\PROJETO_BANCO_DE_DADOS\\BANCO_DE_DADOS\\DB_gustavo.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

            if ( string.IsNullOrWhiteSpace(txtColaborador.Text) ||
                string.IsNullOrWhiteSpace(txtSetor.Text) ||
                string.IsNullOrWhiteSpace(txtCausa.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar.");
                return;
            }
            ////dados do formulario 
            string colaborador = txtColaborador.Text.Trim();
            string setor = txtSetor.Text.Trim();
            string causa = txtCausa.Text.Trim();

            string sql = $"INSERT INTO  chamados (colaborador,setor,causa) VALUES (@colaborador, @setor, @causa)";

            using (SqlConnection conexao = new SqlConnection(connectionDataBase))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@colaborador", colaborador);
                    comando.Parameters.AddWithValue("@setor", setor);
                    comando.Parameters.AddWithValue("@causa", causa);

                    try
                    {
                        conexao.Open();

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Chamado cadastrado com sucesso.");

                            //limpar formulario
                            txtColaborador.Clear();
                            txtSetor.Text = string.Empty;
                            txtCausa.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar Chamado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro Banco de Dados: " + ex.Message);
                    }
                }
            }
        }
    }
}
