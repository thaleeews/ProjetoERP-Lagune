namespace ProjetoLagune.Estoque.Transferencia
{
    partial class FrmAprovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprovar));
            this.listTransf = new System.Windows.Forms.ListView();
            this.coluna1Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Qt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5Armaz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbSelecionado = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbArmazem = new ProjetoLagune.Controls.ComboAuto();
            this.cbNome = new ProjetoLagune.Controls.ComboAuto();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblAprovar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.pbSelecionar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.lblConcluir = new System.Windows.Forms.Label();
            this.pbConcluir = new System.Windows.Forms.PictureBox();
            this.grpbSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // listTransf
            // 
            this.listTransf.CheckBoxes = true;
            this.listTransf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Produto,
            this.coluna2Lote,
            this.coluna3Qt,
            this.coluna4Local,
            this.coluna5Armaz});
            this.listTransf.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listTransf.Location = new System.Drawing.Point(13, 31);
            this.listTransf.Name = "listTransf";
            this.listTransf.Size = new System.Drawing.Size(857, 236);
            this.listTransf.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listTransf.TabIndex = 1;
            this.listTransf.UseCompatibleStateImageBehavior = false;
            this.listTransf.View = System.Windows.Forms.View.Details;
            this.listTransf.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listTransf_ItemCheck);
            this.listTransf.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listTransf_ItemChecked);
            this.listTransf.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listTransf_ItemSelectionChanged);
            // 
            // coluna1Produto
            // 
            this.coluna1Produto.Text = "Nome do Produto";
            this.coluna1Produto.Width = 278;
            // 
            // coluna2Lote
            // 
            this.coluna2Lote.Text = "Lote";
            this.coluna2Lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2Lote.Width = 169;
            // 
            // coluna3Qt
            // 
            this.coluna3Qt.Text = "Quantidade";
            this.coluna3Qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Qt.Width = 135;
            // 
            // coluna4Local
            // 
            this.coluna4Local.Text = "Localização";
            this.coluna4Local.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4Local.Width = 120;
            // 
            // coluna5Armaz
            // 
            this.coluna5Armaz.Text = "Armazém";
            this.coluna5Armaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna5Armaz.Width = 150;
            // 
            // grpbSelecionado
            // 
            this.grpbSelecionado.Controls.Add(this.txtQuantidade);
            this.grpbSelecionado.Controls.Add(this.lblQuantidade);
            this.grpbSelecionado.Controls.Add(this.cbArmazem);
            this.grpbSelecionado.Controls.Add(this.cbNome);
            this.grpbSelecionado.Controls.Add(this.txtLocal);
            this.grpbSelecionado.Controls.Add(this.lblArmazem);
            this.grpbSelecionado.Controls.Add(this.lblLocal);
            this.grpbSelecionado.Controls.Add(this.txtLote);
            this.grpbSelecionado.Controls.Add(this.lblLote);
            this.grpbSelecionado.Controls.Add(this.lblNome);
            this.grpbSelecionado.Location = new System.Drawing.Point(13, 314);
            this.grpbSelecionado.Name = "grpbSelecionado";
            this.grpbSelecionado.Size = new System.Drawing.Size(857, 86);
            this.grpbSelecionado.TabIndex = 2;
            this.grpbSelecionado.TabStop = false;
            this.grpbSelecionado.Text = "Selecionado";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(716, 52);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(135, 25);
            this.txtQuantidade.TabIndex = 11;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Enabled = false;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(624, 55);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cbArmazem
            // 
            this.cbArmazem.Enabled = false;
            this.cbArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbArmazem.FormattingEnabled = true;
            this.cbArmazem.LimitToList = true;
            this.cbArmazem.Location = new System.Drawing.Point(348, 52);
            this.cbArmazem.Name = "cbArmazem";
            this.cbArmazem.Size = new System.Drawing.Size(270, 26);
            this.cbArmazem.TabIndex = 9;
            // 
            // cbNome
            // 
            this.cbNome.Enabled = false;
            this.cbNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbNome.FormattingEnabled = true;
            this.cbNome.LimitToList = true;
            this.cbNome.Location = new System.Drawing.Point(137, 20);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(481, 26);
            this.cbNome.TabIndex = 8;
            // 
            // txtLocal
            // 
            this.txtLocal.Enabled = false;
            this.txtLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLocal.Location = new System.Drawing.Point(137, 52);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(123, 25);
            this.txtLocal.TabIndex = 2;
            // 
            // lblArmazem
            // 
            this.lblArmazem.AutoSize = true;
            this.lblArmazem.Enabled = false;
            this.lblArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblArmazem.Location = new System.Drawing.Point(266, 55);
            this.lblArmazem.Name = "lblArmazem";
            this.lblArmazem.Size = new System.Drawing.Size(76, 18);
            this.lblArmazem.TabIndex = 7;
            this.lblArmazem.Text = "Armazém:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Enabled = false;
            this.lblLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLocal.Location = new System.Drawing.Point(6, 55);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(89, 18);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Localização:";
            // 
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLote.Location = new System.Drawing.Point(671, 20);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(180, 25);
            this.txtLote.TabIndex = 1;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Enabled = false;
            this.lblLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLote.Location = new System.Drawing.Point(624, 23);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(41, 18);
            this.lblLote.TabIndex = 2;
            this.lblLote.Text = "Lote:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNome.Location = new System.Drawing.Point(6, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(857, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 7;
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
            this.btMin.Location = new System.Drawing.Point(832, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 8;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblAprovar
            // 
            this.lblAprovar.AutoSize = true;
            this.lblAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAprovar.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblAprovar.ForeColor = System.Drawing.Color.DimGray;
            this.lblAprovar.Location = new System.Drawing.Point(9, 7);
            this.lblAprovar.Name = "lblAprovar";
            this.lblAprovar.Size = new System.Drawing.Size(122, 15);
            this.lblAprovar.TabIndex = 9;
            this.lblAprovar.Tag = "";
            this.lblAprovar.Text = "APROVAR ENTRADA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(794, 412);
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
            this.pbVoltar.Location = new System.Drawing.Point(770, 406);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 23;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelecionar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSelecionar.Location = new System.Drawing.Point(25, 279);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(78, 22);
            this.lblSelecionar.TabIndex = 30;
            this.lblSelecionar.Text = "selecionar";
            this.lblSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            this.lblSelecionar.MouseEnter += new System.EventHandler(this.pbSelecionar_MouseEnter);
            this.lblSelecionar.MouseLeave += new System.EventHandler(this.pbSelecionar_MouseLeave);
            // 
            // pbSelecionar
            // 
            this.pbSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("pbSelecionar.Image")));
            this.pbSelecionar.Location = new System.Drawing.Point(13, 273);
            this.pbSelecionar.Name = "pbSelecionar";
            this.pbSelecionar.Size = new System.Drawing.Size(100, 35);
            this.pbSelecionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelecionar.TabIndex = 29;
            this.pbSelecionar.TabStop = false;
            this.pbSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSalvar.Location = new System.Drawing.Point(31, 412);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(64, 22);
            this.lblSalvar.TabIndex = 3;
            this.lblSalvar.Text = "Aprovar";
            this.lblSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.lblSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.lblSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(13, 406);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(100, 35);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 31;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbSalvar.MouseEnter += new System.EventHandler(this.pbSalvar_MouseEnter);
            this.pbSalvar.MouseLeave += new System.EventHandler(this.pbSalvar_MouseLeave);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Font = new System.Drawing.Font("Kano regular", 12F);
            this.lblSalvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.lblSalvo.Location = new System.Drawing.Point(119, 417);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(46, 16);
            this.lblSalvo.TabIndex = 34;
            this.lblSalvo.Text = "Salvo";
            this.lblSalvo.Visible = false;
            // 
            // lblConcluir
            // 
            this.lblConcluir.AutoSize = true;
            this.lblConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblConcluir.Location = new System.Drawing.Point(136, 279);
            this.lblConcluir.Name = "lblConcluir";
            this.lblConcluir.Size = new System.Drawing.Size(66, 22);
            this.lblConcluir.TabIndex = 35;
            this.lblConcluir.Text = "Concluir";
            this.lblConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.lblConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.lblConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // pbConcluir
            // 
            this.pbConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbConcluir.Image")));
            this.pbConcluir.Location = new System.Drawing.Point(119, 273);
            this.pbConcluir.Name = "pbConcluir";
            this.pbConcluir.Size = new System.Drawing.Size(100, 35);
            this.pbConcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConcluir.TabIndex = 36;
            this.pbConcluir.TabStop = false;
            this.pbConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.pbConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.pbConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // FrmAprovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(882, 449);
            this.Controls.Add(this.lblConcluir);
            this.Controls.Add(this.pbConcluir);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.pbSelecionar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAprovar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.grpbSelecionado);
            this.Controls.Add(this.listTransf);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAprovar";
            this.Text = "Transferência";
            this.Load += new System.EventHandler(this.FrmAprovar_Load);
            this.grpbSelecionado.ResumeLayout(false);
            this.grpbSelecionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listTransf;
        private System.Windows.Forms.ColumnHeader coluna1Produto;
        private System.Windows.Forms.ColumnHeader coluna2Lote;
        private System.Windows.Forms.ColumnHeader coluna3Qt;
        private System.Windows.Forms.ColumnHeader coluna4Local;
        private System.Windows.Forms.ColumnHeader coluna5Armaz;
        private System.Windows.Forms.GroupBox grpbSelecionado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblArmazem;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblAprovar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.PictureBox pbSelecionar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.Label lblSalvo;
        private System.Windows.Forms.Label lblConcluir;
        private System.Windows.Forms.PictureBox pbConcluir;
        private Controls.ComboAuto cbNome;
        private Controls.ComboAuto cbArmazem;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}