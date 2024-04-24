using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SistemaDeRecursosHumanos
{
    public partial class AddFuncionarioForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");

        private Dashboard dashboard;

        public AddFuncionarioForm()
        {
            InitializeComponent();

            dashboard = new Dashboard();
            dashboard.ArredondarFunc(panel1, 20);
            dashboard.ArredondarFunc(panel3, 20);
            // Chama as infos do banco de dados
            mostraInfoFuncionario();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            mostraInfoFuncionario();
        }

        public void mostraInfoFuncionario()
        {
            FuncionarioInfo ed = new FuncionarioInfo();
            List<FuncionarioInfo> listData = ed.listaInfoFucionario();

            dataGridView1.DataSource = listData;
        }

        private void btnAddNovoFunc_Click(object sender, EventArgs e)
        {
            if(addFunc_id.Text == ""
                || addFunc_nome.Text == ""
                || addFunc_genero.Text == ""
                || addFunc_contato.Text == ""
                || addFunc_cargo.Text == ""
                || addFunc_status.Text == ""
                || imagemFunc.Image == null)
            {
                MessageBox.Show("Por favor, preencha os campos em branco"
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM VPL_FUNCIONARIO WHERE funcionarioId = @funcID AND deletarData IS NULL";

                        using(SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@funcID", addFunc_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addFunc_id.Text.Trim() + " já foi utilizado"
                                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO VPL_FUNCIONARIO " +
                                    "(funcionarioId, nomeFuncionario, generoFuncionario, telefoneFuncionario" +
                                    ", cargo, imagemFuncionario, salario, inserirData, statusFuncionario) " +
                                    "VALUES(@funcionarioID, @funcNome, @generoFunc, @contatoFunc" +
                                    ", @cargo, @image, @salario, @insereInfo, @status)";

                                string path = Path.Combine(@"C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\Directory\"
                                    + addFunc_id.Text.Trim() + ".jpg");

                                string diretorioPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(diretorioPath))
                                {
                                    Directory.CreateDirectory(diretorioPath);
                                }

                                File.Copy(imagemFunc.ImageLocation, path, true);

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@funcionarioID", addFunc_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@funcNome", addFunc_nome.Text.Trim());
                                    cmd.Parameters.AddWithValue("@generoFunc", addFunc_genero.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contatoFunc", addFunc_contato.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cargo", addFunc_cargo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salario", 0);
                                    cmd.Parameters.AddWithValue("@insereInfo", today);
                                    cmd.Parameters.AddWithValue("@status", addFunc_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    mostraInfoFuncionario();

                                    MessageBox.Show("Adicionado com sucesso!"
                                        , "Mensagem informativa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
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

        private void importaFotoFunc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    imagemFunc.ImageLocation = imagePath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Mensagem de erro"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addFunc_id.Text = row.Cells[1].Value.ToString();
                addFunc_nome.Text = row.Cells[2].Value.ToString();
                addFunc_genero.Text = row.Cells[3].Value.ToString();
                addFunc_contato.Text = row.Cells[4].Value.ToString();
                addFunc_cargo.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {
                    imagemFunc.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imagemFunc.Image = null;
                }

                addFunc_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            addFunc_id.Text = "";
            addFunc_nome.Text = "";
            addFunc_genero.SelectedIndex = -1;
            addFunc_contato.Text = "";
            addFunc_cargo.SelectedIndex = -1;
            addFunc_status.SelectedIndex = -1;
            imagemFunc.Image = null;
        }

        private void atualizaFunc_Click(object sender, EventArgs e)
        {
            if (addFunc_id.Text == ""
                || addFunc_nome.Text == ""
                || addFunc_genero.Text == ""
                || addFunc_contato.Text == ""
                || addFunc_cargo.Text == ""
                || addFunc_status.Text == ""
                || imagemFunc.Image == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos"
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Tem certeza que deseja atualizar " +
                    "o funcionário: " + addFunc_nome.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE VPL_FUNCIONARIO SET nomeFuncionario = @funcNome" +
                            ", generoFuncionario = @generoFunc, telefoneFuncionario = @contatoFunc" +
                            ", cargo = @cargo, atualizarData = @updateDate, statusFuncionario = @status " +
                            "WHERE funcionarioId = @funcionarioID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@funcNome", addFunc_nome.Text.Trim());
                            cmd.Parameters.AddWithValue("@generoFunc", addFunc_genero.Text.Trim());
                            cmd.Parameters.AddWithValue("@contatoFunc", addFunc_contato.Text.Trim());
                            cmd.Parameters.AddWithValue("@cargo", addFunc_cargo.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addFunc_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@funcionarioID", addFunc_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            mostraInfoFuncionario();

                            MessageBox.Show("Atualização bem sucedida!"
                                , "Mensagem informativa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            clearFields();
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
                else
                {
                    MessageBox.Show("Cancelado."
                        , "Mensagem Informativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void LimpaFunc_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void deletaFunc_Click(object sender, EventArgs e)
        {
            if (addFunc_id.Text == ""
                || addFunc_nome.Text == ""
                || addFunc_genero.Text == ""
                || addFunc_contato.Text == ""
                || addFunc_cargo.Text == ""
                || addFunc_status.Text == ""
                || imagemFunc.Image == null)
            {
                MessageBox.Show("Por favor, preencha os campos em branco"
                    , "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Tem certeza que deseja deletar " +
                    " o funcionário: " + addFunc_nome.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE VPL_FUNCIONARIO SET deletarData = @deleteDate " +
                            "WHERE funcionarioId = @funcionarioID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@funcionarioID", addFunc_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            mostraInfoFuncionario();

                            MessageBox.Show("Atualizado com sucesso!"
                                , "Mensagem informativa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
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
                else
                {
                    MessageBox.Show("Cancelado."
                        , "Mensagem informativa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
