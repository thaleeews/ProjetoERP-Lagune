namespace ProjetoLagune.EntradasSaidas.AcompanhamentoCarga
{
    partial class FrmPesquisaAcom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaAcom));
            this.listPesq = new System.Windows.Forms.ListView();
            this.coluna1Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2NumeroNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Transp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCliente = new ProjetoLagune.Controls.ComboAuto();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btX = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.pbSelecionar = new System.Windows.Forms.PictureBox();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.cbTransp = new ProjetoLagune.Controls.ComboAuto();
            this.lblTransp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // listPesq
            // 
            this.listPesq.CheckBoxes = true;
            this.listPesq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Cliente,
            this.coluna2NumeroNota,
            this.coluna3Transp});
            this.listPesq.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listPesq.Location = new System.Drawing.Point(12, 129);
            this.listPesq.Name = "listPesq";
            this.listPesq.Size = new System.Drawing.Size(758, 236);
            this.listPesq.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPesq.TabIndex = 1;
            this.listPesq.UseCompatibleStateImageBehavior = false;
            this.listPesq.View = System.Windows.Forms.View.Details;
            // 
            // coluna1Cliente
            // 
            this.coluna1Cliente.Text = "Cliente";
            this.coluna1Cliente.Width = 300;
            // 
            // coluna2NumeroNota
            // 
            this.coluna2NumeroNota.Text = "Número da Nota";
            this.coluna2NumeroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2NumeroNota.Width = 150;
            // 
            // coluna3Transp
            // 
            this.coluna3Transp.Text = "Transportadora";
            this.coluna3Transp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Transp.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransp);
            this.groupBox1.Controls.Add(this.cbTransp);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.LimitToList = true;
            this.cbCliente.Location = new System.Drawing.Point(124, 25);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(627, 26);
            this.cbCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCliente.Location = new System.Drawing.Point(6, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(757, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 4;
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
            this.btMin.Location = new System.Drawing.Point(732, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 5;
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
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = "PESQUISA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(670, 369);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 20;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltarPesq_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbSelecionar
            // 
            this.pbSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("pbSelecionar.Image")));
            this.pbSelecionar.Location = new System.Drawing.Point(12, 369);
            this.pbSelecionar.Name = "pbSelecionar";
            this.pbSelecionar.Size = new System.Drawing.Size(100, 35);
            this.pbSelecionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelecionar.TabIndex = 21;
            this.pbSelecionar.TabStop = false;
            this.pbSelecionar.Click += new System.EventHandler(this.btSelecionarPesq_Click);
            this.pbSelecionar.MouseEnter += new System.EventHandler(this.pbSelecionar_MouseEnter);
            this.pbSelecionar.MouseLeave += new System.EventHandler(this.pbSelecionar_MouseLeave);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelecionar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSelecionar.Location = new System.Drawing.Point(23, 375);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(78, 22);
            this.lblSelecionar.TabIndex = 2;
            this.lblSelecionar.Text = "Selecionar";
            this.lblSelecionar.Click += new System.EventHandler(this.btSelecionarPesq_Click);
            this.lblSelecionar.MouseEnter += new System.EventHandler(this.pbSelecionar_MouseEnter);
            this.lblSelecionar.MouseLeave += new System.EventHandler(this.pbSelecionar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(694, 375);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 3;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltarPesq_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // cbTransp
            // 
            this.cbTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbTransp.FormattingEnabled = true;
            this.cbTransp.LimitToList = true;
            this.cbTransp.Location = new System.Drawing.Point(124, 57);
            this.cbTransp.Name = "cbTransp";
            this.cbTransp.Size = new System.Drawing.Size(627, 26);
            this.cbTransp.TabIndex = 2;
            // 
            // lblTransp
            // 
            this.lblTransp.AutoSize = true;
            this.lblTransp.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblTransp.Location = new System.Drawing.Point(6, 60);
            this.lblTransp.Name = "lblTransp";
            this.lblTransp.Size = new System.Drawing.Size(112, 18);
            this.lblTransp.TabIndex = 3;
            this.lblTransp.Text = "Transportadora:";
            // 
            // FrmPesquisaAcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(782, 410);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.pbSelecionar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listPesq);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisaAcom";
            this.Text = "Pesquisa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPesq;
        private System.Windows.Forms.ColumnHeader coluna1Cliente;
        private System.Windows.Forms.ColumnHeader coluna2NumeroNota;
        private System.Windows.Forms.ColumnHeader coluna3Transp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private Controls.ComboAuto cbCliente;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.PictureBox pbSelecionar;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblTransp;
        private Controls.ComboAuto cbTransp;
    }
}