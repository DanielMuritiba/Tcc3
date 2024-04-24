using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaDeRecursosHumanos
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();

            mostraFT();
            mostraFA();
            mostraFI();
            ArredondarFunc(panel1, 20);
            ArredondarFunc(panel3, 20);
            ArredondarFunc(panel4, 20);
            ArredondarFunc(panel5, 20);
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            mostraFT();
            mostraFA();
            mostraFI();
        }

        public void mostraFT()
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM VPL_FUNCIONARIO WHERE deletarData IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_FT.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Mensagem de erro"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void mostraFA()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM VPL_FUNCIONARIO WHERE statusFuncionario = @status " +
                        "AND deletarData IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Ativo");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_FA.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Mensagem de erro"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void mostraFI()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM VPL_FUNCIONARIO WHERE statusFuncionario = @status " +
                        "AND deletarData IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inativo");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_FI.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Mensagem de erro"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        //Usado para arredondar todos os tipos de borda
        public void ArredondarFunc(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(0, 0, diameter, diameter);
            path.AddArc(arc, 180, 90);
            arc.X = panel.Width - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = panel.Height - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = 0;
            path.AddArc(arc, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
