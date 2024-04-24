using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDeRecursosHumanos
{
    public partial class SalarioForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");

        private Dashboard dashboard;

        public SalarioForm()
        {
            InitializeComponent();

            dashboard = new Dashboard();
            dashboard.ArredondarFunc(panel1, 20);
            dashboard.ArredondarFunc(panel2, 20);

            mostraFuncionarios();
            desabilitaCampos();
        }

        //Função que atualiza a tela salário
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            mostraFuncionarios();
            desabilitaCampos();
        }

        public void desabilitaCampos()
        {
            labelCodFunc.Enabled = false;
            labelNome.Enabled = false;
            labelCargo.Enabled = false;
        }

        public void mostraFuncionarios()
        {
            SalarioInfo ed = new SalarioInfo();
            List<SalarioInfo> listData = ed.listaInfoSalario();

            dataGridView1.DataSource = listData;
        }

        private void btnAtualizaSalarioClick(object sender, EventArgs e)
        {
            if(labelCodFunc.Text == ""
                || labelNome.Text == ""
                || labelCargo.Text == ""
                || labelSalario.Text == "")
            {
                MessageBox.Show("Por favor, preencha os espaços em branco", "Mensagem de erro"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Tem certeza que deseja atualiza o funcionário: " 
                    + labelNome.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(check == DialogResult.Yes)
                {
                    if(connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE VPL_FUNCIONARIO SET salario = @salario" +
                                ", atualizarData = @updateData WHERE funcionarioId = @funcionarioID";

                            using(SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salario", labelSalario.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@funcionarioID", labelCodFunc.Text.Trim());

                                cmd.ExecuteNonQuery();

                                mostraFuncionarios();

                                MessageBox.Show("Atualizado com sucesso!"
                                    , "Mensagem informativa", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                limpaCampos();

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
                else
                {
                    MessageBox.Show("Cancelado", "Mensagem informativa"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void limpaCampos()
        {
            labelCodFunc.Text = "";
            labelNome.Text = "";
            labelCargo.Text = "";
            labelSalario.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                labelCodFunc.Text = row.Cells[0].Value.ToString();
                labelNome.Text = row.Cells[1].Value.ToString();
                labelCargo.Text = row.Cells[4].Value.ToString();
                labelSalario.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnLimpaSalario_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
    }
}
