namespace ProjetoLagune.Estoque
{
    partial class FrmAcertoEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcertoEst));
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.rdEmbalagem = new System.Windows.Forms.RadioButton();
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.rdMateria = new System.Windows.Forms.RadioButton();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbArmazem = new System.Windows.Forms.ComboBox();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.listAcerto = new System.Windows.Forms.ListView();
            this.coluna1Lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQtTotal = new System.Windows.Forms.Label();
            this.txtQtTotal = new System.Windows.Forms.TextBox();
            this.grpEdicao = new System.Windows.Forms.GroupBox();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.llblLocal = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblQt = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblConcluir = new System.Windows.Forms.Label();
            this.pbConcluir = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.grpProduto.SuspendLayout();
            this.grpEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.rdEmbalagem);
            this.grpProduto.Controls.Add(this.rdProduto);
            this.grpProduto.Controls.Add(this.rdMateria);
            this.grpProduto.Controls.Add(this.lblProduto);
            this.grpProduto.Controls.Add(this.cbProduto);
            this.grpProduto.Controls.Add(this.cbArmazem);
            this.grpProduto.Controls.Add(this.lblArmazem);
            this.grpProduto.Location = new System.Drawing.Point(13, 24);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(629, 100);
            this.grpProduto.TabIndex = 1;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            // 
            // rdEmbalagem
            // 
            this.rdEmbalagem.AutoSize = true;
            this.rdEmbalagem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdEmbalagem.Location = new System.Drawing.Point(395, 72);
            this.rdEmbalagem.Name = "rdEmbalagem";
            this.rdEmbalagem.Size = new System.Drawing.Size(105, 22);
            this.rdEmbalagem.TabIndex = 5;
            this.rdEmbalagem.TabStop = true;
            this.rdEmbalagem.Text = "Embalagem";
            this.rdEmbalagem.UseVisualStyleBackColor = true;
            this.rdEmbalagem.CheckedChanged += new System.EventHandler(this.rdEmbalagem_CheckedChanged);
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdProduto.Location = new System.Drawing.Point(395, 44);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(138, 22);
            this.rdProduto.TabIndex = 4;
            this.rdProduto.TabStop = true;
            this.rdProduto.Text = "Produto Acabado";
            this.rdProduto.UseVisualStyleBackColor = true;
            this.rdProduto.CheckedChanged += new System.EventHandler(this.rdProduto_CheckedChanged);
            // 
            // rdMateria
            // 
            this.rdMateria.AutoSize = true;
            this.rdMateria.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdMateria.Location = new System.Drawing.Point(395, 16);
            this.rdMateria.Name = "rdMateria";
            this.rdMateria.Size = new System.Drawing.Size(120, 22);
            this.rdMateria.TabIndex = 3;
            this.rdMateria.TabStop = true;
            this.rdMateria.Text = "Matéria Prima";
            this.rdMateria.UseVisualStyleBackColor = true;
            this.rdMateria.CheckedChanged += new System.EventHandler(this.rdMateria_CheckedChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProduto.Location = new System.Drawing.Point(6, 55);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto:";
            // 
            // cbProduto
            // 
            this.cbProduto.Enabled = false;
            this.cbProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(88, 52);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(289, 26);
            this.cbProduto.TabIndex = 2;
            // 
            // cbArmazem
            // 
            this.cbArmazem.Enabled = false;
            this.cbArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbArmazem.FormattingEnabled = true;
            this.cbArmazem.Location = new System.Drawing.Point(88, 20);
            this.cbArmazem.Name = "cbArmazem";
            this.cbArmazem.Size = new System.Drawing.Size(289, 26);
            this.cbArmazem.TabIndex = 1;
            // 
            // lblArmazem
            // 
            this.lblArmazem.AutoSize = true;
            this.lblArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblArmazem.Location = new System.Drawing.Point(6, 23);
            this.lblArmazem.Name = "lblArmazem";
            this.lblArmazem.Size = new System.Drawing.Size(76, 18);
            this.lblArmazem.TabIndex = 0;
            this.lblArmazem.Text = "Armazém:";
            // 
            // listAcerto
            // 
            this.listAcerto.CheckBoxes = true;
            this.listAcerto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Lote,
            this.coluna2Quantidade,
            this.coluna3Validade,
            this.coluna4Local});
            this.listAcerto.Enabled = false;
            this.listAcerto.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listAcerto.Location = new System.Drawing.Point(13, 131);
            this.listAcerto.Name = "listAcerto";
            this.listAcerto.Size = new System.Drawing.Size(629, 198);
            this.listAcerto.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAcerto.TabIndex = 2;
            this.listAcerto.UseCompatibleStateImageBehavior = false;
            this.listAcerto.View = System.Windows.Forms.View.Details;
            this.listAcerto.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listAcerto_ItemCheck);
            this.listAcerto.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listAcerto_ItemChecked);
            this.listAcerto.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listAcerto_ItemSelectionChanged);
            // 
            // coluna1Lote
            // 
            this.coluna1Lote.Text = "Lote";
            this.coluna1Lote.Width = 200;
            // 
            // coluna2Quantidade
            // 
            this.coluna2Quantidade.Text = "Quantidade";
            this.coluna2Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2Quantidade.Width = 187;
            // 
            // coluna3Validade
            // 
            this.coluna3Validade.Text = "Validade";
            this.coluna3Validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Validade.Width = 118;
            // 
            // coluna4Local
            // 
            this.coluna4Local.Text = "Localização";
            this.coluna4Local.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4Local.Width = 120;
            // 
            // lblQtTotal
            // 
            this.lblQtTotal.AutoSize = true;
            this.lblQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQtTotal.Location = new System.Drawing.Point(346, 343);
            this.lblQtTotal.Name = "lblQtTotal";
            this.lblQtTotal.Size = new System.Drawing.Size(120, 18);
            this.lblQtTotal.TabIndex = 2;
            this.lblQtTotal.Text = "Quantidade Total:";
            // 
            // txtQtTotal
            // 
            this.txtQtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.txtQtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtTotal.Enabled = false;
            this.txtQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQtTotal.Location = new System.Drawing.Point(472, 343);
            this.txtQtTotal.Name = "txtQtTotal";
            this.txtQtTotal.Size = new System.Drawing.Size(170, 18);
            this.txtQtTotal.TabIndex = 3;
            this.txtQtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpEdicao
            // 
            this.grpEdicao.Controls.Add(this.mtxtValidade);
            this.grpEdicao.Controls.Add(this.txtLocal);
            this.grpEdicao.Controls.Add(this.llblLocal);
            this.grpEdicao.Controls.Add(this.lblValidade);
            this.grpEdicao.Controls.Add(this.lblQt);
            this.grpEdicao.Controls.Add(this.txtQuantidade);
            this.grpEdicao.Controls.Add(this.txtLote);
            this.grpEdicao.Controls.Add(this.lblLote);
            this.grpEdicao.Enabled = false;
            this.grpEdicao.Location = new System.Drawing.Point(11, 377);
            this.grpEdicao.Name = "grpEdicao";
            this.grpEdicao.Size = new System.Drawing.Size(629, 88);
            this.grpEdicao.TabIndex = 3;
            this.grpEdicao.TabStop = false;
            this.grpEdicao.Text = "Edição";
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtValidade.Location = new System.Drawing.Point(369, 20);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(100, 25);
            this.mtxtValidade.TabIndex = 2;
            this.mtxtValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLocal.Location = new System.Drawing.Point(369, 51);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(170, 25);
            this.txtLocal.TabIndex = 3;
            // 
            // llblLocal
            // 
            this.llblLocal.AutoSize = true;
            this.llblLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.llblLocal.Location = new System.Drawing.Point(274, 54);
            this.llblLocal.Name = "llblLocal";
            this.llblLocal.Size = new System.Drawing.Size(89, 18);
            this.llblLocal.TabIndex = 11;
            this.llblLocal.Text = "Localização:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValidade.Location = new System.Drawing.Point(274, 23);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(68, 18);
            this.lblValidade.TabIndex = 10;
            this.lblValidade.Text = "Validade:";
            // 
            // lblQt
            // 
            this.lblQt.AutoSize = true;
            this.lblQt.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQt.Location = new System.Drawing.Point(6, 54);
            this.lblQt.Name = "lblQt";
            this.lblQt.Size = new System.Drawing.Size(86, 18);
            this.lblQt.TabIndex = 9;
            this.lblQt.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(98, 51);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(170, 25);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLote.Location = new System.Drawing.Point(98, 20);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(170, 25);
            this.txtLote.TabIndex = 0;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLote.Location = new System.Drawing.Point(6, 23);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(41, 18);
            this.lblLote.TabIndex = 7;
            this.lblLote.Text = "Lote:";
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(629, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 9;
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
            this.btMin.Location = new System.Drawing.Point(604, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 0;
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
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 13;
            this.label3.Tag = "";
            this.label3.Text = "ACERTO DE ESTOQUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(542, 471);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 19;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(13, 471);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 21;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(566, 477);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 7;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(36, 477);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(54, 22);
            this.lblSalvar.TabIndex = 5;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblConcluir
            // 
            this.lblConcluir.AutoSize = true;
            this.lblConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblConcluir.Location = new System.Drawing.Point(30, 341);
            this.lblConcluir.Name = "lblConcluir";
            this.lblConcluir.Size = new System.Drawing.Size(66, 22);
            this.lblConcluir.TabIndex = 1;
            this.lblConcluir.Text = "Concluir";
            this.lblConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.lblConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // pbConcluir
            // 
            this.pbConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbConcluir.Image")));
            this.pbConcluir.Location = new System.Drawing.Point(13, 335);
            this.pbConcluir.Name = "pbConcluir";
            this.pbConcluir.Size = new System.Drawing.Size(100, 35);
            this.pbConcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConcluir.TabIndex = 25;
            this.pbConcluir.TabStop = false;
            this.pbConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.pbConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(144, 341);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 2;
            this.lblEditar.Text = "Editar";
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(119, 335);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 27;
            this.pbEditar.TabStop = false;
            this.pbEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.pbEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblExcluir.Location = new System.Drawing.Point(247, 341);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(56, 22);
            this.lblExcluir.TabIndex = 3;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.lblExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(225, 335);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(100, 35);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExcluir.TabIndex = 29;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.MouseEnter += new System.EventHandler(this.pbExcluir_MouseEnter);
            this.pbExcluir.MouseLeave += new System.EventHandler(this.pbExcluir_MouseLeave);
            // 
            // FrmAcertoEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(654, 516);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.lblConcluir);
            this.Controls.Add(this.pbConcluir);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.grpEdicao);
            this.Controls.Add(this.txtQtTotal);
            this.Controls.Add(this.lblQtTotal);
            this.Controls.Add(this.listAcerto);
            this.Controls.Add(this.grpProduto);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAcertoEst";
            this.Text = "Acerto de Estoque";
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.grpEdicao.ResumeLayout(false);
            this.grpEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.RadioButton rdEmbalagem;
        private System.Windows.Forms.RadioButton rdProduto;
        private System.Windows.Forms.RadioButton rdMateria;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbArmazem;
        private System.Windows.Forms.Label lblArmazem;
        private System.Windows.Forms.ListView listAcerto;
        private System.Windows.Forms.ColumnHeader coluna1Lote;
        private System.Windows.Forms.ColumnHeader coluna2Quantidade;
        private System.Windows.Forms.ColumnHeader coluna3Validade;
        private System.Windows.Forms.ColumnHeader coluna4Local;
        private System.Windows.Forms.Label lblQtTotal;
        private System.Windows.Forms.TextBox txtQtTotal;
        private System.Windows.Forms.GroupBox grpEdicao;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label llblLocal;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblQt;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblConcluir;
        private System.Windows.Forms.PictureBox pbConcluir;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox pbExcluir;
    }
}