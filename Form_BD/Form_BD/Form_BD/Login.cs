using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Form_BD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //troca os caracters por '•'
            txtSenha.PasswordChar = '•';
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            string logins = txtUser.Text;
            string passwords = txtSenha.Text;

            string ConnectionDataBase = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ti\\Documents\\PROJETO_BANCO_DE_DADOS\\BANCO_DE_DADOS\\DB_gustavo.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

            using (SqlConnection conexao = new SqlConnection(ConnectionDataBase)) 
            {
                conexao.Open();

                string query = "SELECT COUNT(*) FROM users WHERE logins = @logins AND passwords = @passwords";

                using (SqlCommand comando = new SqlCommand(query, conexao)) 
                {
                    comando.Parameters.AddWithValue("@logins",logins);
                    comando.Parameters.AddWithValue("@passwords", passwords);

                    int resultado = (int)comando.ExecuteScalar();

                    if(resultado > 0)
                    {
                        MessageBox.Show("login realizado com sucesso!");
                        Form2 listaChamados = new Form2();
                        listaChamados.ShowDialog();
                        this.Close(); // fechar tela atual
                    }
                    else
                    {
                        MessageBox.Show("usuario ou senha incorretos.");
                    }
                }
            }
        }
    }
}