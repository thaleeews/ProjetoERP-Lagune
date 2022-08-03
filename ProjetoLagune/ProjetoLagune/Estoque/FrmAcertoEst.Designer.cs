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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.cbArmazem = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.rdMateria = new System.Windows.Forms.RadioButton();
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.rdEmbalagem = new System.Windows.Forms.RadioButton();
            this.listAcerto = new System.Windows.Forms.ListView();
            this.coluna1Lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQtTotal = new System.Windows.Forms.Label();
            this.txtQtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQt = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.llblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.btConcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdEmbalagem);
            this.groupBox1.Controls.Add(this.rdProduto);
            this.groupBox1.Controls.Add(this.rdMateria);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.cbArmazem);
            this.groupBox1.Controls.Add(this.lblArmazem);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
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
            // cbArmazem
            // 
            this.cbArmazem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbArmazem.FormattingEnabled = true;
            this.cbArmazem.Location = new System.Drawing.Point(88, 20);
            this.cbArmazem.Name = "cbArmazem";
            this.cbArmazem.Size = new System.Drawing.Size(257, 26);
            this.cbArmazem.TabIndex = 1;
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(88, 52);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(257, 26);
            this.cbProduto.TabIndex = 2;
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
            // rdMateria
            // 
            this.rdMateria.AutoSize = true;
            this.rdMateria.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdMateria.Location = new System.Drawing.Point(395, 16);
            this.rdMateria.Name = "rdMateria";
            this.rdMateria.Size = new System.Drawing.Size(120, 22);
            this.rdMateria.TabIndex = 4;
            this.rdMateria.TabStop = true;
            this.rdMateria.Text = "Matéria Prima";
            this.rdMateria.UseVisualStyleBackColor = true;
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdProduto.Location = new System.Drawing.Point(395, 44);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(138, 22);
            this.rdProduto.TabIndex = 5;
            this.rdProduto.TabStop = true;
            this.rdProduto.Text = "Produto Acabado";
            this.rdProduto.UseVisualStyleBackColor = true;
            // 
            // rdEmbalagem
            // 
            this.rdEmbalagem.AutoSize = true;
            this.rdEmbalagem.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.rdEmbalagem.Location = new System.Drawing.Point(395, 72);
            this.rdEmbalagem.Name = "rdEmbalagem";
            this.rdEmbalagem.Size = new System.Drawing.Size(105, 22);
            this.rdEmbalagem.TabIndex = 6;
            this.rdEmbalagem.TabStop = true;
            this.rdEmbalagem.Text = "Embalagem";
            this.rdEmbalagem.UseVisualStyleBackColor = true;
            // 
            // listAcerto
            // 
            this.listAcerto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Lote,
            this.coluna2Quantidade,
            this.coluna3Validade,
            this.coluna4Local});
            this.listAcerto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.listAcerto.Location = new System.Drawing.Point(13, 120);
            this.listAcerto.Name = "listAcerto";
            this.listAcerto.Size = new System.Drawing.Size(629, 198);
            this.listAcerto.TabIndex = 1;
            this.listAcerto.UseCompatibleStateImageBehavior = false;
            this.listAcerto.View = System.Windows.Forms.View.Details;
            // 
            // coluna1Lote
            // 
            this.coluna1Lote.Text = "Lote";
            this.coluna1Lote.Width = 200;
            // 
            // coluna2Quantidade
            // 
            this.coluna2Quantidade.Text = "Quantidade";
            this.coluna2Quantidade.Width = 170;
            // 
            // coluna3Validade
            // 
            this.coluna3Validade.Text = "Validade";
            this.coluna3Validade.Width = 100;
            // 
            // coluna4Local
            // 
            this.coluna4Local.Text = "Localização";
            this.coluna4Local.Width = 120;
            // 
            // lblQtTotal
            // 
            this.lblQtTotal.AutoSize = true;
            this.lblQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQtTotal.Location = new System.Drawing.Point(346, 327);
            this.lblQtTotal.Name = "lblQtTotal";
            this.lblQtTotal.Size = new System.Drawing.Size(120, 18);
            this.lblQtTotal.TabIndex = 2;
            this.lblQtTotal.Text = "Quantidade Total:";
            // 
            // txtQtTotal
            // 
            this.txtQtTotal.Enabled = false;
            this.txtQtTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQtTotal.Location = new System.Drawing.Point(472, 324);
            this.txtQtTotal.Name = "txtQtTotal";
            this.txtQtTotal.Size = new System.Drawing.Size(170, 25);
            this.txtQtTotal.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtValidade);
            this.groupBox2.Controls.Add(this.txtLocal);
            this.groupBox2.Controls.Add(this.llblLocal);
            this.groupBox2.Controls.Add(this.lblValidade);
            this.groupBox2.Controls.Add(this.lblQt);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.lblLote);
            this.groupBox2.Location = new System.Drawing.Point(13, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edição";
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
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLote.Location = new System.Drawing.Point(98, 20);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(170, 25);
            this.txtLote.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(98, 51);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(170, 25);
            this.txtQuantidade.TabIndex = 8;
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
            // txtLocal
            // 
            this.txtLocal.Enabled = false;
            this.txtLocal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLocal.Location = new System.Drawing.Point(369, 51);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(170, 25);
            this.txtLocal.TabIndex = 12;
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Enabled = false;
            this.mtxtValidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtValidade.Location = new System.Drawing.Point(369, 20);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(100, 25);
            this.mtxtValidade.TabIndex = 13;
            // 
            // btConcluir
            // 
            this.btConcluir.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btConcluir.Location = new System.Drawing.Point(13, 324);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(85, 26);
            this.btConcluir.TabIndex = 5;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btEditar.Location = new System.Drawing.Point(104, 324);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(85, 26);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btExcluir.Location = new System.Drawing.Point(195, 324);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(85, 26);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btVoltar.Location = new System.Drawing.Point(557, 451);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 26);
            this.btVoltar.TabIndex = 8;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btLimpar.Location = new System.Drawing.Point(456, 451);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 26);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btSalvar.Location = new System.Drawing.Point(13, 451);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(85, 26);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmAcertoEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(654, 489);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtQtTotal);
            this.Controls.Add(this.lblQtTotal);
            this.Controls.Add(this.listAcerto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAcertoEst";
            this.Text = "Acerto de Estoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label llblLocal;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblQt;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
    }
}