namespace ProjetoLagune
{
    partial class FrmCadastroFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFornecedores));
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.lblNomeFantasiaFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.grpbNome = new System.Windows.Forms.GroupBox();
            this.grpbEndereco = new System.Windows.Forms.GroupBox();
            this.txtEstadoForn = new System.Windows.Forms.TextBox();
            this.lblEstadoForn = new System.Windows.Forms.Label();
            this.mtxtCEPForn = new System.Windows.Forms.MaskedTextBox();
            this.txtComplForn = new System.Windows.Forms.TextBox();
            this.lblComplementoForn = new System.Windows.Forms.Label();
            this.comboUFForn = new System.Windows.Forms.ComboBox();
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCelForn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtTelForn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtCNPJForn = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJForn = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblCadForn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblLimparTela = new System.Windows.Forms.Label();
            this.pbLimparTela = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpbNome.SuspendLayout();
            this.grpbEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNomeFornecedor.Location = new System.Drawing.Point(9, 20);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(51, 18);
            this.lblNomeFornecedor.TabIndex = 1;
            this.lblNomeFornecedor.Text = "Nome:";
            // 
            // lblNomeFantasiaFornecedor
            // 
            this.lblNomeFantasiaFornecedor.AutoSize = true;
            this.lblNomeFantasiaFornecedor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNomeFantasiaFornecedor.Location = new System.Drawing.Point(9, 52);
            this.lblNomeFantasiaFornecedor.Name = "lblNomeFantasiaFornecedor";
            this.lblNomeFantasiaFornecedor.Size = new System.Drawing.Size(111, 18);
            this.lblNomeFantasiaFornecedor.TabIndex = 2;
            this.lblNomeFantasiaFornecedor.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasiaFornecedor
            // 
            this.txtNomeFantasiaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFantasiaFornecedor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNomeFantasiaFornecedor.Location = new System.Drawing.Point(125, 49);
            this.txtNomeFantasiaFornecedor.MaxLength = 255;
            this.txtNomeFantasiaFornecedor.Name = "txtNomeFantasiaFornecedor";
            this.txtNomeFantasiaFornecedor.Size = new System.Drawing.Size(706, 25);
            this.txtNomeFantasiaFornecedor.TabIndex = 1;
            // 
            // grpbNome
            // 
            this.grpbNome.Controls.Add(this.txtNome);
            this.grpbNome.Controls.Add(this.txtNomeFantasiaFornecedor);
            this.grpbNome.Controls.Add(this.lblNomeFantasiaFornecedor);
            this.grpbNome.Controls.Add(this.lblNomeFornecedor);
            this.grpbNome.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNome.Location = new System.Drawing.Point(12, 24);
            this.grpbNome.Name = "grpbNome";
            this.grpbNome.Size = new System.Drawing.Size(837, 85);
            this.grpbNome.TabIndex = 0;
            this.grpbNome.TabStop = false;
            this.grpbNome.Text = "Nome";
            // 
            // grpbEndereco
            // 
            this.grpbEndereco.Controls.Add(this.txtEstadoForn);
            this.grpbEndereco.Controls.Add(this.lblEstadoForn);
            this.grpbEndereco.Controls.Add(this.mtxtCEPForn);
            this.grpbEndereco.Controls.Add(this.txtComplForn);
            this.grpbEndereco.Controls.Add(this.lblComplementoForn);
            this.grpbEndereco.Controls.Add(this.comboUFForn);
            this.grpbEndereco.Controls.Add(this.lblUFForn);
            this.grpbEndereco.Controls.Add(this.lblCidadeForn);
            this.grpbEndereco.Controls.Add(this.txtCidadeForn);
            this.grpbEndereco.Controls.Add(this.lblCEPForn);
            this.grpbEndereco.Controls.Add(this.txtNumeroForn);
            this.grpbEndereco.Controls.Add(this.txtBairroForn);
            this.grpbEndereco.Controls.Add(this.txtLogradouroForn);
            this.grpbEndereco.Controls.Add(this.lblNumeroForn);
            this.grpbEndereco.Controls.Add(this.lblBairroForn);
            this.grpbEndereco.Controls.Add(this.lblLogradouroForn);
            this.grpbEndereco.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbEndereco.Location = new System.Drawing.Point(12, 115);
            this.grpbEndereco.Name = "grpbEndereco";
            this.grpbEndereco.Size = new System.Drawing.Size(837, 278);
            this.grpbEndereco.TabIndex = 1;
            this.grpbEndereco.TabStop = false;
            this.grpbEndereco.Text = "Endereço";
            // 
            // txtEstadoForn
            // 
            this.txtEstadoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtEstadoForn.Location = new System.Drawing.Point(113, 206);
            this.txtEstadoForn.MaxLength = 100;
            this.txtEstadoForn.Name = "txtEstadoForn";
            this.txtEstadoForn.Size = new System.Drawing.Size(276, 25);
            this.txtEstadoForn.TabIndex = 6;
            // 
            // lblEstadoForn
            // 
            this.lblEstadoForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoForn.AutoSize = true;
            this.lblEstadoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEstadoForn.Location = new System.Drawing.Point(9, 209);
            this.lblEstadoForn.Name = "lblEstadoForn";
            this.lblEstadoForn.Size = new System.Drawing.Size(57, 18);
            this.lblEstadoForn.TabIndex = 18;
            this.lblEstadoForn.Text = "Estado:";
            // 
            // mtxtCEPForn
            // 
            this.mtxtCEPForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtCEPForn.Location = new System.Drawing.Point(113, 175);
            this.mtxtCEPForn.Mask = "00000-000";
            this.mtxtCEPForn.Name = "mtxtCEPForn";
            this.mtxtCEPForn.Size = new System.Drawing.Size(89, 25);
            this.mtxtCEPForn.TabIndex = 5;
            this.mtxtCEPForn.Click += new System.EventHandler(this.mtxtCEPForn_Click);
            // 
            // txtComplForn
            // 
            this.txtComplForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtComplForn.Location = new System.Drawing.Point(113, 113);
            this.txtComplForn.MaxLength = 100;
            this.txtComplForn.Name = "txtComplForn";
            this.txtComplForn.Size = new System.Drawing.Size(357, 25);
            this.txtComplForn.TabIndex = 3;
            // 
            // lblComplementoForn
            // 
            this.lblComplementoForn.AutoSize = true;
            this.lblComplementoForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblComplementoForn.Location = new System.Drawing.Point(9, 116);
            this.lblComplementoForn.Name = "lblComplementoForn";
            this.lblComplementoForn.Size = new System.Drawing.Size(103, 18);
            this.lblComplementoForn.TabIndex = 16;
            this.lblComplementoForn.Text = "Complemento:";
            // 
            // comboUFForn
            // 
            this.comboUFForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUFForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboUFForn.FormattingEnabled = true;
            this.comboUFForn.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.comboUFForn.Location = new System.Drawing.Point(113, 237);
            this.comboUFForn.Name = "comboUFForn";
            this.comboUFForn.Size = new System.Drawing.Size(62, 26);
            this.comboUFForn.TabIndex = 7;
            // 
            // lblUFForn
            // 
            this.lblUFForn.AutoSize = true;
            this.lblUFForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblUFForn.Location = new System.Drawing.Point(9, 240);
            this.lblUFForn.Name = "lblUFForn";
            this.lblUFForn.Size = new System.Drawing.Size(28, 18);
            this.lblUFForn.TabIndex = 14;
            this.lblUFForn.Text = "UF:";
            // 
            // lblCidadeForn
            // 
            this.lblCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidadeForn.AutoSize = true;
            this.lblCidadeForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCidadeForn.Location = new System.Drawing.Point(9, 147);
            this.lblCidadeForn.Name = "lblCidadeForn";
            this.lblCidadeForn.Size = new System.Drawing.Size(56, 18);
            this.lblCidadeForn.TabIndex = 11;
            this.lblCidadeForn.Text = "Cidade:";
            // 
            // txtCidadeForn
            // 
            this.txtCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidadeForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtCidadeForn.Location = new System.Drawing.Point(113, 144);
            this.txtCidadeForn.MaxLength = 65;
            this.txtCidadeForn.Name = "txtCidadeForn";
            this.txtCidadeForn.Size = new System.Drawing.Size(357, 25);
            this.txtCidadeForn.TabIndex = 4;
            // 
            // lblCEPForn
            // 
            this.lblCEPForn.AutoSize = true;
            this.lblCEPForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCEPForn.Location = new System.Drawing.Point(9, 178);
            this.lblCEPForn.Name = "lblCEPForn";
            this.lblCEPForn.Size = new System.Drawing.Size(37, 18);
            this.lblCEPForn.TabIndex = 9;
            this.lblCEPForn.Text = "CEP:";
            // 
            // txtNumeroForn
            // 
            this.txtNumeroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNumeroForn.Location = new System.Drawing.Point(113, 82);
            this.txtNumeroForn.MaxLength = 55;
            this.txtNumeroForn.Name = "txtNumeroForn";
            this.txtNumeroForn.Size = new System.Drawing.Size(97, 25);
            this.txtNumeroForn.TabIndex = 2;
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtBairroForn.Location = new System.Drawing.Point(113, 51);
            this.txtBairroForn.MaxLength = 55;
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.Size = new System.Drawing.Size(276, 25);
            this.txtBairroForn.TabIndex = 1;
            // 
            // txtLogradouroForn
            // 
            this.txtLogradouroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLogradouroForn.Location = new System.Drawing.Point(113, 20);
            this.txtLogradouroForn.MaxLength = 255;
            this.txtLogradouroForn.Name = "txtLogradouroForn";
            this.txtLogradouroForn.Size = new System.Drawing.Size(465, 25);
            this.txtLogradouroForn.TabIndex = 0;
            // 
            // lblNumeroForn
            // 
            this.lblNumeroForn.AutoSize = true;
            this.lblNumeroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumeroForn.Location = new System.Drawing.Point(9, 85);
            this.lblNumeroForn.Name = "lblNumeroForn";
            this.lblNumeroForn.Size = new System.Drawing.Size(65, 18);
            this.lblNumeroForn.TabIndex = 6;
            this.lblNumeroForn.Text = "Número:";
            // 
            // lblBairroForn
            // 
            this.lblBairroForn.AutoSize = true;
            this.lblBairroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblBairroForn.Location = new System.Drawing.Point(9, 54);
            this.lblBairroForn.Name = "lblBairroForn";
            this.lblBairroForn.Size = new System.Drawing.Size(85, 18);
            this.lblBairroForn.TabIndex = 5;
            this.lblBairroForn.Text = "Bairro/Vila:";
            // 
            // lblLogradouroForn
            // 
            this.lblLogradouroForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouroForn.AutoSize = true;
            this.lblLogradouroForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLogradouroForn.Location = new System.Drawing.Point(9, 23);
            this.lblLogradouroForn.Name = "lblLogradouroForn";
            this.lblLogradouroForn.Size = new System.Drawing.Size(88, 18);
            this.lblLogradouroForn.TabIndex = 4;
            this.lblLogradouroForn.Text = "Logradouro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtCelForn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxtTelForn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxtCNPJForn);
            this.groupBox1.Controls.Add(this.lblCNPJForn);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtEmail.Location = new System.Drawing.Point(113, 113);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // mtxtCelForn
            // 
            this.mtxtCelForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtCelForn.Location = new System.Drawing.Point(113, 82);
            this.mtxtCelForn.Mask = "(00) 0-0000-0000";
            this.mtxtCelForn.Name = "mtxtCelForn";
            this.mtxtCelForn.Size = new System.Drawing.Size(112, 25);
            this.mtxtCelForn.TabIndex = 2;
            this.mtxtCelForn.Click += new System.EventHandler(this.mtxtCelForn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Celular:";
            // 
            // mtxtTelForn
            // 
            this.mtxtTelForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtTelForn.Location = new System.Drawing.Point(113, 51);
            this.mtxtTelForn.Mask = "(00) 0000-0000";
            this.mtxtTelForn.Name = "mtxtTelForn";
            this.mtxtTelForn.ShortcutsEnabled = false;
            this.mtxtTelForn.Size = new System.Drawing.Size(97, 25);
            this.mtxtTelForn.TabIndex = 1;
            this.mtxtTelForn.Click += new System.EventHandler(this.mtxtTelForn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefone:";
            // 
            // mtxtCNPJForn
            // 
            this.mtxtCNPJForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtCNPJForn.Location = new System.Drawing.Point(113, 20);
            this.mtxtCNPJForn.Mask = "00.000.000/0000-00";
            this.mtxtCNPJForn.Name = "mtxtCNPJForn";
            this.mtxtCNPJForn.Size = new System.Drawing.Size(145, 25);
            this.mtxtCNPJForn.TabIndex = 0;
            this.mtxtCNPJForn.Click += new System.EventHandler(this.mtxtCNPJForn_Click);
            // 
            // lblCNPJForn
            // 
            this.lblCNPJForn.AutoSize = true;
            this.lblCNPJForn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCNPJForn.Location = new System.Drawing.Point(9, 23);
            this.lblCNPJForn.Name = "lblCNPJForn";
            this.lblCNPJForn.Size = new System.Drawing.Size(47, 18);
            this.lblCNPJForn.TabIndex = 18;
            this.lblCNPJForn.Text = "CNPJ:";
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(836, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 17;
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
            this.btMin.Location = new System.Drawing.Point(811, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 18;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblCadForn
            // 
            this.lblCadForn.AutoSize = true;
            this.lblCadForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadForn.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblCadForn.ForeColor = System.Drawing.Color.DimGray;
            this.lblCadForn.Location = new System.Drawing.Point(9, 7);
            this.lblCadForn.Name = "lblCadForn";
            this.lblCadForn.Size = new System.Drawing.Size(187, 15);
            this.lblCadForn.TabIndex = 19;
            this.lblCadForn.Tag = "";
            this.lblCadForn.Text = "CADASTRO DE FORNECEDORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(773, 563);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 23;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(749, 557);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 22;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(652, 563);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 25;
            this.lblLimparTela.Text = "Limpar Tela";
            this.lblLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.lblLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.lblLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // pbLimparTela
            // 
            this.pbLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimparTela.Image = ((System.Drawing.Image)(resources.GetObject("pbLimparTela.Image")));
            this.pbLimparTela.Location = new System.Drawing.Point(643, 557);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 24;
            this.pbLimparTela.TabStop = false;
            this.pbLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.pbLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(35, 563);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 4;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(12, 557);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 27;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(141, 563);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 5;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(118, 557);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 30;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(224, 568);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 34;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNome.Location = new System.Drawing.Point(125, 17);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(706, 25);
            this.txtNome.TabIndex = 3;
            // 
            // FrmCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(861, 597);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCadForn);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbEndereco);
            this.Controls.Add(this.grpbNome);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.grpbNome.ResumeLayout(false);
            this.grpbNome.PerformLayout();
            this.grpbEndereco.ResumeLayout(false);
            this.grpbEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFantasiaFornecedor;
        private System.Windows.Forms.TextBox txtNomeFantasiaFornecedor;
        private System.Windows.Forms.GroupBox grpbNome;
        private System.Windows.Forms.GroupBox grpbEndereco;
        private System.Windows.Forms.ComboBox comboUFForn;
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
        private System.Windows.Forms.TextBox txtComplForn;
        private System.Windows.Forms.Label lblComplementoForn;
        private System.Windows.Forms.MaskedTextBox mtxtCEPForn;
        private System.Windows.Forms.TextBox txtEstadoForn;
        private System.Windows.Forms.Label lblEstadoForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJForn;
        private System.Windows.Forms.Label lblCNPJForn;
        private System.Windows.Forms.MaskedTextBox mtxtCelForn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtTelForn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblCadForn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.TextBox txtNome;
    }
}