using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDeRecursosHumanos
{
    public partial class Login : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarLogin_Click(object sender, EventArgs e)
        {
            Cadastro regForm = new Cadastro();
            regForm.Show();
            this.Hide();
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            labelSenhaLogin.PasswordChar = checkSenha.Checked ? '\0' : '*';
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            if(labelUsuarioLogin.Text == "" || labelSenhaLogin.Text == ""){
                MessageBox.Show("Por favor preencha todos os campos"
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM VPL_USUARIOS WHERE usuarioNome = @usuarioNome " +
                            "AND senhaUsuario = @senhaUsuario";

                        using(SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usuarioNome", labelUsuarioLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@senhaUsuario", labelSenhaLogin.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login bem sucedido!"
                                    , "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Menu mForm = new Menu();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario/Senha incorreta"
                                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
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

        private void labelUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
