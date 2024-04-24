
namespace SistemaDeRecursosHumanos
{
    partial class AddFuncionarioForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addFunc_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.limpaFuncBtn = new System.Windows.Forms.Button();
            this.deletaFuncBtn = new System.Windows.Forms.Button();
            this.atualizaFuncBtn = new System.Windows.Forms.Button();
            this.btnAddNovoFunc = new System.Windows.Forms.Button();
            this.impartaImagemFuncBtn = new System.Windows.Forms.Button();
            this.imagemFunc = new System.Windows.Forms.PictureBox();
            this.addFunc_cargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addFunc_contato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addFunc_genero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addFunc_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addFunc_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 279);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(798, 193);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informação do Funcionário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 226);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addFunc_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.limpaFuncBtn);
            this.panel3.Controls.Add(this.deletaFuncBtn);
            this.panel3.Controls.Add(this.atualizaFuncBtn);
            this.panel3.Controls.Add(this.btnAddNovoFunc);
            this.panel3.Controls.Add(this.impartaImagemFuncBtn);
            this.panel3.Controls.Add(this.imagemFunc);
            this.panel3.Controls.Add(this.addFunc_cargo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addFunc_contato);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addFunc_genero);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addFunc_nome);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addFunc_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(18, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 215);
            this.panel3.TabIndex = 2;
            // 
            // addFunc_status
            // 
            this.addFunc_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_status.FormattingEnabled = true;
            this.addFunc_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.addFunc_status.Location = new System.Drawing.Point(545, 112);
            this.addFunc_status.Name = "addFunc_status";
            this.addFunc_status.Size = new System.Drawing.Size(170, 23);
            this.addFunc_status.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Atividade:";
            // 
            // limpaFunc
            // 
            this.limpaFuncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.limpaFuncBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpaFuncBtn.FlatAppearance.BorderSize = 0;
            this.limpaFuncBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.limpaFuncBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.limpaFuncBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.limpaFuncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpaFuncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpaFuncBtn.ForeColor = System.Drawing.Color.White;
            this.limpaFuncBtn.Location = new System.Drawing.Point(602, 163);
            this.limpaFuncBtn.Name = "addEmployee_clearBtn";
            this.limpaFuncBtn.Size = new System.Drawing.Size(113, 37);
            this.limpaFuncBtn.TabIndex = 17;
            this.limpaFuncBtn.Text = "Limpar";
            this.limpaFuncBtn.UseVisualStyleBackColor = false;
            this.limpaFuncBtn.Click += new System.EventHandler(this.LimpaFunc_Click);
            // 
            // deletaFuncBtn
            // 
            this.deletaFuncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.deletaFuncBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletaFuncBtn.FlatAppearance.BorderSize = 0;
            this.deletaFuncBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.deletaFuncBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.deletaFuncBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.deletaFuncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletaFuncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletaFuncBtn.ForeColor = System.Drawing.Color.White;
            this.deletaFuncBtn.Location = new System.Drawing.Point(442, 163);
            this.deletaFuncBtn.Name = "addEmployee_deleteBtn";
            this.deletaFuncBtn.Size = new System.Drawing.Size(113, 37);
            this.deletaFuncBtn.TabIndex = 16;
            this.deletaFuncBtn.Text = "Deletar";
            this.deletaFuncBtn.UseVisualStyleBackColor = false;
            this.deletaFuncBtn.Click += new System.EventHandler(this.deletaFunc_Click);
            // 
            // atualizaFuncBtn
            // 
            this.atualizaFuncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.atualizaFuncBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atualizaFuncBtn.FlatAppearance.BorderSize = 0;
            this.atualizaFuncBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.atualizaFuncBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.atualizaFuncBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.atualizaFuncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizaFuncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaFuncBtn.ForeColor = System.Drawing.Color.White;
            this.atualizaFuncBtn.Location = new System.Drawing.Point(239, 163);
            this.atualizaFuncBtn.Name = "addEmployee_updateBtn";
            this.atualizaFuncBtn.Size = new System.Drawing.Size(113, 37);
            this.atualizaFuncBtn.TabIndex = 15;
            this.atualizaFuncBtn.Text = "Atualizar";
            this.atualizaFuncBtn.UseVisualStyleBackColor = false;
            this.atualizaFuncBtn.Click += new System.EventHandler(this.atualizaFunc_Click);
            // 
            // btnAddNovoFunc
            // 
            this.btnAddNovoFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAddNovoFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNovoFunc.FlatAppearance.BorderSize = 0;
            this.btnAddNovoFunc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAddNovoFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAddNovoFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAddNovoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNovoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNovoFunc.ForeColor = System.Drawing.Color.White;
            this.btnAddNovoFunc.Location = new System.Drawing.Point(63, 163);
            this.btnAddNovoFunc.Name = "btnAddNovoFunc";
            this.btnAddNovoFunc.Size = new System.Drawing.Size(113, 37);
            this.btnAddNovoFunc.TabIndex = 14;
            this.btnAddNovoFunc.Text = "Adicionar";
            this.btnAddNovoFunc.UseVisualStyleBackColor = false;
            this.btnAddNovoFunc.Click += new System.EventHandler(this.btnAddNovoFunc_Click);
            // 
            // impartaImagemFuncBtn
            // 
            this.impartaImagemFuncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.impartaImagemFuncBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.impartaImagemFuncBtn.FlatAppearance.BorderSize = 0;
            this.impartaImagemFuncBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.impartaImagemFuncBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.impartaImagemFuncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impartaImagemFuncBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impartaImagemFuncBtn.ForeColor = System.Drawing.Color.White;
            this.impartaImagemFuncBtn.Location = new System.Drawing.Point(737, 126);
            this.impartaImagemFuncBtn.Name = "addEmployee_importBtn";
            this.impartaImagemFuncBtn.Size = new System.Drawing.Size(83, 31);
            this.impartaImagemFuncBtn.TabIndex = 13;
            this.impartaImagemFuncBtn.Text = "Importar";
            this.impartaImagemFuncBtn.UseVisualStyleBackColor = false;
            this.impartaImagemFuncBtn.Click += new System.EventHandler(this.importaFotoFunc_Click);
            // 
            // imagemFunc
            // 
            this.imagemFunc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imagemFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemFunc.Location = new System.Drawing.Point(738, 34);
            this.imagemFunc.Name = "addFunc_imagem";
            this.imagemFunc.Size = new System.Drawing.Size(82, 92);
            this.imagemFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemFunc.TabIndex = 12;
            this.imagemFunc.TabStop = false;
            // 
            // addFunc_cargo
            // 
            this.addFunc_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_cargo.FormattingEnabled = true;
            this.addFunc_cargo.Items.AddRange(new object[] {
            "Gestão de Negócios",
            "Desenvolvedor Front-End",
            "Desenvolvedor Back-End",
            "Administrador de Dados",
            "Design de UI/UX"});
            this.addFunc_cargo.Location = new System.Drawing.Point(545, 73);
            this.addFunc_cargo.Name = "addFunc_cargo";
            this.addFunc_cargo.Size = new System.Drawing.Size(170, 23);
            this.addFunc_cargo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo:";
            // 
            // addFunc_contato
            // 
            this.addFunc_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_contato.Location = new System.Drawing.Point(545, 38);
            this.addFunc_contato.Name = "addFunc_contato";
            this.addFunc_contato.Size = new System.Drawing.Size(152, 21);
            this.addFunc_contato.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de Telefone";
            // 
            // addFunc_genero
            // 
            this.addFunc_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_genero.FormattingEnabled = true;
            this.addFunc_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.addFunc_genero.Location = new System.Drawing.Point(194, 111);
            this.addFunc_genero.Name = "addFunc_genero";
            this.addFunc_genero.Size = new System.Drawing.Size(170, 23);
            this.addFunc_genero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gênero:";
            // 
            // addFunc_nome
            // 
            this.addFunc_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_nome.Location = new System.Drawing.Point(194, 75);
            this.addFunc_nome.Name = "addFunc_nome";
            this.addFunc_nome.Size = new System.Drawing.Size(170, 21);
            this.addFunc_nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Completo:";
            // 
            // addFunc_id
            // 
            this.addFunc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunc_id.Location = new System.Drawing.Point(194, 35);
            this.addFunc_id.Name = "addFunc_id";
            this.addFunc_id.Size = new System.Drawing.Size(134, 21);
            this.addFunc_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Funcionário:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 226);
            this.panel4.TabIndex = 1;
            // 
            // AddFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddFuncionarioForm";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addFunc_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addFunc_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addFunc_contato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addFunc_genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addFunc_cargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button limpaFuncBtn;
        private System.Windows.Forms.Button deletaFuncBtn;
        private System.Windows.Forms.Button atualizaFuncBtn;
        private System.Windows.Forms.Button btnAddNovoFunc;
        private System.Windows.Forms.Button impartaImagemFuncBtn;
        private System.Windows.Forms.PictureBox imagemFunc;
        private System.Windows.Forms.ComboBox addFunc_status;
        private System.Windows.Forms.Label label7;
    }
}
