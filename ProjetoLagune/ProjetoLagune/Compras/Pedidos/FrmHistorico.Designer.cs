namespace ProjetoLagune.Compras.Pedidos
{
    partial class FrmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorico));
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.listHist = new System.Windows.Forms.ListView();
            this.C1Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C2Forn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C3ValorT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.pbSelecionar = new System.Windows.Forms.PictureBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(736, 0);
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
            this.btX.Location = new System.Drawing.Point(761, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 25;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistorico.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblHistorico.ForeColor = System.Drawing.Color.DimGray;
            this.lblHistorico.Location = new System.Drawing.Point(9, 7);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(143, 15);
            this.lblHistorico.TabIndex = 27;
            this.lblHistorico.Tag = "";
            this.lblHistorico.Text = "HISTÓRICO DE PEDIDOS";
            // 
            // listHist
            // 
            this.listHist.CheckBoxes = true;
            this.listHist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.C1Cod,
            this.C2Forn,
            this.C3ValorT});
            this.listHist.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHist.Location = new System.Drawing.Point(12, 26);
            this.listHist.Name = "listHist";
            this.listHist.Size = new System.Drawing.Size(762, 309);
            this.listHist.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listHist.TabIndex = 28;
            this.listHist.UseCompatibleStateImageBehavior = false;
            this.listHist.View = System.Windows.Forms.View.Details;
            // 
            // C1Cod
            // 
            this.C1Cod.Text = "Código";
            this.C1Cod.Width = 109;
            // 
            // C2Forn
            // 
            this.C2Forn.Text = "Fornecedor";
            this.C2Forn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C2Forn.Width = 455;
            // 
            // C3ValorT
            // 
            this.C3ValorT.Text = "Valor Total";
            this.C3ValorT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C3ValorT.Width = 194;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelecionar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblSelecionar.Location = new System.Drawing.Point(23, 347);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(78, 22);
            this.lblSelecionar.TabIndex = 34;
            this.lblSelecionar.Text = "Selecionar";
            this.lblSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            this.lblSelecionar.MouseEnter += new System.EventHandler(this.pbSelecionar_MouseEnter);
            this.lblSelecionar.MouseLeave += new System.EventHandler(this.pbSelecionar_MouseLeave);
            // 
            // pbSelecionar
            // 
            this.pbSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("pbSelecionar.Image")));
            this.pbSelecionar.Location = new System.Drawing.Point(12, 341);
            this.pbSelecionar.Name = "pbSelecionar";
            this.pbSelecionar.Size = new System.Drawing.Size(100, 35);
            this.pbSelecionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelecionar.TabIndex = 35;
            this.pbSelecionar.TabStop = false;
            this.pbSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            this.pbSelecionar.MouseEnter += new System.EventHandler(this.pbSelecionar_MouseEnter);
            this.pbSelecionar.MouseLeave += new System.EventHandler(this.pbSelecionar_MouseLeave);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(698, 347);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 36;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(674, 341);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 37;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(786, 382);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.pbSelecionar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listHist);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistorico";
            this.Text = "Histórico de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.ListView listHist;
        private System.Windows.Forms.ColumnHeader C1Cod;
        private System.Windows.Forms.ColumnHeader C2Forn;
        private System.Windows.Forms.ColumnHeader C3ValorT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.PictureBox pbSelecionar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
    }
}