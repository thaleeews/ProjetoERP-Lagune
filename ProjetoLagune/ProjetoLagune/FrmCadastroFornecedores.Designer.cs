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
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
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
            this.mtxtCelForn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtTelForn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCNPJForn = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJForn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpbNome.SuspendLayout();
            this.grpbEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Arial", 13F);
            this.txtNomeFornecedor.Location = new System.Drawing.Point(151, 19);
            this.txtNomeFornecedor.Multiline = true;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(969, 27);
            this.txtNomeFornecedor.TabIndex = 0;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Arial", 13F);
            this.lblNomeFornecedor.Location = new System.Drawing.Point(9, 25);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(62, 21);
            this.lblNomeFornecedor.TabIndex = 1;
            this.lblNomeFornecedor.Text = "Nome:";
            // 
            // lblNomeFantasiaFornecedor
            // 
            this.lblNomeFantasiaFornecedor.AutoSize = true;
            this.lblNomeFantasiaFornecedor.Font = new System.Drawing.Font("Arial", 13F);
            this.lblNomeFantasiaFornecedor.Location = new System.Drawing.Point(9, 77);
            this.lblNomeFantasiaFornecedor.Name = "lblNomeFantasiaFornecedor";
            this.lblNomeFantasiaFornecedor.Size = new System.Drawing.Size(136, 21);
            this.lblNomeFantasiaFornecedor.TabIndex = 2;
            this.lblNomeFantasiaFornecedor.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasiaFornecedor
            // 
            this.txtNomeFantasiaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFantasiaFornecedor.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasiaFornecedor.Location = new System.Drawing.Point(151, 71);
            this.txtNomeFantasiaFornecedor.Multiline = true;
            this.txtNomeFantasiaFornecedor.Name = "txtNomeFantasiaFornecedor";
            this.txtNomeFantasiaFornecedor.Size = new System.Drawing.Size(969, 27);
            this.txtNomeFantasiaFornecedor.TabIndex = 1;
            // 
            // grpbNome
            // 
            this.grpbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbNome.Controls.Add(this.txtNomeFantasiaFornecedor);
            this.grpbNome.Controls.Add(this.txtNomeFornecedor);
            this.grpbNome.Controls.Add(this.lblNomeFantasiaFornecedor);
            this.grpbNome.Controls.Add(this.lblNomeFornecedor);
            this.grpbNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNome.Location = new System.Drawing.Point(12, 12);
            this.grpbNome.Name = "grpbNome";
            this.grpbNome.Size = new System.Drawing.Size(1145, 121);
            this.grpbNome.TabIndex = 4;
            this.grpbNome.TabStop = false;
            this.grpbNome.Text = "Nome";
            // 
            // grpbEndereco
            // 
            this.grpbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpbEndereco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbEndereco.Location = new System.Drawing.Point(13, 140);
            this.grpbEndereco.Name = "grpbEndereco";
            this.grpbEndereco.Size = new System.Drawing.Size(1144, 231);
            this.grpbEndereco.TabIndex = 5;
            this.grpbEndereco.TabStop = false;
            this.grpbEndereco.Text = "Endereço";
            // 
            // txtEstadoForn
            // 
            this.txtEstadoForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtEstadoForn.Location = new System.Drawing.Point(706, 130);
            this.txtEstadoForn.Multiline = true;
            this.txtEstadoForn.Name = "txtEstadoForn";
            this.txtEstadoForn.Size = new System.Drawing.Size(276, 27);
            this.txtEstadoForn.TabIndex = 6;
            // 
            // lblEstadoForn
            // 
            this.lblEstadoForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoForn.AutoSize = true;
            this.lblEstadoForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblEstadoForn.Location = new System.Drawing.Point(613, 136);
            this.lblEstadoForn.Name = "lblEstadoForn";
            this.lblEstadoForn.Size = new System.Drawing.Size(71, 21);
            this.lblEstadoForn.TabIndex = 18;
            this.lblEstadoForn.Text = "Estado:";
            // 
            // mtxtCEPForn
            // 
            this.mtxtCEPForn.Font = new System.Drawing.Font("Arial", 13F);
            this.mtxtCEPForn.Location = new System.Drawing.Point(706, 78);
            this.mtxtCEPForn.Mask = "00000-000";
            this.mtxtCEPForn.Name = "mtxtCEPForn";
            this.mtxtCEPForn.Size = new System.Drawing.Size(89, 27);
            this.mtxtCEPForn.TabIndex = 5;
            this.mtxtCEPForn.Click += new System.EventHandler(this.mtxtCEPForn_Click);
            // 
            // txtComplForn
            // 
            this.txtComplForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtComplForn.Location = new System.Drawing.Point(150, 180);
            this.txtComplForn.Multiline = true;
            this.txtComplForn.Name = "txtComplForn";
            this.txtComplForn.Size = new System.Drawing.Size(409, 27);
            this.txtComplForn.TabIndex = 3;
            // 
            // lblComplementoForn
            // 
            this.lblComplementoForn.AutoSize = true;
            this.lblComplementoForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblComplementoForn.Location = new System.Drawing.Point(8, 186);
            this.lblComplementoForn.Name = "lblComplementoForn";
            this.lblComplementoForn.Size = new System.Drawing.Size(125, 21);
            this.lblComplementoForn.TabIndex = 16;
            this.lblComplementoForn.Text = "Complemento:";
            // 
            // comboUFForn
            // 
            this.comboUFForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUFForn.Font = new System.Drawing.Font("Arial", 13F);
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
            "TO"});
            this.comboUFForn.Location = new System.Drawing.Point(706, 180);
            this.comboUFForn.Name = "comboUFForn";
            this.comboUFForn.Size = new System.Drawing.Size(62, 27);
            this.comboUFForn.TabIndex = 7;
            // 
            // lblUFForn
            // 
            this.lblUFForn.AutoSize = true;
            this.lblUFForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblUFForn.Location = new System.Drawing.Point(613, 186);
            this.lblUFForn.Name = "lblUFForn";
            this.lblUFForn.Size = new System.Drawing.Size(39, 21);
            this.lblUFForn.TabIndex = 14;
            this.lblUFForn.Text = "UF:";
            // 
            // lblCidadeForn
            // 
            this.lblCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidadeForn.AutoSize = true;
            this.lblCidadeForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblCidadeForn.Location = new System.Drawing.Point(613, 32);
            this.lblCidadeForn.Name = "lblCidadeForn";
            this.lblCidadeForn.Size = new System.Drawing.Size(72, 21);
            this.lblCidadeForn.TabIndex = 11;
            this.lblCidadeForn.Text = "Cidade:";
            // 
            // txtCidadeForn
            // 
            this.txtCidadeForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidadeForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtCidadeForn.Location = new System.Drawing.Point(706, 26);
            this.txtCidadeForn.Multiline = true;
            this.txtCidadeForn.Name = "txtCidadeForn";
            this.txtCidadeForn.Size = new System.Drawing.Size(413, 27);
            this.txtCidadeForn.TabIndex = 4;
            // 
            // lblCEPForn
            // 
            this.lblCEPForn.AutoSize = true;
            this.lblCEPForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblCEPForn.Location = new System.Drawing.Point(613, 84);
            this.lblCEPForn.Name = "lblCEPForn";
            this.lblCEPForn.Size = new System.Drawing.Size(52, 21);
            this.lblCEPForn.TabIndex = 9;
            this.lblCEPForn.Text = "CEP:";
            // 
            // txtNumeroForn
            // 
            this.txtNumeroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtNumeroForn.Location = new System.Drawing.Point(150, 130);
            this.txtNumeroForn.Multiline = true;
            this.txtNumeroForn.Name = "txtNumeroForn";
            this.txtNumeroForn.Size = new System.Drawing.Size(97, 27);
            this.txtNumeroForn.TabIndex = 2;
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtBairroForn.Location = new System.Drawing.Point(150, 78);
            this.txtBairroForn.Multiline = true;
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.Size = new System.Drawing.Size(276, 27);
            this.txtBairroForn.TabIndex = 1;
            // 
            // txtLogradouroForn
            // 
            this.txtLogradouroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.txtLogradouroForn.Location = new System.Drawing.Point(150, 26);
            this.txtLogradouroForn.Multiline = true;
            this.txtLogradouroForn.Name = "txtLogradouroForn";
            this.txtLogradouroForn.Size = new System.Drawing.Size(409, 27);
            this.txtLogradouroForn.TabIndex = 0;
            // 
            // lblNumeroForn
            // 
            this.lblNumeroForn.AutoSize = true;
            this.lblNumeroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblNumeroForn.Location = new System.Drawing.Point(8, 136);
            this.lblNumeroForn.Name = "lblNumeroForn";
            this.lblNumeroForn.Size = new System.Drawing.Size(78, 21);
            this.lblNumeroForn.TabIndex = 6;
            this.lblNumeroForn.Text = "Número:";
            // 
            // lblBairroForn
            // 
            this.lblBairroForn.AutoSize = true;
            this.lblBairroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblBairroForn.Location = new System.Drawing.Point(8, 84);
            this.lblBairroForn.Name = "lblBairroForn";
            this.lblBairroForn.Size = new System.Drawing.Size(97, 21);
            this.lblBairroForn.TabIndex = 5;
            this.lblBairroForn.Text = "Bairro/Vila:";
            // 
            // lblLogradouroForn
            // 
            this.lblLogradouroForn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouroForn.AutoSize = true;
            this.lblLogradouroForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblLogradouroForn.Location = new System.Drawing.Point(8, 32);
            this.lblLogradouroForn.Name = "lblLogradouroForn";
            this.lblLogradouroForn.Size = new System.Drawing.Size(107, 21);
            this.lblLogradouroForn.TabIndex = 4;
            this.lblLogradouroForn.Text = "Logradouro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCelForn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxtTelForn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtCNPJForn);
            this.groupBox1.Controls.Add(this.lblCNPJForn);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // mtxtCelForn
            // 
            this.mtxtCelForn.Font = new System.Drawing.Font("Arial", 13F);
            this.mtxtCelForn.Location = new System.Drawing.Point(150, 199);
            this.mtxtCelForn.Mask = "(00) 0-0000-0000";
            this.mtxtCelForn.Name = "mtxtCelForn";
            this.mtxtCelForn.Size = new System.Drawing.Size(144, 27);
            this.mtxtCelForn.TabIndex = 3;
            this.mtxtCelForn.Click += new System.EventHandler(this.mtxtCelForn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F);
            this.label3.Location = new System.Drawing.Point(8, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Celular:";
            // 
            // mtxtTelForn
            // 
            this.mtxtTelForn.Font = new System.Drawing.Font("Arial", 13F);
            this.mtxtTelForn.Location = new System.Drawing.Point(150, 143);
            this.mtxtTelForn.Mask = "(00) 0000-0000";
            this.mtxtTelForn.Name = "mtxtTelForn";
            this.mtxtTelForn.ShortcutsEnabled = false;
            this.mtxtTelForn.Size = new System.Drawing.Size(129, 27);
            this.mtxtTelForn.TabIndex = 2;
            this.mtxtTelForn.Click += new System.EventHandler(this.mtxtTelForn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F);
            this.label2.Location = new System.Drawing.Point(8, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefone:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 13F);
            this.textBox1.Location = new System.Drawing.Point(150, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bairro/Vila:";
            // 
            // mtxtCNPJForn
            // 
            this.mtxtCNPJForn.Font = new System.Drawing.Font("Arial", 13F);
            this.mtxtCNPJForn.Location = new System.Drawing.Point(150, 37);
            this.mtxtCNPJForn.Mask = "00.000.000/0000-00";
            this.mtxtCNPJForn.Name = "mtxtCNPJForn";
            this.mtxtCNPJForn.Size = new System.Drawing.Size(158, 27);
            this.mtxtCNPJForn.TabIndex = 0;
            this.mtxtCNPJForn.Click += new System.EventHandler(this.mtxtCNPJForn_Click);
            // 
            // lblCNPJForn
            // 
            this.lblCNPJForn.AutoSize = true;
            this.lblCNPJForn.Font = new System.Drawing.Font("Arial", 13F);
            this.lblCNPJForn.Location = new System.Drawing.Point(8, 43);
            this.lblCNPJForn.Name = "lblCNPJForn";
            this.lblCNPJForn.Size = new System.Drawing.Size(62, 21);
            this.lblCNPJForn.TabIndex = 18;
            this.lblCNPJForn.Text = "CNPJ:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13F);
            this.button1.Location = new System.Drawing.Point(25, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13F);
            this.button2.Location = new System.Drawing.Point(163, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salvar Alteração";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 13F);
            this.button3.Location = new System.Drawing.Point(359, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 719);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbEndereco);
            this.Controls.Add(this.grpbNome);
            this.Name = "FrmCadastroFornecedores";
            this.Text = "Sistema Lagune";
            this.grpbNome.ResumeLayout(false);
            this.grpbNome.PerformLayout();
            this.grpbEndereco.ResumeLayout(false);
            this.grpbEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFornecedor;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}