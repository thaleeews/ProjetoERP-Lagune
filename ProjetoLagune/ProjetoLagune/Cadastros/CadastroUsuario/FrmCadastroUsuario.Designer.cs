namespace ProjetoLagune.Cadastros.CadastroUsuario
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCadastroClientes = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblSenhasIncorretas = new System.Windows.Forms.Label();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.cbNomeUsuario = new ProjetoLagune.Controls.ComboAuto();
            this.cbSetor = new ProjetoLagune.Controls.ComboAuto();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCadastroClientes
            // 
            this.lblCadastroClientes.AutoSize = true;
            this.lblCadastroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadastroClientes.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblCadastroClientes.ForeColor = System.Drawing.Color.DimGray;
            this.lblCadastroClientes.Location = new System.Drawing.Point(9, 7);
            this.lblCadastroClientes.Name = "lblCadastroClientes";
            this.lblCadastroClientes.Size = new System.Drawing.Size(152, 15);
            this.lblCadastroClientes.TabIndex = 15;
            this.lblCadastroClientes.Tag = "";
            this.lblCadastroClientes.Text = "CADASTRO DE USUÁRIOS";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(121, 61);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(255, 25);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepetirSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtRepetirSenha.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtRepetirSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRepetirSenha.Location = new System.Drawing.Point(121, 92);
            this.txtRepetirSenha.MaxLength = 20;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = '*';
            this.txtRepetirSenha.Size = new System.Drawing.Size(255, 25);
            this.txtRepetirSenha.TabIndex = 2;
            this.txtRepetirSenha.Tag = "";
            this.txtRepetirSenha.TextChanged += new System.EventHandler(this.txtRepetirSenha_TextChanged);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(276, 174);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 23;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(12, 174);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 24;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.ForeColor = System.Drawing.Color.Black;
            this.lblSalvar.Location = new System.Drawing.Point(35, 180);
            this.lblSalvar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 4;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(300, 180);
            this.lblVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 5;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(363, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 7;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(338, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 6;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(13, 32);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(13, 64);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 18);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha";
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRepetirSenha.ForeColor = System.Drawing.Color.Black;
            this.lblRepetirSenha.Location = new System.Drawing.Point(13, 95);
            this.lblRepetirSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(101, 18);
            this.lblRepetirSenha.TabIndex = 31;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // lblSetor
            // 
            this.lblSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSetor.AutoSize = true;
            this.lblSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSetor.ForeColor = System.Drawing.Color.Black;
            this.lblSetor.Location = new System.Drawing.Point(13, 126);
            this.lblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(44, 18);
            this.lblSetor.TabIndex = 32;
            this.lblSetor.Text = "Setor";
            // 
            // lblSenhasIncorretas
            // 
            this.lblSenhasIncorretas.AutoSize = true;
            this.lblSenhasIncorretas.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.lblSenhasIncorretas.Location = new System.Drawing.Point(257, 152);
            this.lblSenhasIncorretas.Name = "lblSenhasIncorretas";
            this.lblSenhasIncorretas.Size = new System.Drawing.Size(0, 12);
            this.lblSenhasIncorretas.TabIndex = 33;
            this.lblSenhasIncorretas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalvo
            // 
            this.lblSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(224, 185);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 34;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Enabled = false;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(141, 180);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 72;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Enabled = false;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(118, 174);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 73;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // cbNomeUsuario
            // 
            this.cbNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNomeUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.cbNomeUsuario.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNomeUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbNomeUsuario.FormattingEnabled = true;
            this.cbNomeUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Financeiro",
            "Laboratório",
            "PPCP",
            "Vendas",
            ""});
            this.cbNomeUsuario.LimitToList = true;
            this.cbNomeUsuario.Location = new System.Drawing.Point(121, 29);
            this.cbNomeUsuario.MaxLength = 20;
            this.cbNomeUsuario.Name = "cbNomeUsuario";
            this.cbNomeUsuario.Size = new System.Drawing.Size(255, 26);
            this.cbNomeUsuario.TabIndex = 74;
            this.cbNomeUsuario.TextChanged += new System.EventHandler(this.cbNomeUsuario_TextChanged);
            // 
            // cbSetor
            // 
            this.cbSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSetor.BackColor = System.Drawing.SystemColors.Window;
            this.cbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbSetor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Items.AddRange(new object[] {
            "Administrador",
            "Financeiro",
            "Laboratório",
            "PPCP",
            "Vendas",
            ""});
            this.cbSetor.LimitToList = true;
            this.cbSetor.Location = new System.Drawing.Point(121, 123);
            this.cbSetor.MaxLength = 40;
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(255, 26);
            this.cbSetor.TabIndex = 3;
            this.cbSetor.TextChanged += new System.EventHandler(this.cbSetor_TextChanged);
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(388, 214);
            this.Controls.Add(this.cbNomeUsuario);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSenhasIncorretas);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblCadastroClientes);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroUsuario";
            this.Text = "FrmCadastroUsuario";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastroClientes;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblSenhasIncorretas;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private Controls.ComboAuto cbSetor;
        private Controls.ComboAuto cbNomeUsuario;
    }
}