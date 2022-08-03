namespace ProjetoLagune.EntradasSaidas.AcompanhamentoCarga
{
    partial class FrmAcompanha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcompanha));
            this.grpInfoCarga = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNumNota = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtValorF = new System.Windows.Forms.TextBox();
            this.lblValorF = new System.Windows.Forms.Label();
            this.lblTransp = new System.Windows.Forms.Label();
            this.txtTransp = new System.Windows.Forms.TextBox();
            this.txtPorcen = new System.Windows.Forms.TextBox();
            this.lblPorcen = new System.Windows.Forms.Label();
            this.grpDataEntrega = new System.Windows.Forms.GroupBox();
            this.mtxtDataE = new System.Windows.Forms.MaskedTextBox();
            this.lblDataE = new System.Windows.Forms.Label();
            this.grpPorcentagem = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblCadastroClientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.pbLimparTela = new System.Windows.Forms.PictureBox();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.lblLimparTela = new System.Windows.Forms.Label();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.cbNumNota = new ProjetoLagune.Controls.ComboAuto();
            this.grpInfoCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpDados.SuspendLayout();
            this.grpDataEntrega.SuspendLayout();
            this.grpPorcentagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfoCarga
            // 
            this.grpInfoCarga.Controls.Add(this.pictureBox2);
            this.grpInfoCarga.Controls.Add(this.cbNumNota);
            this.grpInfoCarga.Controls.Add(this.lblNumNota);
            this.grpInfoCarga.Location = new System.Drawing.Point(13, 25);
            this.grpInfoCarga.Name = "grpInfoCarga";
            this.grpInfoCarga.Size = new System.Drawing.Size(554, 62);
            this.grpInfoCarga.TabIndex = 0;
            this.grpInfoCarga.TabStop = false;
            this.grpInfoCarga.Text = "Informações da Carga";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(521, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // lblNumNota
            // 
            this.lblNumNota.AutoSize = true;
            this.lblNumNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumNota.Location = new System.Drawing.Point(6, 23);
            this.lblNumNota.Name = "lblNumNota";
            this.lblNumNota.Size = new System.Drawing.Size(119, 18);
            this.lblNumNota.TabIndex = 0;
            this.lblNumNota.Text = "Número da Nota:";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtNomeCliente);
            this.grpDados.Controls.Add(this.lblCliente);
            this.grpDados.Controls.Add(this.txtValorF);
            this.grpDados.Controls.Add(this.lblValorF);
            this.grpDados.Controls.Add(this.lblTransp);
            this.grpDados.Controls.Add(this.txtTransp);
            this.grpDados.Location = new System.Drawing.Point(13, 94);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(554, 124);
            this.grpDados.TabIndex = 1;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNomeCliente.Location = new System.Drawing.Point(131, 20);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(417, 25);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCliente.Location = new System.Drawing.Point(6, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(119, 18);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Nome do Cliente:";
            // 
            // txtValorF
            // 
            this.txtValorF.Enabled = false;
            this.txtValorF.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorF.Location = new System.Drawing.Point(131, 82);
            this.txtValorF.Name = "txtValorF";
            this.txtValorF.Size = new System.Drawing.Size(190, 25);
            this.txtValorF.TabIndex = 2;
            this.txtValorF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorF_KeyPress);
            // 
            // lblValorF
            // 
            this.lblValorF.AutoSize = true;
            this.lblValorF.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorF.Location = new System.Drawing.Point(6, 85);
            this.lblValorF.Name = "lblValorF";
            this.lblValorF.Size = new System.Drawing.Size(103, 18);
            this.lblValorF.TabIndex = 4;
            this.lblValorF.Text = "Valor do Frete:";
            // 
            // lblTransp
            // 
            this.lblTransp.AutoSize = true;
            this.lblTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblTransp.Location = new System.Drawing.Point(6, 54);
            this.lblTransp.Name = "lblTransp";
            this.lblTransp.Size = new System.Drawing.Size(112, 18);
            this.lblTransp.TabIndex = 3;
            this.lblTransp.Text = "Transportadora:";
            // 
            // txtTransp
            // 
            this.txtTransp.Enabled = false;
            this.txtTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtTransp.Location = new System.Drawing.Point(131, 51);
            this.txtTransp.Name = "txtTransp";
            this.txtTransp.ReadOnly = true;
            this.txtTransp.Size = new System.Drawing.Size(417, 25);
            this.txtTransp.TabIndex = 1;
            // 
            // txtPorcen
            // 
            this.txtPorcen.Enabled = false;
            this.txtPorcen.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtPorcen.Location = new System.Drawing.Point(164, 20);
            this.txtPorcen.Name = "txtPorcen";
            this.txtPorcen.ReadOnly = true;
            this.txtPorcen.Size = new System.Drawing.Size(85, 25);
            this.txtPorcen.TabIndex = 0;
            // 
            // lblPorcen
            // 
            this.lblPorcen.AutoSize = true;
            this.lblPorcen.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblPorcen.Location = new System.Drawing.Point(6, 23);
            this.lblPorcen.Name = "lblPorcen";
            this.lblPorcen.Size = new System.Drawing.Size(152, 18);
            this.lblPorcen.TabIndex = 6;
            this.lblPorcen.Text = "Porcentagem da Nota:";
            // 
            // grpDataEntrega
            // 
            this.grpDataEntrega.Controls.Add(this.mtxtDataE);
            this.grpDataEntrega.Controls.Add(this.lblDataE);
            this.grpDataEntrega.Location = new System.Drawing.Point(274, 224);
            this.grpDataEntrega.Name = "grpDataEntrega";
            this.grpDataEntrega.Size = new System.Drawing.Size(293, 55);
            this.grpDataEntrega.TabIndex = 3;
            this.grpDataEntrega.TabStop = false;
            // 
            // mtxtDataE
            // 
            this.mtxtDataE.Enabled = false;
            this.mtxtDataE.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtDataE.Location = new System.Drawing.Point(163, 20);
            this.mtxtDataE.Mask = "00/00/0000";
            this.mtxtDataE.Name = "mtxtDataE";
            this.mtxtDataE.Size = new System.Drawing.Size(124, 25);
            this.mtxtDataE.TabIndex = 0;
            this.mtxtDataE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataE.Click += new System.EventHandler(this.mtxtDataE_Click);
            // 
            // lblDataE
            // 
            this.lblDataE.AutoSize = true;
            this.lblDataE.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblDataE.Location = new System.Drawing.Point(13, 23);
            this.lblDataE.Name = "lblDataE";
            this.lblDataE.Size = new System.Drawing.Size(144, 18);
            this.lblDataE.TabIndex = 8;
            this.lblDataE.Text = "Previsão de Entrega:";
            // 
            // grpPorcentagem
            // 
            this.grpPorcentagem.Controls.Add(this.txtPorcen);
            this.grpPorcentagem.Controls.Add(this.lblPorcen);
            this.grpPorcentagem.Location = new System.Drawing.Point(13, 285);
            this.grpPorcentagem.Name = "grpPorcentagem";
            this.grpPorcentagem.Size = new System.Drawing.Size(255, 55);
            this.grpPorcentagem.TabIndex = 4;
            this.grpPorcentagem.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.maskedTextBox1.Location = new System.Drawing.Point(131, 20);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(119, 25);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data de Entrega:";
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(554, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 12;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(529, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 13;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblCadastroClientes
            // 
            this.lblCadastroClientes.AutoSize = true;
            this.lblCadastroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadastroClientes.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblCadastroClientes.ForeColor = System.Drawing.Color.DimGray;
            this.lblCadastroClientes.Location = new System.Drawing.Point(9, 7);
            this.lblCadastroClientes.Name = "lblCadastroClientes";
            this.lblCadastroClientes.Size = new System.Drawing.Size(190, 15);
            this.lblCadastroClientes.TabIndex = 14;
            this.lblCadastroClientes.Tag = "";
            this.lblCadastroClientes.Text = "ACOMPANHAMENTO DE CARGA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(467, 350);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 15;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbLimparTela
            // 
            this.pbLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimparTela.Image = ((System.Drawing.Image)(resources.GetObject("pbLimparTela.Image")));
            this.pbLimparTela.Location = new System.Drawing.Point(361, 350);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 16;
            this.pbLimparTela.TabStop = false;
            this.pbLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.pbLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(13, 350);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 18;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(491, 356);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 8;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(370, 356);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 7;
            this.lblLimparTela.Text = "Limpar Tela";
            this.lblLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.lblLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.lblLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(36, 356);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 6;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(119, 361);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 34;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // cbNumNota
            // 
            this.cbNumNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNumNota.FormattingEnabled = true;
            this.cbNumNota.LimitToList = true;
            this.cbNumNota.Location = new System.Drawing.Point(131, 20);
            this.cbNumNota.Name = "cbNumNota";
            this.cbNumNota.Size = new System.Drawing.Size(390, 26);
            this.cbNumNota.TabIndex = 0;
            this.cbNumNota.TextChanged += new System.EventHandler(this.cbNumNota_TextChanged);
            // 
            // FrmAcompanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(579, 393);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCadastroClientes);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPorcentagem);
            this.Controls.Add(this.grpDataEntrega);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpInfoCarga);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAcompanha";
            this.Text = "Acompanhamento de Carga";
            this.grpInfoCarga.ResumeLayout(false);
            this.grpInfoCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpDataEntrega.ResumeLayout(false);
            this.grpDataEntrega.PerformLayout();
            this.grpPorcentagem.ResumeLayout(false);
            this.grpPorcentagem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoCarga;
        private System.Windows.Forms.Label lblNumNota;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.TextBox txtPorcen;
        private System.Windows.Forms.Label lblPorcen;
        private System.Windows.Forms.TextBox txtValorF;
        private System.Windows.Forms.Label lblValorF;
        private System.Windows.Forms.Label lblTransp;
        private System.Windows.Forms.TextBox txtTransp;
        private System.Windows.Forms.GroupBox grpDataEntrega;
        private System.Windows.Forms.MaskedTextBox mtxtDataE;
        private System.Windows.Forms.Label lblDataE;
        private Controls.ComboAuto cbNumNota;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grpPorcentagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblCadastroClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblSalvo;
    }
}