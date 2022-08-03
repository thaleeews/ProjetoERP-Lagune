namespace ProjetoLagune.Producao.OrdemProducao
{
    partial class FrmOrdemProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdemProducao));
            this.tabOrdemProd = new System.Windows.Forms.TabControl();
            this.tpMateria = new System.Windows.Forms.TabPage();
            this.lblExcluirMat = new System.Windows.Forms.Label();
            this.pbExcluirMat = new System.Windows.Forms.PictureBox();
            this.lblEditarMat = new System.Windows.Forms.Label();
            this.pbEditarMat = new System.Windows.Forms.PictureBox();
            this.lblAdicionarMat = new System.Windows.Forms.Label();
            this.pbAdicionarMat = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboEspecieMat = new System.Windows.Forms.ComboBox();
            this.lblEspecieMat = new System.Windows.Forms.Label();
            this.txtQuantidadeMat = new System.Windows.Forms.TextBox();
            this.lblQuantidadeMat = new System.Windows.Forms.Label();
            this.comboNomeMat = new System.Windows.Forms.ComboBox();
            this.lblNomeMat = new System.Windows.Forms.Label();
            this.listMateriaPrima = new System.Windows.Forms.ListView();
            this.coluna1Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2EspecieM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaQuantidadeM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpProcedimento = new System.Windows.Forms.TabPage();
            this.txtProced = new System.Windows.Forms.TextBox();
            this.grpbProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNomeProduto = new System.Windows.Forms.ComboBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.grpbCodigo = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
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
            this.pbConcluir = new System.Windows.Forms.PictureBox();
            this.lblConcluir = new System.Windows.Forms.Label();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.tabOrdemProd.SuspendLayout();
            this.tpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpProcedimento.SuspendLayout();
            this.grpbProduto.SuspendLayout();
            this.grpbCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOrdemProd
            // 
            this.tabOrdemProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabOrdemProd.Controls.Add(this.tpMateria);
            this.tabOrdemProd.Controls.Add(this.tpProcedimento);
            this.tabOrdemProd.Enabled = false;
            this.tabOrdemProd.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOrdemProd.Location = new System.Drawing.Point(13, 166);
            this.tabOrdemProd.Name = "tabOrdemProd";
            this.tabOrdemProd.SelectedIndex = 0;
            this.tabOrdemProd.Size = new System.Drawing.Size(835, 386);
            this.tabOrdemProd.TabIndex = 0;
            // 
            // tpMateria
            // 
            this.tpMateria.Controls.Add(this.lblExcluirMat);
            this.tpMateria.Controls.Add(this.pbExcluirMat);
            this.tpMateria.Controls.Add(this.lblEditarMat);
            this.tpMateria.Controls.Add(this.pbEditarMat);
            this.tpMateria.Controls.Add(this.lblAdicionarMat);
            this.tpMateria.Controls.Add(this.pbAdicionarMat);
            this.tpMateria.Controls.Add(this.groupBox1);
            this.tpMateria.Controls.Add(this.listMateriaPrima);
            this.tpMateria.Location = new System.Drawing.Point(4, 22);
            this.tpMateria.Name = "tpMateria";
            this.tpMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tpMateria.Size = new System.Drawing.Size(827, 360);
            this.tpMateria.TabIndex = 0;
            this.tpMateria.Text = "Matéria Prima";
            this.tpMateria.UseVisualStyleBackColor = true;
            // 
            // lblExcluirMat
            // 
            this.lblExcluirMat.AutoSize = true;
            this.lblExcluirMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluirMat.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluirMat.Location = new System.Drawing.Point(235, 207);
            this.lblExcluirMat.Name = "lblExcluirMat";
            this.lblExcluirMat.Size = new System.Drawing.Size(56, 22);
            this.lblExcluirMat.TabIndex = 3;
            this.lblExcluirMat.Text = "Excluir";
            this.lblExcluirMat.Click += new System.EventHandler(this.btExcluirMat_Click);
            this.lblExcluirMat.MouseEnter += new System.EventHandler(this.pbExcluirMat_MouseEnter);
            this.lblExcluirMat.MouseLeave += new System.EventHandler(this.pbExcluirMat_MouseLeave);
            // 
            // pbExcluirMat
            // 
            this.pbExcluirMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluirMat.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluirMat.Image")));
            this.pbExcluirMat.Location = new System.Drawing.Point(212, 201);
            this.pbExcluirMat.Name = "pbExcluirMat";
            this.pbExcluirMat.Size = new System.Drawing.Size(100, 35);
            this.pbExcluirMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluirMat.TabIndex = 56;
            this.pbExcluirMat.TabStop = false;
            this.pbExcluirMat.Click += new System.EventHandler(this.btExcluirMat_Click);
            this.pbExcluirMat.MouseEnter += new System.EventHandler(this.pbExcluirMat_MouseEnter);
            this.pbExcluirMat.MouseLeave += new System.EventHandler(this.pbExcluirMat_MouseLeave);
            // 
            // lblEditarMat
            // 
            this.lblEditarMat.AutoSize = true;
            this.lblEditarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarMat.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditarMat.Location = new System.Drawing.Point(131, 207);
            this.lblEditarMat.Name = "lblEditarMat";
            this.lblEditarMat.Size = new System.Drawing.Size(50, 22);
            this.lblEditarMat.TabIndex = 2;
            this.lblEditarMat.Text = "Editar";
            this.lblEditarMat.Click += new System.EventHandler(this.btEditarMat_Click);
            this.lblEditarMat.MouseEnter += new System.EventHandler(this.pbEditarMat_MouseEnter);
            this.lblEditarMat.MouseLeave += new System.EventHandler(this.pbEditarMat_MouseLeave);
            // 
            // pbEditarMat
            // 
            this.pbEditarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarMat.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarMat.Image")));
            this.pbEditarMat.Location = new System.Drawing.Point(106, 201);
            this.pbEditarMat.Name = "pbEditarMat";
            this.pbEditarMat.Size = new System.Drawing.Size(100, 35);
            this.pbEditarMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarMat.TabIndex = 54;
            this.pbEditarMat.TabStop = false;
            this.pbEditarMat.Click += new System.EventHandler(this.btEditarMat_Click);
            this.pbEditarMat.MouseEnter += new System.EventHandler(this.pbEditarMat_MouseEnter);
            this.pbEditarMat.MouseLeave += new System.EventHandler(this.pbEditarMat_MouseLeave);
            // 
            // lblAdicionarMat
            // 
            this.lblAdicionarMat.AutoSize = true;
            this.lblAdicionarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdicionarMat.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblAdicionarMat.Location = new System.Drawing.Point(13, 207);
            this.lblAdicionarMat.Name = "lblAdicionarMat";
            this.lblAdicionarMat.Size = new System.Drawing.Size(73, 22);
            this.lblAdicionarMat.TabIndex = 1;
            this.lblAdicionarMat.Text = "Adicionar";
            this.lblAdicionarMat.Click += new System.EventHandler(this.btAdicionarMat_Click);
            this.lblAdicionarMat.MouseEnter += new System.EventHandler(this.pbAdicionarMat_MouseEnter);
            this.lblAdicionarMat.MouseLeave += new System.EventHandler(this.pbAdicionarMat_MouseLeave);
            // 
            // pbAdicionarMat
            // 
            this.pbAdicionarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionarMat.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionarMat.Image")));
            this.pbAdicionarMat.Location = new System.Drawing.Point(0, 201);
            this.pbAdicionarMat.Name = "pbAdicionarMat";
            this.pbAdicionarMat.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionarMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionarMat.TabIndex = 52;
            this.pbAdicionarMat.TabStop = false;
            this.pbAdicionarMat.Click += new System.EventHandler(this.btAdicionarMat_Click);
            this.pbAdicionarMat.MouseEnter += new System.EventHandler(this.pbAdicionarMat_MouseEnter);
            this.pbAdicionarMat.MouseLeave += new System.EventHandler(this.pbAdicionarMat_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEspecieMat);
            this.groupBox1.Controls.Add(this.lblEspecieMat);
            this.groupBox1.Controls.Add(this.txtQuantidadeMat);
            this.groupBox1.Controls.Add(this.lblQuantidadeMat);
            this.groupBox1.Controls.Add(this.comboNomeMat);
            this.groupBox1.Controls.Add(this.lblNomeMat);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edição";
            // 
            // comboEspecieMat
            // 
            this.comboEspecieMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecieMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboEspecieMat.FormattingEnabled = true;
            this.comboEspecieMat.Items.AddRange(new object[] {
            "PC",
            "PÇ",
            "UN",
            ""});
            this.comboEspecieMat.Location = new System.Drawing.Point(165, 82);
            this.comboEspecieMat.Name = "comboEspecieMat";
            this.comboEspecieMat.Size = new System.Drawing.Size(61, 26);
            this.comboEspecieMat.TabIndex = 2;
            // 
            // lblEspecieMat
            // 
            this.lblEspecieMat.AutoSize = true;
            this.lblEspecieMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEspecieMat.Location = new System.Drawing.Point(10, 85);
            this.lblEspecieMat.Name = "lblEspecieMat";
            this.lblEspecieMat.Size = new System.Drawing.Size(65, 18);
            this.lblEspecieMat.TabIndex = 4;
            this.lblEspecieMat.Text = "Unidade:";
            // 
            // txtQuantidadeMat
            // 
            this.txtQuantidadeMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidadeMat.Location = new System.Drawing.Point(165, 51);
            this.txtQuantidadeMat.Name = "txtQuantidadeMat";
            this.txtQuantidadeMat.Size = new System.Drawing.Size(242, 25);
            this.txtQuantidadeMat.TabIndex = 1;
            this.txtQuantidadeMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeMat_KeyPress);
            // 
            // lblQuantidadeMat
            // 
            this.lblQuantidadeMat.AutoSize = true;
            this.lblQuantidadeMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidadeMat.Location = new System.Drawing.Point(10, 54);
            this.lblQuantidadeMat.Name = "lblQuantidadeMat";
            this.lblQuantidadeMat.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidadeMat.TabIndex = 2;
            this.lblQuantidadeMat.Text = "Quantidade:";
            // 
            // comboNomeMat
            // 
            this.comboNomeMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboNomeMat.FormattingEnabled = true;
            this.comboNomeMat.Location = new System.Drawing.Point(165, 19);
            this.comboNomeMat.Name = "comboNomeMat";
            this.comboNomeMat.Size = new System.Drawing.Size(656, 26);
            this.comboNomeMat.TabIndex = 0;
            // 
            // lblNomeMat
            // 
            this.lblNomeMat.AutoSize = true;
            this.lblNomeMat.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNomeMat.Location = new System.Drawing.Point(10, 22);
            this.lblNomeMat.Name = "lblNomeMat";
            this.lblNomeMat.Size = new System.Drawing.Size(124, 18);
            this.lblNomeMat.TabIndex = 0;
            this.lblNomeMat.Text = "Nome da Matéria:";
            // 
            // listMateriaPrima
            // 
            this.listMateriaPrima.CheckBoxes = true;
            this.listMateriaPrima.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Materia,
            this.coluna2EspecieM,
            this.colunaQuantidadeM});
            this.listMateriaPrima.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listMateriaPrima.Location = new System.Drawing.Point(0, 0);
            this.listMateriaPrima.Name = "listMateriaPrima";
            this.listMateriaPrima.Size = new System.Drawing.Size(827, 195);
            this.listMateriaPrima.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listMateriaPrima.TabIndex = 1;
            this.listMateriaPrima.UseCompatibleStateImageBehavior = false;
            this.listMateriaPrima.View = System.Windows.Forms.View.Details;
            this.listMateriaPrima.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listMateriaPrima_ItemCheck);
            this.listMateriaPrima.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listMateriaPrima_ItemChecked);
            this.listMateriaPrima.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listMateriaPrima_ItemSelectionChanged);
            // 
            // coluna1Materia
            // 
            this.coluna1Materia.Text = "Matéria Prima";
            this.coluna1Materia.Width = 450;
            // 
            // coluna2EspecieM
            // 
            this.coluna2EspecieM.Text = "Unidade";
            this.coluna2EspecieM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2EspecieM.Width = 70;
            // 
            // colunaQuantidadeM
            // 
            this.colunaQuantidadeM.Text = "Quantidade";
            this.colunaQuantidadeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaQuantidadeM.Width = 200;
            // 
            // tpProcedimento
            // 
            this.tpProcedimento.Controls.Add(this.txtProced);
            this.tpProcedimento.Location = new System.Drawing.Point(4, 22);
            this.tpProcedimento.Name = "tpProcedimento";
            this.tpProcedimento.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcedimento.Size = new System.Drawing.Size(827, 360);
            this.tpProcedimento.TabIndex = 1;
            this.tpProcedimento.Text = "Procedimento";
            this.tpProcedimento.UseVisualStyleBackColor = true;
            // 
            // txtProced
            // 
            this.txtProced.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtProced.Location = new System.Drawing.Point(0, 0);
            this.txtProced.Multiline = true;
            this.txtProced.Name = "txtProced";
            this.txtProced.Size = new System.Drawing.Size(827, 360);
            this.txtProced.TabIndex = 0;
            // 
            // grpbProduto
            // 
            this.grpbProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbProduto.Controls.Add(this.txtQuantidade);
            this.grpbProduto.Controls.Add(this.lblQuantidade);
            this.grpbProduto.Controls.Add(this.txtLote);
            this.grpbProduto.Controls.Add(this.label1);
            this.grpbProduto.Controls.Add(this.cbNomeProduto);
            this.grpbProduto.Controls.Add(this.lblNomeProduto);
            this.grpbProduto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProduto.Location = new System.Drawing.Point(13, 83);
            this.grpbProduto.Name = "grpbProduto";
            this.grpbProduto.Size = new System.Drawing.Size(835, 77);
            this.grpbProduto.TabIndex = 1;
            this.grpbProduto.TabStop = false;
            this.grpbProduto.Text = "Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(585, 45);
            this.txtQuantidade.MaxLength = 30;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(244, 25);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(493, 48);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLote.Location = new System.Drawing.Point(134, 45);
            this.txtLote.MaxLength = 50;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(277, 25);
            this.txtLote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lote do Produto:";
            // 
            // cbNomeProduto
            // 
            this.cbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNomeProduto.FormattingEnabled = true;
            this.cbNomeProduto.Items.AddRange(new object[] {
            "Produto",
            ""});
            this.cbNomeProduto.Location = new System.Drawing.Point(134, 13);
            this.cbNomeProduto.MaxLength = 255;
            this.cbNomeProduto.Name = "cbNomeProduto";
            this.cbNomeProduto.Size = new System.Drawing.Size(695, 26);
            this.cbNomeProduto.TabIndex = 0;
            this.cbNomeProduto.SelectedIndexChanged += new System.EventHandler(this.comboNomeProduto_SelectedIndexChanged);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 16);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(125, 18);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // grpbCodigo
            // 
            this.grpbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbCodigo.Controls.Add(this.dateTimePicker1);
            this.grpbCodigo.Controls.Add(this.label2);
            this.grpbCodigo.Controls.Add(this.cbCodigo);
            this.grpbCodigo.Controls.Add(this.lblCodigo);
            this.grpbCodigo.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCodigo.Location = new System.Drawing.Point(13, 24);
            this.grpbCodigo.Name = "grpbCodigo";
            this.grpbCodigo.Size = new System.Drawing.Size(835, 53);
            this.grpbCodigo.TabIndex = 0;
            this.grpbCodigo.TabStop = false;
            this.grpbCodigo.Text = "Código";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label2.Location = new System.Drawing.Point(429, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programação:";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Items.AddRange(new object[] {
            "500"});
            this.cbCodigo.Location = new System.Drawing.Point(227, 20);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(176, 26);
            this.cbCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(6, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(207, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código da Ordem de Produção:";
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(835, 0);
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
            this.btMin.Location = new System.Drawing.Point(810, 0);
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
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 14;
            this.label3.Tag = "";
            this.label3.Text = "ORDEM DE PRODUÇÃO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 600);
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
            this.lblLimparTela.Location = new System.Drawing.Point(651, 564);
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
            this.pbLimparTela.Location = new System.Drawing.Point(642, 558);
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
            this.lblVoltar.Location = new System.Drawing.Point(772, 564);
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
            this.pbVoltar.Location = new System.Drawing.Point(748, 558);
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
            this.lblSalvar.Location = new System.Drawing.Point(36, 564);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 59;
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
            this.pbSalvar.Location = new System.Drawing.Point(13, 558);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 58;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // pbConcluir
            // 
            this.pbConcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbConcluir.Image")));
            this.pbConcluir.Location = new System.Drawing.Point(119, 558);
            this.pbConcluir.Name = "pbConcluir";
            this.pbConcluir.Size = new System.Drawing.Size(100, 35);
            this.pbConcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConcluir.TabIndex = 60;
            this.pbConcluir.TabStop = false;
            this.pbConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.pbConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.pbConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // lblConcluir
            // 
            this.lblConcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConcluir.AutoSize = true;
            this.lblConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblConcluir.Location = new System.Drawing.Point(136, 564);
            this.lblConcluir.Name = "lblConcluir";
            this.lblConcluir.Size = new System.Drawing.Size(65, 22);
            this.lblConcluir.TabIndex = 61;
            this.lblConcluir.Text = "Imprimir";
            this.lblConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.lblConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.lblConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(225, 569);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 70;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // FrmOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblConcluir);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.pbConcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.grpbCodigo);
            this.Controls.Add(this.grpbProduto);
            this.Controls.Add(this.tabOrdemProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdemProducao";
            this.Text = "Ordem de Produção";
            this.tabOrdemProd.ResumeLayout(false);
            this.tpMateria.ResumeLayout(false);
            this.tpMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpProcedimento.ResumeLayout(false);
            this.tpProcedimento.PerformLayout();
            this.grpbProduto.ResumeLayout(false);
            this.grpbProduto.PerformLayout();
            this.grpbCodigo.ResumeLayout(false);
            this.grpbCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrdemProd;
        private System.Windows.Forms.TabPage tpMateria;
        private System.Windows.Forms.GroupBox grpbProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboEspecieMat;
        private System.Windows.Forms.Label lblEspecieMat;
        private System.Windows.Forms.TextBox txtQuantidadeMat;
        private System.Windows.Forms.Label lblQuantidadeMat;
        private System.Windows.Forms.ComboBox comboNomeMat;
        private System.Windows.Forms.Label lblNomeMat;
        private System.Windows.Forms.ListView listMateriaPrima;
        private System.Windows.Forms.ColumnHeader coluna1Materia;
        private System.Windows.Forms.ColumnHeader coluna2EspecieM;
        private System.Windows.Forms.ColumnHeader colunaQuantidadeM;
        private System.Windows.Forms.GroupBox grpbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExcluirMat;
        private System.Windows.Forms.PictureBox pbExcluirMat;
        private System.Windows.Forms.Label lblEditarMat;
        private System.Windows.Forms.PictureBox pbEditarMat;
        private System.Windows.Forms.Label lblAdicionarMat;
        private System.Windows.Forms.PictureBox pbAdicionarMat;
        private System.Windows.Forms.Label lblLimparTela;
        private System.Windows.Forms.PictureBox pbLimparTela;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.PictureBox pbConcluir;
        private System.Windows.Forms.Label lblConcluir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpProcedimento;
        private System.Windows.Forms.TextBox txtProced;
        private System.Windows.Forms.Label lblSalvo;
    }
}