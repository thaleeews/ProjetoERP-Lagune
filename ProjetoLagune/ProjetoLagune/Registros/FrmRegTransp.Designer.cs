namespace ProjetoLagune.Registros
{
    partial class FrmRegTransp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegTransp));
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtEstadoForn = new System.Windows.Forms.TextBox();
            this.lblEstadoForn = new System.Windows.Forms.Label();
            this.mtxtCEPForn = new System.Windows.Forms.MaskedTextBox();
            this.txtComplForn = new System.Windows.Forms.TextBox();
            this.lblComplementoForn = new System.Windows.Forms.Label();
            this.cbUFForn = new System.Windows.Forms.ComboBox();
            this.lblUFForn = new System.Windows.Forms.Label();
            this.lblCidadeForn = new System.Windows.Forms.Label();
            this.txtCidadeForn = new System.Windows.Forms.TextBox();
            this.lblCEPForn = new System.Windows.Forms.Label();
            this.txtNumeroForn = new System.Windows.Forms.TextBox();
            this.txtBairroForn = new System.Windows.Forms.TextBox();
            this.txtLogradouroForn = new System.Windows.Forms.TextBox();
            this.lblNumeroForn = new System.Windows.Forms.Label();
            this.lblBairroForn = new System.Windows.Forms.Label();
            this.lblLogradouroForn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAuto1 = new ProjetoLagune.Controls.ComboAuto();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(38, 435);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 51;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(13, 429);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 53;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.pbEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.pbEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(533, 435);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 47;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(509, 429);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 46;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtTel);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.lblCNPJ);
            this.groupBox2.Controls.Add(this.mtxtCNPJ);
            this.groupBox2.Controls.Add(this.txtEstadoForn);
            this.groupBox2.Controls.Add(this.lblEstadoForn);
            this.groupBox2.Controls.Add(this.mtxtCEPForn);
            this.groupBox2.Controls.Add(this.txtComplForn);
            this.groupBox2.Controls.Add(this.lblComplementoForn);
            this.groupBox2.Controls.Add(this.cbUFForn);
            this.groupBox2.Controls.Add(this.lblUFForn);
            this.groupBox2.Controls.Add(this.lblCidadeForn);
            this.groupBox2.Controls.Add(this.txtCidadeForn);
            this.groupBox2.Controls.Add(this.lblCEPForn);
            this.groupBox2.Controls.Add(this.txtNumeroForn);
            this.groupBox2.Controls.Add(this.txtBairroForn);
            this.groupBox2.Controls.Add(this.txtLogradouroForn);
            this.groupBox2.Controls.Add(this.lblNumeroForn);
            this.groupBox2.Controls.Add(this.lblBairroForn);
            this.groupBox2.Controls.Add(this.lblLogradouroForn);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 335);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtTel.Location = new System.Drawing.Point(109, 300);
            this.mtxtTel.Mask = "(00) 0000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.ReadOnly = true;
            this.mtxtTel.ShortcutsEnabled = false;
            this.mtxtTel.Size = new System.Drawing.Size(110, 25);
            this.mtxtTel.TabIndex = 35;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblTelefone.Location = new System.Drawing.Point(6, 303);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 36;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCNPJ.Location = new System.Drawing.Point(6, 272);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(47, 18);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtCNPJ.Location = new System.Drawing.Point(109, 269);
            this.mtxtCNPJ.Mask = "00.000.000/0000-00";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.ReadOnly = true;
            this.mtxtCNPJ.Size = new System.Drawing.Size(140, 25);
            this.mtxtCNPJ.TabIndex = 0;
            // 
            // txtEstadoForn
            // 
            this.txtEstadoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtEstadoForn.Location = new System.Drawing.Point(109, 206);
            this.txtEstadoForn.MaxLength = 100;
            this.txtEstadoForn.Name = "txtEstadoForn";
            this.txtEstadoForn.ReadOnly = true;
            this.txtEstadoForn.Size = new System.Drawing.Size(276, 25);
            this.txtEstadoForn.TabIndex = 27;
            // 
            // lblEstadoForn
            // 
            this.lblEstadoForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoForn.AutoSize = true;
            this.lblEstadoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEstadoForn.Location = new System.Drawing.Point(5, 209);
            this.lblEstadoForn.Name = "lblEstadoForn";
            this.lblEstadoForn.Size = new System.Drawing.Size(57, 18);
            this.lblEstadoForn.TabIndex = 34;
            this.lblEstadoForn.Text = "Estado:";
            // 
            // mtxtCEPForn
            // 
            this.mtxtCEPForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtCEPForn.Location = new System.Drawing.Point(109, 175);
            this.mtxtCEPForn.Mask = "00000-000";
            this.mtxtCEPForn.Name = "mtxtCEPForn";
            this.mtxtCEPForn.ReadOnly = true;
            this.mtxtCEPForn.Size = new System.Drawing.Size(89, 25);
            this.mtxtCEPForn.TabIndex = 25;
            // 
            // txtComplForn
            // 
            this.txtComplForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtComplForn.Location = new System.Drawing.Point(109, 113);
            this.txtComplForn.MaxLength = 100;
            this.txtComplForn.Name = "txtComplForn";
            this.txtComplForn.ReadOnly = true;
            this.txtComplForn.Size = new System.Drawing.Size(357, 25);
            this.txtComplForn.TabIndex = 22;
            // 
            // lblComplementoForn
            // 
            this.lblComplementoForn.AutoSize = true;
            this.lblComplementoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblComplementoForn.Location = new System.Drawing.Point(5, 116);
            this.lblComplementoForn.Name = "lblComplementoForn";
            this.lblComplementoForn.Size = new System.Drawing.Size(103, 18);
            this.lblComplementoForn.TabIndex = 33;
            this.lblComplementoForn.Text = "Complemento:";
            // 
            // cbUFForn
            // 
            this.cbUFForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUFForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbUFForn.FormattingEnabled = true;
            this.cbUFForn.Location = new System.Drawing.Point(109, 237);
            this.cbUFForn.Name = "cbUFForn";
            this.cbUFForn.Size = new System.Drawing.Size(62, 26);
            this.cbUFForn.TabIndex = 29;
            // 
            // lblUFForn
            // 
            this.lblUFForn.AutoSize = true;
            this.lblUFForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblUFForn.Location = new System.Drawing.Point(5, 240);
            this.lblUFForn.Name = "lblUFForn";
            this.lblUFForn.Size = new System.Drawing.Size(28, 18);
            this.lblUFForn.TabIndex = 32;
            this.lblUFForn.Text = "UF:";
            // 
            // lblCidadeForn
            // 
            this.lblCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidadeForn.AutoSize = true;
            this.lblCidadeForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCidadeForn.Location = new System.Drawing.Point(5, 147);
            this.lblCidadeForn.Name = "lblCidadeForn";
            this.lblCidadeForn.Size = new System.Drawing.Size(56, 18);
            this.lblCidadeForn.TabIndex = 31;
            this.lblCidadeForn.Text = "Cidade:";
            // 
            // txtCidadeForn
            // 
            this.txtCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidadeForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtCidadeForn.Location = new System.Drawing.Point(109, 144);
            this.txtCidadeForn.MaxLength = 65;
            this.txtCidadeForn.Name = "txtCidadeForn";
            this.txtCidadeForn.ReadOnly = true;
            this.txtCidadeForn.Size = new System.Drawing.Size(357, 25);
            this.txtCidadeForn.TabIndex = 23;
            // 
            // lblCEPForn
            // 
            this.lblCEPForn.AutoSize = true;
            this.lblCEPForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCEPForn.Location = new System.Drawing.Point(5, 178);
            this.lblCEPForn.Name = "lblCEPForn";
            this.lblCEPForn.Size = new System.Drawing.Size(37, 18);
            this.lblCEPForn.TabIndex = 30;
            this.lblCEPForn.Text = "CEP:";
            // 
            // txtNumeroForn
            // 
            this.txtNumeroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNumeroForn.Location = new System.Drawing.Point(109, 82);
            this.txtNumeroForn.MaxLength = 55;
            this.txtNumeroForn.Name = "txtNumeroForn";
            this.txtNumeroForn.ReadOnly = true;
            this.txtNumeroForn.Size = new System.Drawing.Size(97, 25);
            this.txtNumeroForn.TabIndex = 21;
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtBairroForn.Location = new System.Drawing.Point(109, 51);
            this.txtBairroForn.MaxLength = 55;
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.ReadOnly = true;
            this.txtBairroForn.Size = new System.Drawing.Size(289, 25);
            this.txtBairroForn.TabIndex = 20;
            // 
            // txtLogradouroForn
            // 
            this.txtLogradouroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLogradouroForn.Location = new System.Drawing.Point(109, 20);
            this.txtLogradouroForn.MaxLength = 255;
            this.txtLogradouroForn.Name = "txtLogradouroForn";
            this.txtLogradouroForn.ReadOnly = true;
            this.txtLogradouroForn.Size = new System.Drawing.Size(481, 25);
            this.txtLogradouroForn.TabIndex = 19;
            // 
            // lblNumeroForn
            // 
            this.lblNumeroForn.AutoSize = true;
            this.lblNumeroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumeroForn.Location = new System.Drawing.Point(5, 85);
            this.lblNumeroForn.Name = "lblNumeroForn";
            this.lblNumeroForn.Size = new System.Drawing.Size(65, 18);
            this.lblNumeroForn.TabIndex = 28;
            this.lblNumeroForn.Text = "Número:";
            // 
            // lblBairroForn
            // 
            this.lblBairroForn.AutoSize = true;
            this.lblBairroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblBairroForn.Location = new System.Drawing.Point(5, 54);
            this.lblBairroForn.Name = "lblBairroForn";
            this.lblBairroForn.Size = new System.Drawing.Size(85, 18);
            this.lblBairroForn.TabIndex = 26;
            this.lblBairroForn.Text = "Bairro/Vila:";
            // 
            // lblLogradouroForn
            // 
            this.lblLogradouroForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouroForn.AutoSize = true;
            this.lblLogradouroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLogradouroForn.Location = new System.Drawing.Point(6, 23);
            this.lblLogradouroForn.Name = "lblLogradouroForn";
            this.lblLogradouroForn.Size = new System.Drawing.Size(88, 18);
            this.lblLogradouroForn.TabIndex = 24;
            this.lblLogradouroForn.Text = "Logradouro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAuto1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 56);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // comboAuto1
            // 
            this.comboAuto1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboAuto1.FormattingEnabled = true;
            this.comboAuto1.LimitToList = true;
            this.comboAuto1.Location = new System.Drawing.Point(109, 19);
            this.comboAuto1.Name = "comboAuto1";
            this.comboAuto1.Size = new System.Drawing.Size(481, 26);
            this.comboAuto1.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNome.Location = new System.Drawing.Point(6, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 15);
            this.label3.TabIndex = 42;
            this.label3.Tag = "";
            this.label3.Text = "CADASTRO DE TRANSPORTADORAS";
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(571, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 40;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(596, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 41;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // FrmRegTransp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(621, 471);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegTransp";
            this.Text = "Registro de Transportadoras";
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.TextBox txtEstadoForn;
        private System.Windows.Forms.Label lblEstadoForn;
        private System.Windows.Forms.MaskedTextBox mtxtCEPForn;
        private System.Windows.Forms.TextBox txtComplForn;
        private System.Windows.Forms.Label lblComplementoForn;
        private System.Windows.Forms.ComboBox cbUFForn;
        private System.Windows.Forms.Label lblUFForn;
        private System.Windows.Forms.Label lblCidadeForn;
        private System.Windows.Forms.TextBox txtCidadeForn;
        private System.Windows.Forms.Label lblCEPForn;
        private System.Windows.Forms.TextBox txtNumeroForn;
        private System.Windows.Forms.TextBox txtBairroForn;
        private System.Windows.Forms.TextBox txtLogradouroForn;
        private System.Windows.Forms.Label lblNumeroForn;
        private System.Windows.Forms.Label lblBairroForn;
        private System.Windows.Forms.Label lblLogradouroForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private Controls.ComboAuto comboAuto1;
    }
}