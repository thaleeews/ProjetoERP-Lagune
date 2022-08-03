namespace ProjetoLagune.Pedidos
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.grpbDados = new System.Windows.Forms.GroupBox();
            this.cbNumPedido = new ProjetoLagune.Controls.ComboAuto();
            this.rdPAcaba = new System.Windows.Forms.RadioButton();
            this.rdEmba = new System.Windows.Forms.RadioButton();
            this.rdMateria = new System.Windows.Forms.RadioButton();
            this.cbArmazem = new ProjetoLagune.Controls.ComboAuto();
            this.cbFornecedor = new ProjetoLagune.Controls.ComboAuto();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.grpbProdutos = new System.Windows.Forms.GroupBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.cbNomeProduto = new ProjetoLagune.Controls.ComboAuto();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtIPI = new System.Windows.Forms.TextBox();
            this.lblIPI = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValorU = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNomedoProd = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.coluna1Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4ValorUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna6IPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.pbHistorico = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.pbImprimir = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.grpbDados.SuspendLayout();
            this.grpbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblFornecedor.Location = new System.Drawing.Point(6, 54);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(85, 18);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // grpbDados
            // 
            this.grpbDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grpbDados.Controls.Add(this.cbNumPedido);
            this.grpbDados.Controls.Add(this.rdPAcaba);
            this.grpbDados.Controls.Add(this.rdEmba);
            this.grpbDados.Controls.Add(this.rdMateria);
            this.grpbDados.Controls.Add(this.cbArmazem);
            this.grpbDados.Controls.Add(this.cbFornecedor);
            this.grpbDados.Controls.Add(this.lblNumPedido);
            this.grpbDados.Controls.Add(this.lblArmazem);
            this.grpbDados.Controls.Add(this.lblFornecedor);
            this.grpbDados.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDados.Location = new System.Drawing.Point(13, 28);
            this.grpbDados.Name = "grpbDados";
            this.grpbDados.Size = new System.Drawing.Size(869, 130);
            this.grpbDados.TabIndex = 0;
            this.grpbDados.TabStop = false;
            this.grpbDados.Text = "Dados";
            // 
            // cbNumPedido
            // 
            this.cbNumPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumPedido.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNumPedido.FormattingEnabled = true;
            this.cbNumPedido.LimitToList = true;
            this.cbNumPedido.Location = new System.Drawing.Point(141, 19);
            this.cbNumPedido.Name = "cbNumPedido";
            this.cbNumPedido.Size = new System.Drawing.Size(121, 26);
            this.cbNumPedido.TabIndex = 0;
            // 
            // rdPAcaba
            // 
            this.rdPAcaba.AutoSize = true;
            this.rdPAcaba.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdPAcaba.Location = new System.Drawing.Point(505, 21);
            this.rdPAcaba.Name = "rdPAcaba";
            this.rdPAcaba.Size = new System.Drawing.Size(138, 22);
            this.rdPAcaba.TabIndex = 5;
            this.rdPAcaba.TabStop = true;
            this.rdPAcaba.Text = "Produto Acabado";
            this.rdPAcaba.UseVisualStyleBackColor = true;
            this.rdPAcaba.CheckedChanged += new System.EventHandler(this.rdPAcaba_CheckedChanged);
            // 
            // rdEmba
            // 
            this.rdEmba.AutoSize = true;
            this.rdEmba.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdEmba.Location = new System.Drawing.Point(394, 21);
            this.rdEmba.Name = "rdEmba";
            this.rdEmba.Size = new System.Drawing.Size(105, 22);
            this.rdEmba.TabIndex = 4;
            this.rdEmba.TabStop = true;
            this.rdEmba.Text = "Embalagem";
            this.rdEmba.UseVisualStyleBackColor = true;
            this.rdEmba.CheckedChanged += new System.EventHandler(this.rdEmba_CheckedChanged);
            // 
            // rdMateria
            // 
            this.rdMateria.AutoSize = true;
            this.rdMateria.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdMateria.Location = new System.Drawing.Point(268, 21);
            this.rdMateria.Name = "rdMateria";
            this.rdMateria.Size = new System.Drawing.Size(120, 22);
            this.rdMateria.TabIndex = 3;
            this.rdMateria.TabStop = true;
            this.rdMateria.Text = "Matéria Prima";
            this.rdMateria.UseVisualStyleBackColor = true;
            this.rdMateria.CheckedChanged += new System.EventHandler(this.rdMateria_CheckedChanged);
            // 
            // cbArmazem
            // 
            this.cbArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbArmazem.FormattingEnabled = true;
            this.cbArmazem.LimitToList = true;
            this.cbArmazem.Location = new System.Drawing.Point(141, 83);
            this.cbArmazem.MaxLength = 100;
            this.cbArmazem.Name = "cbArmazem";
            this.cbArmazem.Size = new System.Drawing.Size(721, 26);
            this.cbArmazem.TabIndex = 2;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.LimitToList = true;
            this.cbFornecedor.Location = new System.Drawing.Point(141, 51);
            this.cbFornecedor.MaxLength = 255;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(721, 26);
            this.cbFornecedor.TabIndex = 1;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumPedido.Location = new System.Drawing.Point(6, 23);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(131, 18);
            this.lblNumPedido.TabIndex = 4;
            this.lblNumPedido.Text = "Número do Pedido:";
            // 
            // lblArmazem
            // 
            this.lblArmazem.AutoSize = true;
            this.lblArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblArmazem.Location = new System.Drawing.Point(6, 86);
            this.lblArmazem.Name = "lblArmazem";
            this.lblArmazem.Size = new System.Drawing.Size(76, 18);
            this.lblArmazem.TabIndex = 2;
            this.lblArmazem.Text = "Armazém:";
            // 
            // grpbProdutos
            // 
            this.grpbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grpbProdutos.Controls.Add(this.lblExcluir);
            this.grpbProdutos.Controls.Add(this.pbExcluir);
            this.grpbProdutos.Controls.Add(this.lblEditar);
            this.grpbProdutos.Controls.Add(this.pbEditar);
            this.grpbProdutos.Controls.Add(this.lblAdicionar);
            this.grpbProdutos.Controls.Add(this.cbNomeProduto);
            this.grpbProdutos.Controls.Add(this.pbAdicionar);
            this.grpbProdutos.Controls.Add(this.txtValorTotal);
            this.grpbProdutos.Controls.Add(this.lblValorTotal);
            this.grpbProdutos.Controls.Add(this.txtIPI);
            this.grpbProdutos.Controls.Add(this.lblIPI);
            this.grpbProdutos.Controls.Add(this.cbUnidade);
            this.grpbProdutos.Controls.Add(this.lblUnidade);
            this.grpbProdutos.Controls.Add(this.txtValorUnitario);
            this.grpbProdutos.Controls.Add(this.txtQuantidade);
            this.grpbProdutos.Controls.Add(this.lblValorU);
            this.grpbProdutos.Controls.Add(this.lblQuantidade);
            this.grpbProdutos.Controls.Add(this.lblNomedoProd);
            this.grpbProdutos.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProdutos.Location = new System.Drawing.Point(12, 164);
            this.grpbProdutos.Name = "grpbProdutos";
            this.grpbProdutos.Size = new System.Drawing.Size(869, 162);
            this.grpbProdutos.TabIndex = 1;
            this.grpbProdutos.TabStop = false;
            this.grpbProdutos.Text = "Produtos";
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(241, 127);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 7;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btRemover_Click);
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(218, 121);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 37;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.btRemover_Click);
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(137, 127);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 6;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(112, 121);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 35;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.pbEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.pbEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.AutoSize = true;
            this.lblAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdicionar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblAdicionar.Location = new System.Drawing.Point(20, 127);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(73, 22);
            this.lblAdicionar.TabIndex = 5;
            this.lblAdicionar.Text = "Adicionar";
            this.lblAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.lblAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.lblAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // cbNomeProduto
            // 
            this.cbNomeProduto.Enabled = false;
            this.cbNomeProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNomeProduto.FormattingEnabled = true;
            this.cbNomeProduto.LimitToList = true;
            this.cbNomeProduto.Location = new System.Drawing.Point(134, 20);
            this.cbNomeProduto.MaxLength = 255;
            this.cbNomeProduto.Name = "cbNomeProduto";
            this.cbNomeProduto.Size = new System.Drawing.Size(729, 26);
            this.cbNomeProduto.TabIndex = 0;
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(6, 121);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionar.TabIndex = 33;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.pbAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.pbAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(308, 83);
            this.txtValorTotal.MaxLength = 100;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(177, 25);
            this.txtValorTotal.TabIndex = 13;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Enabled = false;
            this.lblValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorTotal.Location = new System.Drawing.Point(216, 86);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(80, 18);
            this.lblValorTotal.TabIndex = 18;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtIPI
            // 
            this.txtIPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIPI.Enabled = false;
            this.txtIPI.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtIPI.Location = new System.Drawing.Point(134, 83);
            this.txtIPI.Name = "txtIPI";
            this.txtIPI.Size = new System.Drawing.Size(76, 25);
            this.txtIPI.TabIndex = 2;
            this.txtIPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPI_KeyPress);
            // 
            // lblIPI
            // 
            this.lblIPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblIPI.AutoSize = true;
            this.lblIPI.Enabled = false;
            this.lblIPI.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblIPI.Location = new System.Drawing.Point(7, 86);
            this.lblIPI.Name = "lblIPI";
            this.lblIPI.Size = new System.Drawing.Size(28, 18);
            this.lblIPI.TabIndex = 15;
            this.lblIPI.Text = "IPI:";
            // 
            // cbUnidade
            // 
            this.cbUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.Enabled = false;
            this.cbUnidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "KG\t",
            "G",
            "PÇ",
            "L",
            "mL",
            ""});
            this.cbUnidade.Location = new System.Drawing.Point(134, 52);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(76, 26);
            this.cbUnidade.TabIndex = 1;
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Enabled = false;
            this.lblUnidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblUnidade.Location = new System.Drawing.Point(6, 55);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(65, 18);
            this.lblUnidade.TabIndex = 11;
            this.lblUnidade.Text = "Unidade:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorUnitario.Location = new System.Drawing.Point(593, 52);
            this.txtValorUnitario.MaxLength = 20;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(210, 25);
            this.txtValorUnitario.TabIndex = 4;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(308, 52);
            this.txtQuantidade.MaxLength = 20;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(177, 25);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.WordWrap = false;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblValorU
            // 
            this.lblValorU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorU.AutoSize = true;
            this.lblValorU.Enabled = false;
            this.lblValorU.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorU.Location = new System.Drawing.Point(491, 55);
            this.lblValorU.Name = "lblValorU";
            this.lblValorU.Size = new System.Drawing.Size(102, 18);
            this.lblValorU.TabIndex = 8;
            this.lblValorU.Text = "Valor Unitário:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Enabled = false;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(216, 55);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblNomedoProd
            // 
            this.lblNomedoProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomedoProd.AutoSize = true;
            this.lblNomedoProd.Enabled = false;
            this.lblNomedoProd.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNomedoProd.Location = new System.Drawing.Point(6, 23);
            this.lblNomedoProd.Name = "lblNomedoProd";
            this.lblNomedoProd.Size = new System.Drawing.Size(125, 18);
            this.lblNomedoProd.TabIndex = 6;
            this.lblNomedoProd.Text = "Nome do Produto:";
            // 
            // listProdutos
            // 
            this.listProdutos.CheckBoxes = true;
            this.listProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Nome,
            this.coluna2Unidade,
            this.coluna3Quantidade,
            this.coluna4ValorUnit,
            this.coluna5ValorTotal,
            this.coluna6IPI});
            this.listProdutos.Enabled = false;
            this.listProdutos.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listProdutos.FullRowSelect = true;
            this.listProdutos.Location = new System.Drawing.Point(12, 332);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(870, 239);
            this.listProdutos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProdutos.TabIndex = 2;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.View = System.Windows.Forms.View.Details;
            this.listProdutos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listProdutos_ItemCheck);
            this.listProdutos.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listProdutos_ItemChecked);
            this.listProdutos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listProdutos_ItemSelectionChanged);
            // 
            // coluna1Nome
            // 
            this.coluna1Nome.Text = "Nome do Produto";
            this.coluna1Nome.Width = 340;
            // 
            // coluna2Unidade
            // 
            this.coluna2Unidade.Text = "UN";
            this.coluna2Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2Unidade.Width = 40;
            // 
            // coluna3Quantidade
            // 
            this.coluna3Quantidade.Text = "Quantidade";
            this.coluna3Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Quantidade.Width = 110;
            // 
            // coluna4ValorUnit
            // 
            this.coluna4ValorUnit.Text = "Valor Unitário";
            this.coluna4ValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4ValorUnit.Width = 120;
            // 
            // coluna5ValorTotal
            // 
            this.coluna5ValorTotal.Text = "Valor Total";
            this.coluna5ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna5ValorTotal.Width = 140;
            // 
            // coluna6IPI
            // 
            this.coluna6IPI.Text = "IPI (%)";
            this.coluna6IPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(870, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 23;
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
            this.btMin.Location = new System.Drawing.Point(845, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 24;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPedido.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblPedido.ForeColor = System.Drawing.Color.DimGray;
            this.lblPedido.Location = new System.Drawing.Point(9, 7);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(164, 15);
            this.lblPedido.TabIndex = 25;
            this.lblPedido.Tag = "";
            this.lblPedido.Text = "NOVO PEDIDO DE COMPRA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(806, 583);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 6;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(782, 577);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 24;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistorico.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblHistorico.Location = new System.Drawing.Point(691, 583);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(70, 22);
            this.lblHistorico.TabIndex = 5;
            this.lblHistorico.Text = "Histórico";
            this.lblHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            this.lblHistorico.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.lblHistorico.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // pbHistorico
            // 
            this.pbHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHistorico.Image = ((System.Drawing.Image)(resources.GetObject("pbHistorico.Image")));
            this.pbHistorico.Location = new System.Drawing.Point(676, 577);
            this.pbHistorico.Name = "pbHistorico";
            this.pbHistorico.Size = new System.Drawing.Size(100, 35);
            this.pbHistorico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistorico.TabIndex = 27;
            this.pbHistorico.TabStop = false;
            this.pbHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            this.pbHistorico.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbHistorico.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(36, 583);
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
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(13, 577);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 29;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImprimir.Enabled = false;
            this.lblImprimir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblImprimir.Location = new System.Drawing.Point(137, 583);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(65, 22);
            this.lblImprimir.TabIndex = 4;
            this.lblImprimir.Text = "Imprimir";
            this.lblImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.lblImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.lblImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // pbImprimir
            // 
            this.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImprimir.Enabled = false;
            this.pbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("pbImprimir.Image")));
            this.pbImprimir.Location = new System.Drawing.Point(119, 577);
            this.pbImprimir.Name = "pbImprimir";
            this.pbImprimir.Size = new System.Drawing.Size(100, 35);
            this.pbImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImprimir.TabIndex = 31;
            this.pbImprimir.TabStop = false;
            this.pbImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.pbImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.pbImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(225, 588);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 33;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(895, 620);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.pbImprimir);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.pbHistorico);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.grpbProdutos);
            this.Controls.Add(this.grpbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidos";
            this.Text = "Novo Pedido de Compra";
            this.grpbDados.ResumeLayout(false);
            this.grpbDados.PerformLayout();
            this.grpbProdutos.ResumeLayout(false);
            this.grpbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.GroupBox grpbDados;
        private System.Windows.Forms.Label lblArmazem;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.GroupBox grpbProdutos;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValorU;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNomedoProd;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.ColumnHeader coluna1Nome;
        private System.Windows.Forms.ColumnHeader coluna2Unidade;
        private System.Windows.Forms.ColumnHeader coluna3Quantidade;
        private System.Windows.Forms.ColumnHeader coluna4ValorUnit;
        private System.Windows.Forms.TextBox txtIPI;
        private System.Windows.Forms.Label lblIPI;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ColumnHeader coluna5ValorTotal;
        private System.Windows.Forms.ColumnHeader coluna6IPI;
        private Controls.ComboAuto cbArmazem;
        private Controls.ComboAuto cbFornecedor;
        private Controls.ComboAuto cbNomeProduto;
        private System.Windows.Forms.RadioButton rdPAcaba;
        private System.Windows.Forms.RadioButton rdEmba;
        private System.Windows.Forms.RadioButton rdMateria;
        private Controls.ComboAuto cbNumPedido;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.PictureBox pbHistorico;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.PictureBox pbImprimir;
        private System.Windows.Forms.Label lblSalvo;
    }
}