using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDeRecursosHumanos
{
    public partial class Cadastro : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginRegistrar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarLogin_Click(object sender, EventArgs e)
        {
            if(labelUsuarioRegistro.Text == ""
                || labelSenhaRegistro.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os pontos em branco"
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // Checar se o usuário existe
                        string selectusuarioNome = "SELECT COUNT(id) FROM VPL_USUARIOS WHERE usuarioNome = @user";

                        using(SqlCommand checkUser = new SqlCommand(selectusuarioNome, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", labelUsuarioRegistro.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(labelUsuarioRegistro.Text.Trim() + " já existe"
                                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO VPL_USUARIOS " +
                                    "(usuarioNome, senhaUsuario, dataRegistro) " +
                                    "VALUES(@usuarioNome, @senhaUsuario, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usuarioNome", labelUsuarioRegistro.Text.Trim());
                                    cmd.Parameters.AddWithValue("@senhaUsuario", labelSenhaRegistro.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registrado com sucesso!"
                                        , "Mensagem informativa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login loginForm = new Login();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                        

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            labelSenhaRegistro.PasswordChar = checkSenha.Checked ? '\0' : '*';
        }

        private void labelUsuarioRegistro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
