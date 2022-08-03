namespace ProjetoLagune.EntradasSaidas.SaidaNotaFiscal
{
    partial class FrmSaidaNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaidaNota));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumNota = new System.Windows.Forms.TextBox();
            this.lblNumNota = new System.Windows.Forms.Label();
            this.mtxtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorProdu = new System.Windows.Forms.TextBox();
            this.lblValorProdu = new System.Windows.Forms.Label();
            this.txtValorNota = new System.Windows.Forms.TextBox();
            this.lblValorNota = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQtCaixa = new System.Windows.Forms.TextBox();
            this.lblQtCaixa = new System.Windows.Forms.Label();
            this.lblTransp = new System.Windows.Forms.Label();
            this.comboTransp = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblLimparTela = new System.Windows.Forms.Label();
            this.pbLimparTela = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtNumNota);
            this.groupBox1.Controls.Add(this.lblNumNota);
            this.groupBox1.Controls.Add(this.mtxtDataSaida);
            this.groupBox1.Controls.Add(this.lblDataSaida);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtNumNota
            // 
            this.txtNumNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNumNota.Location = new System.Drawing.Point(397, 20);
            this.txtNumNota.Name = "txtNumNota";
            this.txtNumNota.Size = new System.Drawing.Size(161, 25);
            this.txtNumNota.TabIndex = 2;
            this.txtNumNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNota_KeyPress);
            // 
            // lblNumNota
            // 
            this.lblNumNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumNota.AutoSize = true;
            this.lblNumNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumNota.Location = new System.Drawing.Point(255, 23);
            this.lblNumNota.Name = "lblNumNota";
            this.lblNumNota.Size = new System.Drawing.Size(119, 18);
            this.lblNumNota.TabIndex = 2;
            this.lblNumNota.Text = "Número da Nota:";
            // 
            // mtxtDataSaida
            // 
            this.mtxtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDataSaida.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtDataSaida.Location = new System.Drawing.Point(131, 20);
            this.mtxtDataSaida.Mask = "00/00/0000";
            this.mtxtDataSaida.Name = "mtxtDataSaida";
            this.mtxtDataSaida.Size = new System.Drawing.Size(118, 25);
            this.mtxtDataSaida.TabIndex = 1;
            this.mtxtDataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataSaida.Click += new System.EventHandler(this.mtxtNumeroS_Click);
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblDataSaida.Location = new System.Drawing.Point(6, 23);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(101, 18);
            this.lblDataSaida.TabIndex = 0;
            this.lblDataSaida.Text = "Data de Saída:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtValorProdu);
            this.groupBox2.Controls.Add(this.lblValorProdu);
            this.groupBox2.Controls.Add(this.txtValorNota);
            this.groupBox2.Controls.Add(this.lblValorNota);
            this.groupBox2.Location = new System.Drawing.Point(13, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            // 
            // txtValorProdu
            // 
            this.txtValorProdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorProdu.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorProdu.Location = new System.Drawing.Point(397, 18);
            this.txtValorProdu.Name = "txtValorProdu";
            this.txtValorProdu.Size = new System.Drawing.Size(161, 25);
            this.txtValorProdu.TabIndex = 1;
            this.txtValorProdu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProdu_KeyPress);
            // 
            // lblValorProdu
            // 
            this.lblValorProdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorProdu.AutoSize = true;
            this.lblValorProdu.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorProdu.Location = new System.Drawing.Point(255, 21);
            this.lblValorProdu.Name = "lblValorProdu";
            this.lblValorProdu.Size = new System.Drawing.Size(136, 18);
            this.lblValorProdu.TabIndex = 5;
            this.lblValorProdu.Text = "Valor dos Produtos:";
            // 
            // txtValorNota
            // 
            this.txtValorNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorNota.Location = new System.Drawing.Point(131, 18);
            this.txtValorNota.Name = "txtValorNota";
            this.txtValorNota.Size = new System.Drawing.Size(118, 25);
            this.txtValorNota.TabIndex = 0;
            this.txtValorNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorNota_KeyPress);
            // 
            // lblValorNota
            // 
            this.lblValorNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorNota.AutoSize = true;
            this.lblValorNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorNota.Location = new System.Drawing.Point(6, 21);
            this.lblValorNota.Name = "lblValorNota";
            this.lblValorNota.Size = new System.Drawing.Size(100, 18);
            this.lblValorNota.TabIndex = 0;
            this.lblValorNota.Text = "Valor da Nota:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtQtCaixa);
            this.groupBox3.Controls.Add(this.lblQtCaixa);
            this.groupBox3.Controls.Add(this.lblTransp);
            this.groupBox3.Controls.Add(this.comboTransp);
            this.groupBox3.Controls.Add(this.comboCliente);
            this.groupBox3.Controls.Add(this.lblCliente);
            this.groupBox3.Location = new System.Drawing.Point(13, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Transporte";
            // 
            // txtQtCaixa
            // 
            this.txtQtCaixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtCaixa.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQtCaixa.Location = new System.Drawing.Point(165, 84);
            this.txtQtCaixa.Name = "txtQtCaixa";
            this.txtQtCaixa.Size = new System.Drawing.Size(118, 25);
            this.txtQtCaixa.TabIndex = 2;
            this.txtQtCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtCaixa_KeyPress);
            // 
            // lblQtCaixa
            // 
            this.lblQtCaixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtCaixa.AutoSize = true;
            this.lblQtCaixa.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQtCaixa.Location = new System.Drawing.Point(6, 87);
            this.lblQtCaixa.Name = "lblQtCaixa";
            this.lblQtCaixa.Size = new System.Drawing.Size(153, 18);
            this.lblQtCaixa.TabIndex = 8;
            this.lblQtCaixa.Text = "Quantidade de Caixas:";
            // 
            // lblTransp
            // 
            this.lblTransp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransp.AutoSize = true;
            this.lblTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblTransp.Location = new System.Drawing.Point(6, 55);
            this.lblTransp.Name = "lblTransp";
            this.lblTransp.Size = new System.Drawing.Size(112, 18);
            this.lblTransp.TabIndex = 7;
            this.lblTransp.Text = "Transportadora:";
            // 
            // comboTransp
            // 
            this.comboTransp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboTransp.FormattingEnabled = true;
            this.comboTransp.Location = new System.Drawing.Point(165, 52);
            this.comboTransp.Name = "comboTransp";
            this.comboTransp.Size = new System.Drawing.Size(387, 26);
            this.comboTransp.TabIndex = 1;
            // 
            // comboCliente
            // 
            this.comboCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(165, 20);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(387, 26);
            this.comboCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCliente.Location = new System.Drawing.Point(6, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(569, 0);
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
            this.btMin.Location = new System.Drawing.Point(544, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 6;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 8;
            this.label3.Tag = "";
            this.label3.Text = "SAÍDA DE NOTA FISCAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(506, 287);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 5;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(482, 281);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 25;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(385, 287);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 4;
            this.lblLimparTela.Text = "Limpar Tela";
            this.lblLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.lblLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.lblLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // pbLimparTela
            // 
            this.pbLimparTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimparTela.Image = ((System.Drawing.Image)(resources.GetObject("pbLimparTela.Image")));
            this.pbLimparTela.Location = new System.Drawing.Point(376, 281);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 27;
            this.pbLimparTela.TabStop = false;
            this.pbLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.pbLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(36, 287);
            this.lblSalvar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 3;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(13, 281);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 29;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(119, 292);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 31;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // FrmSaidaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(594, 323);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSaidaNota";
            this.Text = "Saída de Nota Fiscal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumNota;
        private System.Windows.Forms.Label lblNumNota;
        private System.Windows.Forms.MaskedTextBox mtxtDataSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValorNota;
        private System.Windows.Forms.TextBox txtValorProdu;
        private System.Windows.Forms.Label lblValorProdu;
        private System.Windows.Forms.TextBox txtValorNota;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQtCaixa;
        private System.Windows.Forms.Label lblQtCaixa;
        private System.Windows.Forms.Label lblTransp;
        private System.Windows.Forms.ComboBox comboTransp;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblSalvo;
    }
}