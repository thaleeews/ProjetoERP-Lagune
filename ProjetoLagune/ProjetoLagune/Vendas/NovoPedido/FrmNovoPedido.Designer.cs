namespace ProjetoLagune.Vendas
{
    partial class FrmNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoPedido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRazao = new ProjetoLagune.Controls.ComboAuto();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.rdProd = new System.Windows.Forms.RadioButton();
            this.rdMat = new System.Windows.Forms.RadioButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rdEmb = new System.Windows.Forms.RadioButton();
            this.cbTabela = new System.Windows.Forms.ComboBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.comboEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.listProdutosV = new System.Windows.Forms.ListView();
            this.coluna1Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4ValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLimparTela = new System.Windows.Forms.Label();
            this.pbLimparTela = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.pbImprimir = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbRazao);
            this.groupBox1.Controls.Add(this.cbCodigo);
            this.groupBox1.Controls.Add(this.rdProd);
            this.groupBox1.Controls.Add(this.rdMat);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.rdEmb);
            this.groupBox1.Controls.Add(this.cbTabela);
            this.groupBox1.Controls.Add(this.lblTabela);
            this.groupBox1.Controls.Add(this.lblRazao);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // cbRazao
            // 
            this.cbRazao.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbRazao.FormattingEnabled = true;
            this.cbRazao.LimitToList = true;
            this.cbRazao.Location = new System.Drawing.Point(377, 24);
            this.cbRazao.MaxLength = 255;
            this.cbRazao.Name = "cbRazao";
            this.cbRazao.Size = new System.Drawing.Size(419, 26);
            this.cbRazao.TabIndex = 9;
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(68, 24);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(134, 26);
            this.cbCodigo.TabIndex = 8;
            // 
            // rdProd
            // 
            this.rdProd.AutoSize = true;
            this.rdProd.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdProd.Location = new System.Drawing.Point(658, 57);
            this.rdProd.Name = "rdProd";
            this.rdProd.Size = new System.Drawing.Size(138, 22);
            this.rdProd.TabIndex = 6;
            this.rdProd.TabStop = true;
            this.rdProd.Text = "Produto Acabado";
            this.rdProd.UseVisualStyleBackColor = true;
            // 
            // rdMat
            // 
            this.rdMat.AutoSize = true;
            this.rdMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdMat.Location = new System.Drawing.Point(532, 57);
            this.rdMat.Name = "rdMat";
            this.rdMat.Size = new System.Drawing.Size(120, 22);
            this.rdMat.TabIndex = 5;
            this.rdMat.TabStop = true;
            this.rdMat.Text = "Matéria Prima";
            this.rdMat.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(6, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // rdEmb
            // 
            this.rdEmb.AutoSize = true;
            this.rdEmb.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdEmb.Location = new System.Drawing.Point(421, 57);
            this.rdEmb.Name = "rdEmb";
            this.rdEmb.Size = new System.Drawing.Size(105, 22);
            this.rdEmb.TabIndex = 4;
            this.rdEmb.TabStop = true;
            this.rdEmb.Text = "Embalagem";
            this.rdEmb.UseVisualStyleBackColor = true;
            // 
            // cbTabela
            // 
            this.cbTabela.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbTabela.FormattingEnabled = true;
            this.cbTabela.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            ""});
            this.cbTabela.Location = new System.Drawing.Point(133, 56);
            this.cbTabela.MaxLength = 5;
            this.cbTabela.Name = "cbTabela";
            this.cbTabela.Size = new System.Drawing.Size(69, 26);
            this.cbTabela.TabIndex = 3;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblTabela.Location = new System.Drawing.Point(6, 59);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(121, 18);
            this.lblTabela.TabIndex = 1;
            this.lblTabela.Text = "Tabela de Preços:";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblRazao.Location = new System.Drawing.Point(208, 27);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(163, 18);
            this.lblRazao.TabIndex = 0;
            this.lblRazao.Text = "Razão Social do Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblEditar);
            this.groupBox2.Controls.Add(this.pbEditar);
            this.groupBox2.Controls.Add(this.lblAdicionar);
            this.groupBox2.Controls.Add(this.pbAdicionar);
            this.groupBox2.Controls.Add(this.lblExcluir);
            this.groupBox2.Controls.Add(this.pbExcluir);
            this.groupBox2.Controls.Add(this.comboEspecie);
            this.groupBox2.Controls.Add(this.lblEspecie);
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Controls.Add(this.lblValorTotal);
            this.groupBox2.Controls.Add(this.txtValorUnit);
            this.groupBox2.Controls.Add(this.lblValorUnit);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.comboProduto);
            this.groupBox2.Controls.Add(this.lblQuantidade);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(246, 125);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 57;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(221, 119);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 56;
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
            this.lblAdicionar.Location = new System.Drawing.Point(22, 125);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(73, 22);
            this.lblAdicionar.TabIndex = 55;
            this.lblAdicionar.Text = "Adicionar";
            this.lblAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.lblAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.lblAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(9, 119);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionar.TabIndex = 54;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.pbAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.pbAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(138, 125);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 53;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btRemover_Click);
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(115, 119);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 52;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.btRemover_Click);
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // comboEspecie
            // 
            this.comboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecie.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboEspecie.FormattingEnabled = true;
            this.comboEspecie.Items.AddRange(new object[] {
            "CX",
            "PC",
            "UN",
            ""});
            this.comboEspecie.Location = new System.Drawing.Point(98, 87);
            this.comboEspecie.MaxLength = 5;
            this.comboEspecie.Name = "comboEspecie";
            this.comboEspecie.Size = new System.Drawing.Size(77, 26);
            this.comboEspecie.TabIndex = 11;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEspecie.Location = new System.Drawing.Point(6, 90);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(65, 18);
            this.lblEspecie.TabIndex = 10;
            this.lblEspecie.Text = "Unidade:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(652, 56);
            this.txtValorTotal.MaxLength = 25;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(144, 25);
            this.txtValorTotal.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorTotal.Location = new System.Drawing.Point(566, 59);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(80, 18);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorUnit.Location = new System.Drawing.Point(390, 56);
            this.txtValorUnit.MaxLength = 25;
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(149, 25);
            this.txtValorUnit.TabIndex = 5;
            this.txtValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnit_KeyPress);
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorUnit.Location = new System.Drawing.Point(282, 59);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(102, 18);
            this.lblValorUnit.TabIndex = 4;
            this.lblValorUnit.Text = "Valor Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(98, 56);
            this.txtQuantidade.MaxLength = 25;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(149, 25);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // comboProduto
            // 
            this.comboProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(98, 24);
            this.comboProduto.MaxLength = 255;
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(698, 26);
            this.comboProduto.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(6, 59);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProduto.Location = new System.Drawing.Point(6, 27);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // cbMetodo
            // 
            this.cbMetodo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Items.AddRange(new object[] {
            "Boleto",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Cheque",
            "Dinheiro"});
            this.cbMetodo.Location = new System.Drawing.Point(182, 27);
            this.cbMetodo.MaxLength = 50;
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(184, 26);
            this.cbMetodo.TabIndex = 59;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblMetodo.Location = new System.Drawing.Point(19, 30);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(157, 18);
            this.lblMetodo.TabIndex = 58;
            this.lblMetodo.Text = "Método de Pagamento:";
            // 
            // listProdutosV
            // 
            this.listProdutosV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listProdutosV.CheckBoxes = true;
            this.listProdutosV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Produto,
            this.coluna2Unidade,
            this.coluna3Quantidade,
            this.coluna4ValorUnitario,
            this.coluna5ValorTotal});
            this.listProdutosV.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listProdutosV.Location = new System.Drawing.Point(13, 293);
            this.listProdutosV.Name = "listProdutosV";
            this.listProdutosV.Size = new System.Drawing.Size(802, 192);
            this.listProdutosV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProdutosV.TabIndex = 5;
            this.listProdutosV.UseCompatibleStateImageBehavior = false;
            this.listProdutosV.View = System.Windows.Forms.View.Details;
            this.listProdutosV.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listProdutosV_ItemCheck);
            this.listProdutosV.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listProdutosV_ItemChecked);
            this.listProdutosV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listProdutosV_ItemSelectionChanged);
            // 
            // coluna1Produto
            // 
            this.coluna1Produto.Text = "Produto";
            this.coluna1Produto.Width = 348;
            // 
            // coluna2Unidade
            // 
            this.coluna2Unidade.Text = "Unidade";
            this.coluna2Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coluna3Quantidade
            // 
            this.coluna3Quantidade.Text = "Quantidade";
            this.coluna3Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Quantidade.Width = 137;
            // 
            // coluna4ValorUnitario
            // 
            this.coluna4ValorUnitario.Text = "Valor Unitário";
            this.coluna4ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4ValorUnitario.Width = 110;
            // 
            // coluna5ValorTotal
            // 
            this.coluna5ValorTotal.Text = "Valor Total";
            this.coluna5ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna5ValorTotal.Width = 143;
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(802, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 12;
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
            this.btMin.Location = new System.Drawing.Point(777, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 13;
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
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 14;
            this.label3.Tag = "";
            this.label3.Text = "NOVO PEDIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(618, 576);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 61;
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
            this.pbLimparTela.Location = new System.Drawing.Point(609, 570);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 60;
            this.pbLimparTela.TabStop = false;
            this.pbLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.pbLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(739, 576);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 59;
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
            this.pbVoltar.Location = new System.Drawing.Point(715, 570);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 58;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(36, 576);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 63;
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
            this.pbSalvar.Location = new System.Drawing.Point(13, 570);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 62;
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
            this.lblSalvo.Location = new System.Drawing.Point(232, 581);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 64;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // lblImprimir
            // 
            this.lblImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImprimir.Enabled = false;
            this.lblImprimir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblImprimir.Location = new System.Drawing.Point(137, 576);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(65, 22);
            this.lblImprimir.TabIndex = 65;
            this.lblImprimir.Text = "Imprimir";
            this.lblImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.lblImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.lblImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // pbImprimir
            // 
            this.pbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImprimir.Enabled = false;
            this.pbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("pbImprimir.Image")));
            this.pbImprimir.Location = new System.Drawing.Point(119, 570);
            this.pbImprimir.Name = "pbImprimir";
            this.pbImprimir.Size = new System.Drawing.Size(100, 35);
            this.pbImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImprimir.TabIndex = 66;
            this.pbImprimir.TabStop = false;
            this.pbImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.pbImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.pbImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.lblPrazo);
            this.groupBox3.Controls.Add(this.cbMetodo);
            this.groupBox3.Controls.Add(this.lblMetodo);
            this.groupBox3.Location = new System.Drawing.Point(12, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 72);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(594, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "dias";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.textBox1.Location = new System.Drawing.Point(443, 27);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblPrazo.Location = new System.Drawing.Point(388, 30);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(49, 18);
            this.lblPrazo.TabIndex = 60;
            this.lblPrazo.Text = "Prazo:";
            // 
            // FrmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(827, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.pbImprimir);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.listProdutosV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNovoPedido";
            this.Text = "Novo Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListView listProdutosV;
        private System.Windows.Forms.ColumnHeader coluna1Produto;
        private System.Windows.Forms.ColumnHeader coluna2Unidade;
        private System.Windows.Forms.ColumnHeader coluna3Quantidade;
        private System.Windows.Forms.ColumnHeader coluna4ValorUnitario;
        private System.Windows.Forms.ComboBox comboEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ColumnHeader coluna5ValorTotal;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.RadioButton rdProd;
        private System.Windows.Forms.RadioButton rdMat;
        private System.Windows.Forms.RadioButton rdEmb;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.PictureBox pbImprimir;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private Controls.ComboAuto cbRazao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrazo;
    }
}