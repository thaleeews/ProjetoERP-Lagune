namespace ProjetoLagune.Producao.PosProducao
{
    partial class FrmPosProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosProducao));
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoOrdem = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtProduzida = new System.Windows.Forms.TextBox();
            this.lblQtProduzida = new System.Windows.Forms.Label();
            this.lblQtOrdenada = new System.Windows.Forms.Label();
            this.txtQtOrdenada = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUnidadeMat = new System.Windows.Forms.Label();
            this.txtQtMat = new System.Windows.Forms.TextBox();
            this.lblQtMat = new System.Windows.Forms.Label();
            this.lblNomeMat = new System.Windows.Forms.Label();
            this.lblExcluirMat = new System.Windows.Forms.Label();
            this.pbExcluirMat = new System.Windows.Forms.PictureBox();
            this.lblEditarMat = new System.Windows.Forms.Label();
            this.pbEditarMat = new System.Windows.Forms.PictureBox();
            this.lblAdicionarMat = new System.Windows.Forms.Label();
            this.pbAdicionarMat = new System.Windows.Forms.PictureBox();
            this.listMateria = new System.Windows.Forms.ListView();
            this.c1Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3Unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLimparTela = new System.Windows.Forms.Label();
            this.pbLimparTela = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.cbUnidadeMat = new ProjetoLagune.Controls.ComboAuto();
            this.cbNomeMat = new ProjetoLagune.Controls.ComboAuto();
            this.cbCodigo = new ProjetoLagune.Controls.ComboAuto();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(737, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 26;
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
            this.btX.Location = new System.Drawing.Point(762, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 25;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // pbCor
            // 
            this.pbCor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCor.Image = ((System.Drawing.Image)(resources.GetObject("pbCor.Image")));
            this.pbCor.Location = new System.Drawing.Point(0, 0);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(5, 637);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 27;
            this.pbCor.TabStop = false;
            // 
            // lblPos
            // 
            this.lblPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPos.AutoSize = true;
            this.lblPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPos.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblPos.ForeColor = System.Drawing.Color.DimGray;
            this.lblPos.Location = new System.Drawing.Point(9, 7);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(102, 15);
            this.lblPos.TabIndex = 28;
            this.lblPos.Tag = "";
            this.lblPos.Text = "PÓS PRODUÇÃO";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblCodigoOrdem);
            this.groupBox1.Controls.Add(this.cbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblCodigoOrdem
            // 
            this.lblCodigoOrdem.AutoSize = true;
            this.lblCodigoOrdem.Location = new System.Drawing.Point(6, 27);
            this.lblCodigoOrdem.Name = "lblCodigoOrdem";
            this.lblCodigoOrdem.Size = new System.Drawing.Size(204, 18);
            this.lblCodigoOrdem.TabIndex = 1;
            this.lblCodigoOrdem.Text = "Código da Ordem de Produção";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblLote);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtQtProduzida);
            this.groupBox2.Controls.Add(this.lblQtProduzida);
            this.groupBox2.Controls.Add(this.lblQtOrdenada);
            this.groupBox2.Controls.Add(this.txtQtOrdenada);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.groupBox2.Location = new System.Drawing.Point(13, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(377, 58);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(38, 18);
            this.lblLote.TabIndex = 9;
            this.lblLote.Text = "Lote";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(421, 55);
            this.txtLote.Name = "txtLote";
            this.txtLote.ReadOnly = true;
            this.txtLote.Size = new System.Drawing.Size(226, 25);
            this.txtLote.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(592, 25);
            this.txtNome.TabIndex = 7;
            // 
            // txtQtProduzida
            // 
            this.txtQtProduzida.Location = new System.Drawing.Point(164, 86);
            this.txtQtProduzida.Name = "txtQtProduzida";
            this.txtQtProduzida.Size = new System.Drawing.Size(207, 25);
            this.txtQtProduzida.TabIndex = 0;
            this.txtQtProduzida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericas_KeyPress);
            // 
            // lblQtProduzida
            // 
            this.lblQtProduzida.AutoSize = true;
            this.lblQtProduzida.Location = new System.Drawing.Point(6, 89);
            this.lblQtProduzida.Name = "lblQtProduzida";
            this.lblQtProduzida.Size = new System.Drawing.Size(152, 18);
            this.lblQtProduzida.TabIndex = 5;
            this.lblQtProduzida.Text = "Quantidade Produzida";
            // 
            // lblQtOrdenada
            // 
            this.lblQtOrdenada.AutoSize = true;
            this.lblQtOrdenada.Location = new System.Drawing.Point(6, 58);
            this.lblQtOrdenada.Name = "lblQtOrdenada";
            this.lblQtOrdenada.Size = new System.Drawing.Size(150, 18);
            this.lblQtOrdenada.TabIndex = 4;
            this.lblQtOrdenada.Text = "Quantidade Ordenada";
            // 
            // txtQtOrdenada
            // 
            this.txtQtOrdenada.Location = new System.Drawing.Point(164, 55);
            this.txtQtOrdenada.Name = "txtQtOrdenada";
            this.txtQtOrdenada.ReadOnly = true;
            this.txtQtOrdenada.Size = new System.Drawing.Size(207, 25);
            this.txtQtOrdenada.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(122, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Produto";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 229);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 359);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lblExcluirMat);
            this.tabPage1.Controls.Add(this.pbExcluirMat);
            this.tabPage1.Controls.Add(this.lblEditarMat);
            this.tabPage1.Controls.Add(this.pbEditarMat);
            this.tabPage1.Controls.Add(this.lblAdicionarMat);
            this.tabPage1.Controls.Add(this.pbAdicionarMat);
            this.tabPage1.Controls.Add(this.listMateria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matéria Prima";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbUnidadeMat);
            this.groupBox3.Controls.Add(this.lblUnidadeMat);
            this.groupBox3.Controls.Add(this.txtQtMat);
            this.groupBox3.Controls.Add(this.lblQtMat);
            this.groupBox3.Controls.Add(this.cbNomeMat);
            this.groupBox3.Controls.Add(this.lblNomeMat);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.groupBox3.Location = new System.Drawing.Point(0, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lblUnidadeMat
            // 
            this.lblUnidadeMat.AutoSize = true;
            this.lblUnidadeMat.Location = new System.Drawing.Point(347, 59);
            this.lblUnidadeMat.Name = "lblUnidadeMat";
            this.lblUnidadeMat.Size = new System.Drawing.Size(62, 18);
            this.lblUnidadeMat.TabIndex = 10;
            this.lblUnidadeMat.Text = "Unidade";
            // 
            // txtQtMat
            // 
            this.txtQtMat.Location = new System.Drawing.Point(134, 56);
            this.txtQtMat.Name = "txtQtMat";
            this.txtQtMat.Size = new System.Drawing.Size(207, 25);
            this.txtQtMat.TabIndex = 1;
            this.txtQtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericas_KeyPress);
            // 
            // lblQtMat
            // 
            this.lblQtMat.AutoSize = true;
            this.lblQtMat.Location = new System.Drawing.Point(6, 59);
            this.lblQtMat.Name = "lblQtMat";
            this.lblQtMat.Size = new System.Drawing.Size(83, 18);
            this.lblQtMat.TabIndex = 9;
            this.lblQtMat.Text = "Quantidade";
            // 
            // lblNomeMat
            // 
            this.lblNomeMat.AutoSize = true;
            this.lblNomeMat.Location = new System.Drawing.Point(6, 27);
            this.lblNomeMat.Name = "lblNomeMat";
            this.lblNomeMat.Size = new System.Drawing.Size(121, 18);
            this.lblNomeMat.TabIndex = 8;
            this.lblNomeMat.Text = "Nome da Matéria";
            // 
            // lblExcluirMat
            // 
            this.lblExcluirMat.AutoSize = true;
            this.lblExcluirMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluirMat.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluirMat.Location = new System.Drawing.Point(235, 202);
            this.lblExcluirMat.Name = "lblExcluirMat";
            this.lblExcluirMat.Size = new System.Drawing.Size(56, 22);
            this.lblExcluirMat.TabIndex = 63;
            this.lblExcluirMat.Text = "Excluir";
            this.lblExcluirMat.Click += new System.EventHandler(this.btExcluirMat_Click);
            this.lblExcluirMat.MouseEnter += new System.EventHandler(this.pbExcluirMat_MouseEnter);
            this.lblExcluirMat.MouseLeave += new System.EventHandler(this.pbExcluirMat_MouseLeave);
            // 
            // pbExcluirMat
            // 
            this.pbExcluirMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluirMat.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluirMat.Image")));
            this.pbExcluirMat.Location = new System.Drawing.Point(212, 196);
            this.pbExcluirMat.Name = "pbExcluirMat";
            this.pbExcluirMat.Size = new System.Drawing.Size(100, 35);
            this.pbExcluirMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluirMat.TabIndex = 62;
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
            this.lblEditarMat.Location = new System.Drawing.Point(131, 202);
            this.lblEditarMat.Name = "lblEditarMat";
            this.lblEditarMat.Size = new System.Drawing.Size(50, 22);
            this.lblEditarMat.TabIndex = 61;
            this.lblEditarMat.Text = "Editar";
            this.lblEditarMat.Click += new System.EventHandler(this.btEditarMat_Click);
            this.lblEditarMat.MouseEnter += new System.EventHandler(this.pbEditarMat_MouseEnter);
            this.lblEditarMat.MouseLeave += new System.EventHandler(this.pbEditarMat_MouseLeave);
            // 
            // pbEditarMat
            // 
            this.pbEditarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarMat.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarMat.Image")));
            this.pbEditarMat.Location = new System.Drawing.Point(106, 196);
            this.pbEditarMat.Name = "pbEditarMat";
            this.pbEditarMat.Size = new System.Drawing.Size(100, 35);
            this.pbEditarMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarMat.TabIndex = 60;
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
            this.lblAdicionarMat.Location = new System.Drawing.Point(14, 202);
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
            this.pbAdicionarMat.Location = new System.Drawing.Point(0, 196);
            this.pbAdicionarMat.Name = "pbAdicionarMat";
            this.pbAdicionarMat.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionarMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionarMat.TabIndex = 58;
            this.pbAdicionarMat.TabStop = false;
            this.pbAdicionarMat.Click += new System.EventHandler(this.btAdicionarMat_Click);
            this.pbAdicionarMat.MouseEnter += new System.EventHandler(this.pbAdicionarMat_MouseEnter);
            this.pbAdicionarMat.MouseLeave += new System.EventHandler(this.pbAdicionarMat_MouseLeave);
            // 
            // listMateria
            // 
            this.listMateria.CheckBoxes = true;
            this.listMateria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1Materia,
            this.c2Quantidade,
            this.c3Unidade});
            this.listMateria.Location = new System.Drawing.Point(0, 0);
            this.listMateria.Name = "listMateria";
            this.listMateria.Size = new System.Drawing.Size(754, 190);
            this.listMateria.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listMateria.TabIndex = 0;
            this.listMateria.UseCompatibleStateImageBehavior = false;
            this.listMateria.View = System.Windows.Forms.View.Details;
            this.listMateria.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listMateria_ItemCheck);
            this.listMateria.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listMateria_ItemChecked);
            this.listMateria.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listMateria_ItemSelectionChanged);
            // 
            // c1Materia
            // 
            this.c1Materia.Text = "Matéria Prima";
            this.c1Materia.Width = 360;
            // 
            // c2Quantidade
            // 
            this.c2Quantidade.Text = "Quantidade";
            this.c2Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c2Quantidade.Width = 130;
            // 
            // c3Unidade
            // 
            this.c3Unidade.Text = "Unidade";
            this.c3Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c3Unidade.Width = 80;
            // 
            // lblLimparTela
            // 
            this.lblLimparTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLimparTela.AutoSize = true;
            this.lblLimparTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparTela.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblLimparTela.Location = new System.Drawing.Point(578, 600);
            this.lblLimparTela.Name = "lblLimparTela";
            this.lblLimparTela.Size = new System.Drawing.Size(82, 22);
            this.lblLimparTela.TabIndex = 65;
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
            this.pbLimparTela.Location = new System.Drawing.Point(569, 594);
            this.pbLimparTela.Name = "pbLimparTela";
            this.pbLimparTela.Size = new System.Drawing.Size(100, 35);
            this.pbLimparTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparTela.TabIndex = 64;
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
            this.lblVoltar.Location = new System.Drawing.Point(699, 600);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 63;
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
            this.pbVoltar.Location = new System.Drawing.Point(675, 594);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 62;
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
            this.lblSalvar.Location = new System.Drawing.Point(36, 600);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 67;
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
            this.pbSalvar.Location = new System.Drawing.Point(13, 594);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 66;
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
            this.lblSalvo.Location = new System.Drawing.Point(119, 605);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 68;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // cbUnidadeMat
            // 
            this.cbUnidadeMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMat.FormattingEnabled = true;
            this.cbUnidadeMat.LimitToList = true;
            this.cbUnidadeMat.Location = new System.Drawing.Point(415, 56);
            this.cbUnidadeMat.Name = "cbUnidadeMat";
            this.cbUnidadeMat.Size = new System.Drawing.Size(86, 26);
            this.cbUnidadeMat.TabIndex = 2;
            // 
            // cbNomeMat
            // 
            this.cbNomeMat.FormattingEnabled = true;
            this.cbNomeMat.LimitToList = true;
            this.cbNomeMat.Location = new System.Drawing.Point(134, 24);
            this.cbNomeMat.Name = "cbNomeMat";
            this.cbNomeMat.Size = new System.Drawing.Size(614, 26);
            this.cbNomeMat.TabIndex = 4;
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.LimitToList = true;
            this.cbCodigo.Location = new System.Drawing.Point(216, 24);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(245, 26);
            this.cbCodigo.TabIndex = 0;
            // 
            // FrmPosProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblLimparTela);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbLimparTela);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPosProducao";
            this.Text = "Pós Produção";
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluirMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionarMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigoOrdem;
        private Controls.ComboAuto cbCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtProduzida;
        private System.Windows.Forms.Label lblQtProduzida;
        private System.Windows.Forms.Label lblQtOrdenada;
        private System.Windows.Forms.TextBox txtQtOrdenada;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listMateria;
        private System.Windows.Forms.ColumnHeader c1Materia;
        private System.Windows.Forms.ColumnHeader c2Quantidade;
        private System.Windows.Forms.ColumnHeader c3Unidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.ComboAuto cbUnidadeMat;
        private System.Windows.Forms.Label lblUnidadeMat;
        private System.Windows.Forms.TextBox txtQtMat;
        private System.Windows.Forms.Label lblQtMat;
        private Controls.ComboAuto cbNomeMat;
        private System.Windows.Forms.Label lblNomeMat;
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
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
    }
}