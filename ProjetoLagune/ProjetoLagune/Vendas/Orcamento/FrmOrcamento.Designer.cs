namespace ProjetoLagune.Vendas.Orcamento
{
    partial class FrmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrcamento));
            this.grpbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new ProjetoLagune.Controls.ComboAuto();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.cbUnidade = new ProjetoLagune.Controls.ComboAuto();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbProduto = new ProjetoLagune.Controls.ComboAuto();
            this.lblProduto = new System.Windows.Forms.Label();
            this.listOrca = new System.Windows.Forms.ListView();
            this.coluna1Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4ValorU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblImprimir = new System.Windows.Forms.Label();
            this.pbImprimir = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.grpbCliente.SuspendLayout();
            this.grpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbCliente
            // 
            this.grpbCliente.Controls.Add(this.cbCliente);
            this.grpbCliente.Controls.Add(this.lblCliente);
            this.grpbCliente.Location = new System.Drawing.Point(12, 19);
            this.grpbCliente.Name = "grpbCliente";
            this.grpbCliente.Size = new System.Drawing.Size(745, 66);
            this.grpbCliente.TabIndex = 0;
            this.grpbCliente.TabStop = false;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.LimitToList = true;
            this.cbCliente.Location = new System.Drawing.Point(98, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(641, 26);
            this.cbCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCliente.Location = new System.Drawing.Point(6, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.lblEditar);
            this.grpbInfo.Controls.Add(this.pbEditar);
            this.grpbInfo.Controls.Add(this.lblAdicionar);
            this.grpbInfo.Controls.Add(this.pbAdicionar);
            this.grpbInfo.Controls.Add(this.lblExcluir);
            this.grpbInfo.Controls.Add(this.pbExcluir);
            this.grpbInfo.Controls.Add(this.cbUnidade);
            this.grpbInfo.Controls.Add(this.lblUnidade);
            this.grpbInfo.Controls.Add(this.txtValorTotal);
            this.grpbInfo.Controls.Add(this.lblValorTotal);
            this.grpbInfo.Controls.Add(this.txtValorUnitario);
            this.grpbInfo.Controls.Add(this.lblValorUnitario);
            this.grpbInfo.Controls.Add(this.txtQuantidade);
            this.grpbInfo.Controls.Add(this.lblQuantidade);
            this.grpbInfo.Controls.Add(this.cbProduto);
            this.grpbInfo.Controls.Add(this.lblProduto);
            this.grpbInfo.Location = new System.Drawing.Point(12, 91);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(745, 158);
            this.grpbInfo.TabIndex = 2;
            this.grpbInfo.TabStop = false;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(246, 120);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 63;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(221, 114);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 62;
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
            this.lblAdicionar.Location = new System.Drawing.Point(22, 120);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(73, 22);
            this.lblAdicionar.TabIndex = 61;
            this.lblAdicionar.Text = "Adicionar";
            this.lblAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.lblAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.lblAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(9, 114);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionar.TabIndex = 60;
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
            this.lblExcluir.Location = new System.Drawing.Point(138, 120);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 59;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(115, 114);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 58;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "KG",
            "G",
            "mG",
            ""});
            this.cbUnidade.LimitToList = true;
            this.cbUnidade.Location = new System.Drawing.Point(98, 82);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(98, 26);
            this.cbUnidade.TabIndex = 12;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblUnidade.Location = new System.Drawing.Point(6, 85);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(65, 18);
            this.lblUnidade.TabIndex = 11;
            this.lblUnidade.Text = "Unidade:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(599, 51);
            this.txtValorTotal.MaxLength = 30;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(140, 25);
            this.txtValorTotal.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorTotal.Location = new System.Drawing.Point(491, 54);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(80, 18);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorUnitario.Location = new System.Drawing.Point(327, 51);
            this.txtValorUnitario.MaxLength = 15;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(158, 25);
            this.txtValorUnitario.TabIndex = 5;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorUnitario.Location = new System.Drawing.Point(219, 54);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(102, 18);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(98, 51);
            this.txtQuantidade.MaxLength = 15;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(115, 25);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(6, 54);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.LimitToList = true;
            this.cbProduto.Location = new System.Drawing.Point(98, 19);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(641, 26);
            this.cbProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProduto.Location = new System.Drawing.Point(6, 22);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // listOrca
            // 
            this.listOrca.CheckBoxes = true;
            this.listOrca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Produto,
            this.coluna2Unidade,
            this.coluna3Quantidade,
            this.coluna4ValorU,
            this.coluna5ValorTotal});
            this.listOrca.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listOrca.Location = new System.Drawing.Point(12, 255);
            this.listOrca.Name = "listOrca";
            this.listOrca.Size = new System.Drawing.Size(745, 203);
            this.listOrca.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listOrca.TabIndex = 3;
            this.listOrca.UseCompatibleStateImageBehavior = false;
            this.listOrca.View = System.Windows.Forms.View.Details;
            this.listOrca.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listOrca_ItemCheck);
            this.listOrca.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listOrca_ItemChecked);
            this.listOrca.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listOrca_ItemSelectionChanged);
            // 
            // coluna1Produto
            // 
            this.coluna1Produto.Text = "Produto";
            this.coluna1Produto.Width = 330;
            // 
            // coluna2Unidade
            // 
            this.coluna2Unidade.Text = "Unidade";
            this.coluna2Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2Unidade.Width = 65;
            // 
            // coluna3Quantidade
            // 
            this.coluna3Quantidade.Text = "Quantidade";
            this.coluna3Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Quantidade.Width = 120;
            // 
            // coluna4ValorU
            // 
            this.coluna4ValorU.Text = "Valor Unitário";
            this.coluna4ValorU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4ValorU.Width = 110;
            // 
            // coluna5ValorTotal
            // 
            this.coluna5ValorTotal.Text = "Valor Total";
            this.coluna5ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna5ValorTotal.Width = 110;
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(744, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 15;
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
            this.btMin.Location = new System.Drawing.Point(719, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 16;
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
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 17;
            this.label3.Tag = "";
            this.label3.Text = "ORÇAMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(560, 470);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 67;
            this.lblLimparTela.Text = "Limpar Tela";
            this.lblLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.lblLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.lblLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // pbLimparTela
            // 
            this.pbLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimparTela.Image = ((System.Drawing.Image)(resources.GetObject("pbLimparTela.Image")));
            this.pbLimparTela.Location = new System.Drawing.Point(551, 464);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 66;
            this.pbLimparTela.TabStop = false;
            this.pbLimparTela.Click += new System.EventHandler(this.btLimpar_Click);
            this.pbLimparTela.MouseEnter += new System.EventHandler(this.pbLimparTela_MouseEnter);
            this.pbLimparTela.MouseLeave += new System.EventHandler(this.pbLimparTela_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(681, 470);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 65;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(657, 464);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 64;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(35, 470);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 65;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(12, 464);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 64;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImprimir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblImprimir.Location = new System.Drawing.Point(135, 470);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(65, 22);
            this.lblImprimir.TabIndex = 69;
            this.lblImprimir.Text = "Imprimir";
            this.lblImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.lblImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.lblImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // pbImprimir
            // 
            this.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("pbImprimir.Image")));
            this.pbImprimir.Location = new System.Drawing.Point(118, 464);
            this.pbImprimir.Name = "pbImprimir";
            this.pbImprimir.Size = new System.Drawing.Size(100, 35);
            this.pbImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImprimir.TabIndex = 68;
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
            this.lblSalvo.Location = new System.Drawing.Point(224, 475);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 70;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(769, 505);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.pbImprimir);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.listOrca);
            this.Controls.Add(this.grpbInfo);
            this.Controls.Add(this.grpbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrcamento";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.FrmOrcamento_Load);
            this.grpbCliente.ResumeLayout(false);
            this.grpbCliente.PerformLayout();
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCliente;
        private Controls.ComboAuto cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private Controls.ComboAuto cbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListView listOrca;
        private System.Windows.Forms.ColumnHeader coluna1Produto;
        private System.Windows.Forms.ColumnHeader coluna2Unidade;
        private System.Windows.Forms.ColumnHeader coluna3Quantidade;
        private System.Windows.Forms.ColumnHeader coluna4ValorU;
        private Controls.ComboAuto cbUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ColumnHeader coluna5ValorTotal;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.PictureBox pbImprimir;
        private System.Windows.Forms.Label lblSalvo;
    }
}