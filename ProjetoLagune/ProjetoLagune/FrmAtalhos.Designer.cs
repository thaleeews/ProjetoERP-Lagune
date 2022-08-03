namespace ProjetoLagune
{
    partial class FrmAtalhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtalhos));
            this.btX = new System.Windows.Forms.Button();
            this.lblAtalho1 = new System.Windows.Forms.Label();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.lblCadForn = new System.Windows.Forms.Label();
            this.lblAtalho3 = new System.Windows.Forms.Label();
            this.lblAtalho2 = new System.Windows.Forms.Label();
            this.lblAtalho4 = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblConcluir = new System.Windows.Forms.Label();
            this.pbConcluir = new System.Windows.Forms.PictureBox();
            this.cbA4 = new ProjetoLagune.Controls.ComboAuto();
            this.cbA3 = new ProjetoLagune.Controls.ComboAuto();
            this.cbA2 = new ProjetoLagune.Controls.ComboAuto();
            this.cbA1 = new ProjetoLagune.Controls.ComboAuto();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(269, 6);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 3;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            // 
            // lblAtalho1
            // 
            this.lblAtalho1.AutoSize = true;
            this.lblAtalho1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblAtalho1.Location = new System.Drawing.Point(12, 35);
            this.lblAtalho1.Name = "lblAtalho1";
            this.lblAtalho1.Size = new System.Drawing.Size(68, 19);
            this.lblAtalho1.TabIndex = 4;
            this.lblAtalho1.Text = "Atalho 1:";
            // 
            // pbCor
            // 
            this.pbCor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCor.Image = ((System.Drawing.Image)(resources.GetObject("pbCor.Image")));
            this.pbCor.Location = new System.Drawing.Point(0, 0);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(5, 206);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 5;
            this.pbCor.TabStop = false;
            // 
            // lblCadForn
            // 
            this.lblCadForn.AutoSize = true;
            this.lblCadForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadForn.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.lblCadForn.ForeColor = System.Drawing.Color.DimGray;
            this.lblCadForn.Location = new System.Drawing.Point(9, 7);
            this.lblCadForn.Name = "lblCadForn";
            this.lblCadForn.Size = new System.Drawing.Size(183, 15);
            this.lblCadForn.TabIndex = 20;
            this.lblCadForn.Tag = "";
            this.lblCadForn.Text = "CONFIGURAÇÕES DE ATALHOS";
            // 
            // lblAtalho3
            // 
            this.lblAtalho3.AutoSize = true;
            this.lblAtalho3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblAtalho3.Location = new System.Drawing.Point(12, 101);
            this.lblAtalho3.Name = "lblAtalho3";
            this.lblAtalho3.Size = new System.Drawing.Size(71, 19);
            this.lblAtalho3.TabIndex = 22;
            this.lblAtalho3.Text = "Atalho 3:";
            // 
            // lblAtalho2
            // 
            this.lblAtalho2.AutoSize = true;
            this.lblAtalho2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblAtalho2.Location = new System.Drawing.Point(12, 68);
            this.lblAtalho2.Name = "lblAtalho2";
            this.lblAtalho2.Size = new System.Drawing.Size(71, 19);
            this.lblAtalho2.TabIndex = 23;
            this.lblAtalho2.Text = "Atalho 2:";
            // 
            // lblAtalho4
            // 
            this.lblAtalho4.AutoSize = true;
            this.lblAtalho4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblAtalho4.Location = new System.Drawing.Point(12, 134);
            this.lblAtalho4.Name = "lblAtalho4";
            this.lblAtalho4.Size = new System.Drawing.Size(72, 19);
            this.lblAtalho4.TabIndex = 24;
            this.lblAtalho4.Text = "Atalho 4:";
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(254, 170);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 29;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(230, 164);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 28;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblConcluir
            // 
            this.lblConcluir.AutoSize = true;
            this.lblConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConcluir.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblConcluir.Location = new System.Drawing.Point(33, 170);
            this.lblConcluir.Name = "lblConcluir";
            this.lblConcluir.Size = new System.Drawing.Size(66, 22);
            this.lblConcluir.TabIndex = 31;
            this.lblConcluir.Text = "Concluir";
            this.lblConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.lblConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.lblConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // pbConcluir
            // 
            this.pbConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbConcluir.Image")));
            this.pbConcluir.Location = new System.Drawing.Point(16, 164);
            this.pbConcluir.Name = "pbConcluir";
            this.pbConcluir.Size = new System.Drawing.Size(100, 35);
            this.pbConcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConcluir.TabIndex = 30;
            this.pbConcluir.TabStop = false;
            this.pbConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            this.pbConcluir.MouseEnter += new System.EventHandler(this.pbConcluir_MouseEnter);
            this.pbConcluir.MouseLeave += new System.EventHandler(this.pbConcluir_MouseLeave);
            // 
            // cbA4
            // 
            this.cbA4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cbA4.FormattingEnabled = true;
            this.cbA4.Items.AddRange(new object[] {
            "Cadastro de Produtos",
            "Cadastro de Fornecedores",
            "Cadastro de Clientes",
            "Cadastro de Usuários",
            "---------------------------------",
            "Entrada de Nota Fiscal",
            "Saída de Nota Fiscal",
            "Acompanhamento de Carga",
            "---------------------------------",
            "Acerto de Estoque",
            "Transferência",
            "---------------------------------",
            "Ordem de Produção",
            "Ordem de Envase",
            "---------------------------------",
            "Novo Pedido de Compra",
            "---------------------------------",
            "Orçamento",
            "Novo Pedido",
            "---------------------------------",
            "Despesas"});
            this.cbA4.LimitToList = true;
            this.cbA4.Location = new System.Drawing.Point(106, 131);
            this.cbA4.Name = "cbA4";
            this.cbA4.Size = new System.Drawing.Size(224, 27);
            this.cbA4.TabIndex = 27;
            // 
            // cbA3
            // 
            this.cbA3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cbA3.FormattingEnabled = true;
            this.cbA3.Items.AddRange(new object[] {
            "Cadastro de Produtos",
            "Cadastro de Fornecedores",
            "Cadastro de Clientes",
            "Cadastro de Usuários",
            "---------------------------------",
            "Entrada de Nota Fiscal",
            "Saída de Nota Fiscal",
            "Acompanhamento de Carga",
            "---------------------------------",
            "Acerto de Estoque",
            "Transferência",
            "---------------------------------",
            "Ordem de Produção",
            "Ordem de Envase",
            "---------------------------------",
            "Novo Pedido de Compra",
            "---------------------------------",
            "Orçamento",
            "Novo Pedido",
            "---------------------------------",
            "Despesas"});
            this.cbA3.LimitToList = true;
            this.cbA3.Location = new System.Drawing.Point(106, 98);
            this.cbA3.Name = "cbA3";
            this.cbA3.Size = new System.Drawing.Size(224, 27);
            this.cbA3.TabIndex = 26;
            // 
            // cbA2
            // 
            this.cbA2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cbA2.FormattingEnabled = true;
            this.cbA2.Items.AddRange(new object[] {
            "Cadastro de Produtos",
            "Cadastro de Fornecedores",
            "Cadastro de Clientes",
            "Cadastro de Usuários",
            "---------------------------------",
            "Entrada de Nota Fiscal",
            "Saída de Nota Fiscal",
            "Acompanhamento de Carga",
            "---------------------------------",
            "Acerto de Estoque",
            "Transferência",
            "---------------------------------",
            "Ordem de Produção",
            "Ordem de Envase",
            "---------------------------------",
            "Novo Pedido de Compra",
            "---------------------------------",
            "Orçamento",
            "Novo Pedido",
            "---------------------------------",
            "Despesas"});
            this.cbA2.LimitToList = true;
            this.cbA2.Location = new System.Drawing.Point(106, 65);
            this.cbA2.Name = "cbA2";
            this.cbA2.Size = new System.Drawing.Size(224, 27);
            this.cbA2.TabIndex = 25;
            // 
            // cbA1
            // 
            this.cbA1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cbA1.FormattingEnabled = true;
            this.cbA1.Items.AddRange(new object[] {
            "Cadastro de Produtos",
            "Cadastro de Fornecedores",
            "Cadastro de Clientes",
            "Cadastro de Usuários",
            "---------------------------------",
            "Entrada de Nota Fiscal",
            "Saída de Nota Fiscal",
            "Acompanhamento de Carga",
            "---------------------------------",
            "Acerto de Estoque",
            "Transferência",
            "---------------------------------",
            "Ordem de Produção",
            "Ordem de Envase",
            "---------------------------------",
            "Novo Pedido de Compra",
            "---------------------------------",
            "Orçamento",
            "Novo Pedido",
            "---------------------------------",
            "Despesas"});
            this.cbA1.LimitToList = true;
            this.cbA1.Location = new System.Drawing.Point(106, 32);
            this.cbA1.Name = "cbA1";
            this.cbA1.Size = new System.Drawing.Size(224, 27);
            this.cbA1.TabIndex = 21;
            // 
            // FrmAtalhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(342, 206);
            this.Controls.Add(this.lblConcluir);
            this.Controls.Add(this.pbConcluir);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.cbA4);
            this.Controls.Add(this.cbA3);
            this.Controls.Add(this.cbA2);
            this.Controls.Add(this.lblAtalho4);
            this.Controls.Add(this.lblAtalho2);
            this.Controls.Add(this.lblAtalho3);
            this.Controls.Add(this.cbA1);
            this.Controls.Add(this.lblCadForn);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.lblAtalho1);
            this.Controls.Add(this.btX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAtalhos";
            this.Text = "FrmAtalhos";
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label lblAtalho1;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Label lblCadForn;
        private Controls.ComboAuto cbA1;
        private System.Windows.Forms.Label lblAtalho3;
        private System.Windows.Forms.Label lblAtalho2;
        private System.Windows.Forms.Label lblAtalho4;
        private Controls.ComboAuto cbA2;
        private Controls.ComboAuto cbA3;
        private Controls.ComboAuto cbA4;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblConcluir;
        private System.Windows.Forms.PictureBox pbConcluir;
    }
}