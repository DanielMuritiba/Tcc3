using System;
using System.Windows.Forms;

namespace SistemaDeRecursosHumanos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Tem certeza que deseja deslogar?"
                , "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addFuncionario.Visible = false;
            salario.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = true;
            salario.Visible = false;

            AddFuncionarioForm addEmForm = addFuncionario as AddFuncionarioForm;

            if(addEmForm != null)
            {
                addEmForm.RefreshData();
            }

        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = false;
            salario.Visible = true;

            SalarioForm salaryForm = salario as SalarioForm;

            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }
    }
}