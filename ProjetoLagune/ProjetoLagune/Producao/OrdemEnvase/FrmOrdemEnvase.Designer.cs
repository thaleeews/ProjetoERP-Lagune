namespace ProjetoLagune.Producao.OrdemEnvase
{
    partial class FrmOrdemEnvase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdemEnvase));
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.lblOrdEnv = new System.Windows.Forms.Label();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.grpbDados = new System.Windows.Forms.GroupBox();
            this.txtQtDisp = new System.Windows.Forms.TextBox();
            this.lblQtDisp = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbNome = new ProjetoLagune.Controls.ComboAuto();
            this.cbCodigo = new ProjetoLagune.Controls.ComboAuto();
            this.grpbEnvase = new System.Windows.Forms.GroupBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dtpProg = new System.Windows.Forms.DateTimePicker();
            this.lblProg = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.lblQt = new System.Windows.Forms.Label();
            this.listOrdEn = new System.Windows.Forms.ListView();
            this.coluna1Embalagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2UN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3QtTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbEdicao = new System.Windows.Forms.GroupBox();
            this.comboAuto1 = new ProjetoLagune.Controls.ComboAuto();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.lblQtTotal = new System.Windows.Forms.Label();
            this.txtQtTotal = new System.Windows.Forms.TextBox();
            this.lblQtUn = new System.Windows.Forms.Label();
            this.cbEmba = new ProjetoLagune.Controls.ComboAuto();
            this.lblEmba = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.pbImprimir = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            this.grpbDados.SuspendLayout();
            this.grpbEnvase.SuspendLayout();
            this.grpbEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(712, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 8;
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
            this.btX.Location = new System.Drawing.Point(737, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 9;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // lblOrdEnv
            // 
            this.lblOrdEnv.AutoSize = true;
            this.lblOrdEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdEnv.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblOrdEnv.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrdEnv.Location = new System.Drawing.Point(9, 7);
            this.lblOrdEnv.Name = "lblOrdEnv";
            this.lblOrdEnv.Size = new System.Drawing.Size(119, 15);
            this.lblOrdEnv.TabIndex = 20;
            this.lblOrdEnv.Tag = "";
            this.lblOrdEnv.Text = "ORDEM DE ENVASE";
            // 
            // pbCor
            // 
            this.pbCor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCor.Image = ((System.Drawing.Image)(resources.GetObject("pbCor.Image")));
            this.pbCor.Location = new System.Drawing.Point(0, 0);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(5, 577);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 21;
            this.pbCor.TabStop = false;
            // 
            // grpbDados
            // 
            this.grpbDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbDados.Controls.Add(this.txtQtDisp);
            this.grpbDados.Controls.Add(this.lblQtDisp);
            this.grpbDados.Controls.Add(this.lblNome);
            this.grpbDados.Controls.Add(this.lblCodigo);
            this.grpbDados.Controls.Add(this.cbNome);
            this.grpbDados.Controls.Add(this.cbCodigo);
            this.grpbDados.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.grpbDados.Location = new System.Drawing.Point(12, 26);
            this.grpbDados.Name = "grpbDados";
            this.grpbDados.Size = new System.Drawing.Size(738, 123);
            this.grpbDados.TabIndex = 0;
            this.grpbDados.TabStop = false;
            // 
            // txtQtDisp
            // 
            this.txtQtDisp.Location = new System.Drawing.Point(168, 88);
            this.txtQtDisp.Name = "txtQtDisp";
            this.txtQtDisp.ReadOnly = true;
            this.txtQtDisp.Size = new System.Drawing.Size(121, 25);
            this.txtQtDisp.TabIndex = 5;
            // 
            // lblQtDisp
            // 
            this.lblQtDisp.AutoSize = true;
            this.lblQtDisp.Location = new System.Drawing.Point(6, 91);
            this.lblQtDisp.Name = "lblQtDisp";
            this.lblQtDisp.Size = new System.Drawing.Size(156, 18);
            this.lblQtDisp.TabIndex = 4;
            this.lblQtDisp.Text = "Quantidade Disponível";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(122, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome do Produto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 18);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.LimitToList = true;
            this.cbNome.Location = new System.Drawing.Point(168, 56);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(564, 26);
            this.cbNome.TabIndex = 1;
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.LimitToList = true;
            this.cbCodigo.Location = new System.Drawing.Point(168, 24);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(121, 26);
            this.cbCodigo.TabIndex = 0;
            // 
            // grpbEnvase
            // 
            this.grpbEnvase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbEnvase.Controls.Add(this.txtLocal);
            this.grpbEnvase.Controls.Add(this.lblLocal);
            this.grpbEnvase.Controls.Add(this.dtpProg);
            this.grpbEnvase.Controls.Add(this.lblProg);
            this.grpbEnvase.Controls.Add(this.txtQt);
            this.grpbEnvase.Controls.Add(this.lblQt);
            this.grpbEnvase.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbEnvase.Location = new System.Drawing.Point(12, 156);
            this.grpbEnvase.Name = "grpbEnvase";
            this.grpbEnvase.Size = new System.Drawing.Size(738, 77);
            this.grpbEnvase.TabIndex = 1;
            this.grpbEnvase.TabStop = false;
            this.grpbEnvase.Text = "Envase";
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLocal.Location = new System.Drawing.Point(421, 44);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(177, 25);
            this.txtLocal.TabIndex = 2;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLocal.Location = new System.Drawing.Point(418, 23);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(86, 18);
            this.lblLocal.TabIndex = 9;
            this.lblLocal.Text = "Localização";
            // 
            // dtpProg
            // 
            this.dtpProg.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.dtpProg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProg.Location = new System.Drawing.Point(237, 44);
            this.dtpProg.Name = "dtpProg";
            this.dtpProg.Size = new System.Drawing.Size(113, 25);
            this.dtpProg.TabIndex = 1;
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProg.Location = new System.Drawing.Point(234, 23);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(97, 18);
            this.lblProg.TabIndex = 7;
            this.lblProg.Text = "Programação";
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQt.Location = new System.Drawing.Point(9, 44);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(177, 25);
            this.txtQt.TabIndex = 0;
            this.txtQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CaixasNumericas_KeyPress);
            // 
            // lblQt
            // 
            this.lblQt.AutoSize = true;
            this.lblQt.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQt.Location = new System.Drawing.Point(6, 23);
            this.lblQt.Name = "lblQt";
            this.lblQt.Size = new System.Drawing.Size(83, 18);
            this.lblQt.TabIndex = 6;
            this.lblQt.Text = "Quantidade";
            // 
            // listOrdEn
            // 
            this.listOrdEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listOrdEn.CheckBoxes = true;
            this.listOrdEn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Embalagem,
            this.coluna2UN,
            this.coluna3QtTotal});
            this.listOrdEn.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listOrdEn.Location = new System.Drawing.Point(12, 361);
            this.listOrdEn.Name = "listOrdEn";
            this.listOrdEn.Size = new System.Drawing.Size(738, 163);
            this.listOrdEn.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listOrdEn.TabIndex = 3;
            this.listOrdEn.UseCompatibleStateImageBehavior = false;
            this.listOrdEn.View = System.Windows.Forms.View.Details;
            this.listOrdEn.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listOrdEn_ItemCheck);
            this.listOrdEn.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listOrdEn_ItemChecked);
            this.listOrdEn.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listOrdEn_ItemSelectionChanged);
            // 
            // coluna1Embalagem
            // 
            this.coluna1Embalagem.Text = "Embalagem";
            this.coluna1Embalagem.Width = 455;
            // 
            // coluna2UN
            // 
            this.coluna2UN.Text = "Unidade";
            this.coluna2UN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2UN.Width = 123;
            // 
            // coluna3QtTotal
            // 
            this.coluna3QtTotal.Text = "Quantidade Total";
            this.coluna3QtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3QtTotal.Width = 155;
            // 
            // grpbEdicao
            // 
            this.grpbEdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbEdicao.Controls.Add(this.comboAuto1);
            this.grpbEdicao.Controls.Add(this.lblExcluir);
            this.grpbEdicao.Controls.Add(this.pbExcluir);
            this.grpbEdicao.Controls.Add(this.lblEditar);
            this.grpbEdicao.Controls.Add(this.pbEditar);
            this.grpbEdicao.Controls.Add(this.lblAdicionar);
            this.grpbEdicao.Controls.Add(this.pbAdicionar);
            this.grpbEdicao.Controls.Add(this.lblQtTotal);
            this.grpbEdicao.Controls.Add(this.txtQtTotal);
            this.grpbEdicao.Controls.Add(this.lblQtUn);
            this.grpbEdicao.Controls.Add(this.cbEmba);
            this.grpbEdicao.Controls.Add(this.lblEmba);
            this.grpbEdicao.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbEdicao.Location = new System.Drawing.Point(12, 240);
            this.grpbEdicao.Name = "grpbEdicao";
            this.grpbEdicao.Size = new System.Drawing.Size(738, 115);
            this.grpbEdicao.TabIndex = 2;
            this.grpbEdicao.TabStop = false;
            this.grpbEdicao.Text = "Edição";
            // 
            // comboAuto1
            // 
            this.comboAuto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuto1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboAuto1.FormattingEnabled = true;
            this.comboAuto1.LimitToList = true;
            this.comboAuto1.Location = new System.Drawing.Point(356, 42);
            this.comboAuto1.Name = "comboAuto1";
            this.comboAuto1.Size = new System.Drawing.Size(59, 26);
            this.comboAuto1.TabIndex = 6;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(244, 80);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 5;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(221, 74);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 58;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(140, 80);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 4;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(115, 74);
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
            this.lblAdicionar.Location = new System.Drawing.Point(22, 80);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(73, 22);
            this.lblAdicionar.TabIndex = 3;
            this.lblAdicionar.Text = "Adicionar";
            this.lblAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.lblAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.lblAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(9, 74);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(100, 35);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionar.TabIndex = 54;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            this.pbAdicionar.MouseEnter += new System.EventHandler(this.pbAdicionar_MouseEnter);
            this.pbAdicionar.MouseLeave += new System.EventHandler(this.pbAdicionar_MouseLeave);
            // 
            // lblQtTotal
            // 
            this.lblQtTotal.AutoSize = true;
            this.lblQtTotal.Enabled = false;
            this.lblQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQtTotal.Location = new System.Drawing.Point(421, 21);
            this.lblQtTotal.Name = "lblQtTotal";
            this.lblQtTotal.Size = new System.Drawing.Size(117, 18);
            this.lblQtTotal.TabIndex = 13;
            this.lblQtTotal.Text = "Quantidade Total";
            // 
            // txtQtTotal
            // 
            this.txtQtTotal.Enabled = false;
            this.txtQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQtTotal.Location = new System.Drawing.Point(421, 42);
            this.txtQtTotal.Name = "txtQtTotal";
            this.txtQtTotal.Size = new System.Drawing.Size(177, 25);
            this.txtQtTotal.TabIndex = 2;
            this.txtQtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CaixasNumericas_KeyPress);
            // 
            // lblQtUn
            // 
            this.lblQtUn.AutoSize = true;
            this.lblQtUn.Enabled = false;
            this.lblQtUn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQtUn.Location = new System.Drawing.Point(353, 21);
            this.lblQtUn.Name = "lblQtUn";
            this.lblQtUn.Size = new System.Drawing.Size(62, 18);
            this.lblQtUn.TabIndex = 11;
            this.lblQtUn.Text = "Unidade";
            // 
            // cbEmba
            // 
            this.cbEmba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmba.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbEmba.FormattingEnabled = true;
            this.cbEmba.LimitToList = true;
            this.cbEmba.Location = new System.Drawing.Point(9, 42);
            this.cbEmba.Name = "cbEmba";
            this.cbEmba.Size = new System.Drawing.Size(341, 26);
            this.cbEmba.TabIndex = 0;
            // 
            // lblEmba
            // 
            this.lblEmba.AutoSize = true;
            this.lblEmba.Enabled = false;
            this.lblEmba.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEmba.Location = new System.Drawing.Point(6, 21);
            this.lblEmba.Name = "lblEmba";
            this.lblEmba.Size = new System.Drawing.Size(87, 18);
            this.lblEmba.TabIndex = 0;
            this.lblEmba.Text = "Embalagem";
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(674, 536);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 7;
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
            this.pbVoltar.Location = new System.Drawing.Point(650, 530);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 60;
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
            this.lblSalvar.Location = new System.Drawing.Point(35, 536);
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
            this.pbSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(12, 530);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 62;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblImprimir
            // 
            this.lblImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImprimir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblImprimir.Location = new System.Drawing.Point(135, 536);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(65, 22);
            this.lblImprimir.TabIndex = 6;
            this.lblImprimir.Text = "Imprimir";
            this.lblImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.lblImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.lblImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // pbImprimir
            // 
            this.pbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("pbImprimir.Image")));
            this.pbImprimir.Location = new System.Drawing.Point(118, 530);
            this.pbImprimir.Name = "pbImprimir";
            this.pbImprimir.Size = new System.Drawing.Size(100, 35);
            this.pbImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImprimir.TabIndex = 62;
            this.pbImprimir.TabStop = false;
            this.pbImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.pbImprimir.MouseEnter += new System.EventHandler(this.pbImprimir_MouseEnter);
            this.pbImprimir.MouseLeave += new System.EventHandler(this.pbImprimir_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(224, 541);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 69;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // FrmOrdemEnvase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(762, 577);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.pbImprimir);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.grpbEdicao);
            this.Controls.Add(this.listOrdEn);
            this.Controls.Add(this.grpbEnvase);
            this.Controls.Add(this.grpbDados);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.lblOrdEnv);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdemEnvase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Envase";
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            this.grpbDados.ResumeLayout(false);
            this.grpbDados.PerformLayout();
            this.grpbEnvase.ResumeLayout(false);
            this.grpbEnvase.PerformLayout();
            this.grpbEdicao.ResumeLayout(false);
            this.grpbEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label lblOrdEnv;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.GroupBox grpbDados;
        private System.Windows.Forms.TextBox txtQtDisp;
        private System.Windows.Forms.Label lblQtDisp;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private Controls.ComboAuto cbNome;
        private Controls.ComboAuto cbCodigo;
        private System.Windows.Forms.GroupBox grpbEnvase;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Label lblQt;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DateTimePicker dtpProg;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.ListView listOrdEn;
        private System.Windows.Forms.ColumnHeader coluna1Embalagem;
        private System.Windows.Forms.ColumnHeader coluna2UN;
        private System.Windows.Forms.ColumnHeader coluna3QtTotal;
        private System.Windows.Forms.GroupBox grpbEdicao;
        private System.Windows.Forms.Label lblQtTotal;
        private System.Windows.Forms.TextBox txtQtTotal;
        private System.Windows.Forms.Label lblQtUn;
        private Controls.ComboAuto cbEmba;
        private System.Windows.Forms.Label lblEmba;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.PictureBox pbImprimir;
        private Controls.ComboAuto comboAuto1;
        private System.Windows.Forms.Label lblSalvo;
    }
}