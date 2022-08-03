namespace ProjetoLagune.Vendas
{
    partial class FrmNovaVenda
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
            this.comboForma = new System.Windows.Forms.ComboBox();
            this.comboRazao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.comboEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.listProdutosV = new System.Windows.Forms.ListView();
            this.coluna1Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Especie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4ValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboForma);
            this.groupBox1.Controls.Add(this.comboRazao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // comboForma
            // 
            this.comboForma.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboForma.FormattingEnabled = true;
            this.comboForma.Location = new System.Drawing.Point(174, 54);
            this.comboForma.Name = "comboForma";
            this.comboForma.Size = new System.Drawing.Size(622, 26);
            this.comboForma.TabIndex = 3;
            // 
            // comboRazao
            // 
            this.comboRazao.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboRazao.FormattingEnabled = true;
            this.comboRazao.Location = new System.Drawing.Point(174, 24);
            this.comboRazao.Name = "comboRazao";
            this.comboRazao.Size = new System.Drawing.Size(622, 26);
            this.comboRazao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social do Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btEditar);
            this.groupBox2.Controls.Add(this.comboEspecie);
            this.groupBox2.Controls.Add(this.lblEspecie);
            this.groupBox2.Controls.Add(this.btAdicionar);
            this.groupBox2.Controls.Add(this.btRemover);
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Controls.Add(this.lblValorTotal);
            this.groupBox2.Controls.Add(this.txtValorUnit);
            this.groupBox2.Controls.Add(this.lblValorUnit);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.comboProduto);
            this.groupBox2.Controls.Add(this.lblQuantidade);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btEditar.Location = new System.Drawing.Point(191, 124);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(85, 26);
            this.btEditar.TabIndex = 12;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // comboEspecie
            // 
            this.comboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecie.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboEspecie.FormattingEnabled = true;
            this.comboEspecie.Items.AddRange(new object[] {
            "CX",
            "PC",
            "UN",
            ""});
            this.comboEspecie.Location = new System.Drawing.Point(98, 87);
            this.comboEspecie.Name = "comboEspecie";
            this.comboEspecie.Size = new System.Drawing.Size(77, 26);
            this.comboEspecie.TabIndex = 11;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblEspecie.Location = new System.Drawing.Point(6, 90);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(63, 18);
            this.lblEspecie.TabIndex = 10;
            this.lblEspecie.Text = "Espécie:";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btAdicionar.Location = new System.Drawing.Point(100, 124);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(85, 26);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btRemover.Location = new System.Drawing.Point(9, 124);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(85, 26);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(652, 56);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(144, 25);
            this.txtValorTotal.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorTotal.Location = new System.Drawing.Point(566, 59);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(80, 18);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtValorUnit.Location = new System.Drawing.Point(390, 56);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(149, 25);
            this.txtValorUnit.TabIndex = 5;
            this.txtValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnit_KeyPress);
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValorUnit.Location = new System.Drawing.Point(282, 59);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(102, 18);
            this.lblValorUnit.TabIndex = 4;
            this.lblValorUnit.Text = "Valor Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(98, 56);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(149, 25);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // comboProduto
            // 
            this.comboProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(98, 24);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(698, 26);
            this.comboProduto.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(6, 59);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblProduto.Location = new System.Drawing.Point(6, 27);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(63, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // listProdutosV
            // 
            this.listProdutosV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Produto,
            this.coluna2Especie,
            this.coluna3Quantidade,
            this.coluna4ValorUnitario,
            this.coluna5ValorTotal});
            this.listProdutosV.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.listProdutosV.Location = new System.Drawing.Point(13, 281);
            this.listProdutosV.Name = "listProdutosV";
            this.listProdutosV.Size = new System.Drawing.Size(802, 192);
            this.listProdutosV.TabIndex = 5;
            this.listProdutosV.UseCompatibleStateImageBehavior = false;
            this.listProdutosV.View = System.Windows.Forms.View.Details;
            // 
            // coluna1Produto
            // 
            this.coluna1Produto.Text = "Produto";
            this.coluna1Produto.Width = 350;
            // 
            // coluna2Especie
            // 
            this.coluna2Especie.Text = "Espécie";
            this.coluna2Especie.Width = 70;
            // 
            // coluna3Quantidade
            // 
            this.coluna3Quantidade.Text = "Quantidade";
            this.coluna3Quantidade.Width = 100;
            // 
            // coluna4ValorUnitario
            // 
            this.coluna4ValorUnitario.Text = "Valor Unitário";
            this.coluna4ValorUnitario.Width = 110;
            // 
            // coluna5ValorTotal
            // 
            this.coluna5ValorTotal.Text = "Valor Total";
            this.coluna5ValorTotal.Width = 100;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btSalvar.Location = new System.Drawing.Point(13, 480);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(85, 26);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btVoltar.Location = new System.Drawing.Point(730, 480);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 26);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btLimpar.Location = new System.Drawing.Point(629, 480);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 26);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(827, 518);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.listProdutosV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNovaVenda";
            this.Text = "Nova Venda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboForma;
        private System.Windows.Forms.ComboBox comboRazao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListView listProdutosV;
        private System.Windows.Forms.ColumnHeader coluna1Produto;
        private System.Windows.Forms.ColumnHeader coluna2Especie;
        private System.Windows.Forms.ColumnHeader coluna3Quantidade;
        private System.Windows.Forms.ColumnHeader coluna4ValorUnitario;
        private System.Windows.Forms.ComboBox comboEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ColumnHeader coluna5ValorTotal;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btLimpar;
    }
}