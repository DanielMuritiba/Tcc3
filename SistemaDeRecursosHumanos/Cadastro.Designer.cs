
namespace SistemaDeRecursosHumanos
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btnRegistrarRegistro = new System.Windows.Forms.Button();
            this.checkSenha = new System.Windows.Forms.CheckBox();
            this.labelSenhaRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoginRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarRegistro
            // 
            this.btnRegistrarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnRegistrarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnRegistrarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnRegistrarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarRegistro.Location = new System.Drawing.Point(290, 253);
            this.btnRegistrarRegistro.Name = "btnRegistrarRegistro";
            this.btnRegistrarRegistro.Size = new System.Drawing.Size(93, 34);
            this.btnRegistrarRegistro.TabIndex = 17;
            this.btnRegistrarRegistro.Text = "Registrar";
            this.btnRegistrarRegistro.UseVisualStyleBackColor = false;
            this.btnRegistrarRegistro.Click += new System.EventHandler(this.btnRegistrarLogin_Click);
            // 
            // checkSenha
            // 
            this.checkSenha.AutoSize = true;
            this.checkSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSenha.Location = new System.Drawing.Point(422, 253);
            this.checkSenha.Name = "checkSenha";
            this.checkSenha.Size = new System.Drawing.Size(129, 23);
            this.checkSenha.TabIndex = 16;
            this.checkSenha.Text = "Mostrar Senha";
            this.checkSenha.UseVisualStyleBackColor = true;
            this.checkSenha.CheckedChanged += new System.EventHandler(this.checkSenha_CheckedChanged);
            // 
            // labelSenhaRegistro
            // 
            this.labelSenhaRegistro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaRegistro.Location = new System.Drawing.Point(290, 217);
            this.labelSenhaRegistro.Multiline = true;
            this.labelSenhaRegistro.Name = "labelSenhaRegistro";
            this.labelSenhaRegistro.PasswordChar = '*';
            this.labelSenhaRegistro.Size = new System.Drawing.Size(261, 30);
            this.labelSenhaRegistro.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha:";
            // 
            // labelUsuarioRegistro
            // 
            this.labelUsuarioRegistro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioRegistro.Location = new System.Drawing.Point(290, 153);
            this.labelUsuarioRegistro.Multiline = true;
            this.labelUsuarioRegistro.Name = "labelUsuarioRegistro";
            this.labelUsuarioRegistro.Size = new System.Drawing.Size(261, 30);
            this.labelUsuarioRegistro.TabIndex = 13;
            this.labelUsuarioRegistro.TextChanged += new System.EventHandler(this.labelUsuarioRegistro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Criar Conta";
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(551, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(17, 18);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLoginRegistrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 400);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sistema de Recursos Humanos";
            // 
            // btnLoginRegistrar
            // 
            this.btnLoginRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnLoginRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginRegistrar.FlatAppearance.BorderSize = 0;
            this.btnLoginRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnLoginRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLoginRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnLoginRegistrar.Location = new System.Drawing.Point(22, 345);
            this.btnLoginRegistrar.Name = "btnLoginRegistrar";
            this.btnLoginRegistrar.Size = new System.Drawing.Size(226, 31);
            this.btnLoginRegistrar.TabIndex = 1;
            this.btnLoginRegistrar.Text = "Logar";
            this.btnLoginRegistrar.UseVisualStyleBackColor = false;
            this.btnLoginRegistrar.Click += new System.EventHandler(this.btnLoginRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Logue na sua conta";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.btnRegistrarRegistro);
            this.Controls.Add(this.checkSenha);
            this.Controls.Add(this.labelSenhaRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUsuarioRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarRegistro;
        private System.Windows.Forms.CheckBox checkSenha;
        private System.Windows.Forms.TextBox labelSenhaRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox labelUsuarioRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoginRegistrar;
        private System.Windows.Forms.Label label5;
    }
}