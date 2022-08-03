namespace ProjetoLagune.Pedidos
{
    partial class FrmPedidos
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
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.comboFornecedor = new System.Windows.Forms.ComboBox();
            this.grpbDados = new System.Windows.Forms.GroupBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.comboEstoque = new System.Windows.Forms.ComboBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.grpbProdutos = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtIPI = new System.Windows.Forms.TextBox();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.comboUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.comboNomeProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomedoProd = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.coluna1Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4ValorUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna6ICMS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna7IPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btConcluir = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btLimparTela = new System.Windows.Forms.Button();
            this.grpbDados.SuspendLayout();
            this.grpbProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFornecedor.Location = new System.Drawing.Point(6, 54);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(86, 16);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // comboFornecedor
            // 
            this.comboFornecedor.Font = new System.Drawing.Font("Arial", 10F);
            this.comboFornecedor.FormattingEnabled = true;
            this.comboFornecedor.Location = new System.Drawing.Point(141, 51);
            this.comboFornecedor.Name = "comboFornecedor";
            this.comboFornecedor.Size = new System.Drawing.Size(710, 24);
            this.comboFornecedor.TabIndex = 1;
            // 
            // grpbDados
            // 
            this.grpbDados.Controls.Add(this.txtNumPedido);
            this.grpbDados.Controls.Add(this.lblNumPedido);
            this.grpbDados.Controls.Add(this.comboEstoque);
            this.grpbDados.Controls.Add(this.lblEstoque);
            this.grpbDados.Controls.Add(this.comboFornecedor);
            this.grpbDados.Controls.Add(this.lblFornecedor);
            this.grpbDados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDados.Location = new System.Drawing.Point(13, 13);
            this.grpbDados.Name = "grpbDados";
            this.grpbDados.Size = new System.Drawing.Size(869, 115);
            this.grpbDados.TabIndex = 2;
            this.grpbDados.TabStop = false;
            this.grpbDados.Text = "Dados";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Enabled = false;
            this.txtNumPedido.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumPedido.Location = new System.Drawing.Point(141, 22);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(69, 23);
            this.txtNumPedido.TabIndex = 0;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNumPedido.Location = new System.Drawing.Point(6, 25);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(129, 16);
            this.lblNumPedido.TabIndex = 4;
            this.lblNumPedido.Text = "Número do Pedido:";
            // 
            // comboEstoque
            // 
            this.comboEstoque.Font = new System.Drawing.Font("Arial", 10F);
            this.comboEstoque.FormattingEnabled = true;
            this.comboEstoque.Location = new System.Drawing.Point(141, 81);
            this.comboEstoque.Name = "comboEstoque";
            this.comboEstoque.Size = new System.Drawing.Size(710, 24);
            this.comboEstoque.TabIndex = 2;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEstoque.Location = new System.Drawing.Point(6, 84);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(64, 16);
            this.lblEstoque.TabIndex = 2;
            this.lblEstoque.Text = "Estoque:";
            // 
            // grpbProdutos
            // 
            this.grpbProdutos.Controls.Add(this.btEditar);
            this.grpbProdutos.Controls.Add(this.txtValorTotal);
            this.grpbProdutos.Controls.Add(this.lblValorTotal);
            this.grpbProdutos.Controls.Add(this.txtIPI);
            this.grpbProdutos.Controls.Add(this.txtICMS);
            this.grpbProdutos.Controls.Add(this.label5);
            this.grpbProdutos.Controls.Add(this.label4);
            this.grpbProdutos.Controls.Add(this.btRemover);
            this.grpbProdutos.Controls.Add(this.btAdicionar);
            this.grpbProdutos.Controls.Add(this.comboUnidade);
            this.grpbProdutos.Controls.Add(this.label3);
            this.grpbProdutos.Controls.Add(this.txtValorUnitario);
            this.grpbProdutos.Controls.Add(this.txtQuantidade);
            this.grpbProdutos.Controls.Add(this.comboNomeProduto);
            this.grpbProdutos.Controls.Add(this.label2);
            this.grpbProdutos.Controls.Add(this.label1);
            this.grpbProdutos.Controls.Add(this.lblNomedoProd);
            this.grpbProdutos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProdutos.Location = new System.Drawing.Point(13, 134);
            this.grpbProdutos.Name = "grpbProdutos";
            this.grpbProdutos.Size = new System.Drawing.Size(869, 153);
            this.grpbProdutos.TabIndex = 3;
            this.grpbProdutos.TabStop = false;
            this.grpbProdutos.Text = "Produtos";
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Arial", 10F);
            this.btEditar.Location = new System.Drawing.Point(181, 122);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(80, 25);
            this.btEditar.TabIndex = 19;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.txtValorTotal.Location = new System.Drawing.Point(593, 87);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(110, 23);
            this.txtValorTotal.TabIndex = 6;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.lblValorTotal.Location = new System.Drawing.Point(491, 90);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(78, 16);
            this.lblValorTotal.TabIndex = 18;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtIPI
            // 
            this.txtIPI.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIPI.Location = new System.Drawing.Point(308, 87);
            this.txtIPI.Name = "txtIPI";
            this.txtIPI.Size = new System.Drawing.Size(76, 23);
            this.txtIPI.TabIndex = 5;
            this.txtIPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPI_KeyPress);
            // 
            // txtICMS
            // 
            this.txtICMS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtICMS.Location = new System.Drawing.Point(134, 87);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(76, 23);
            this.txtICMS.TabIndex = 4;
            this.txtICMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtICMS_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(216, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "IPI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ICMS:";
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Arial", 10F);
            this.btRemover.Location = new System.Drawing.Point(9, 122);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(80, 25);
            this.btRemover.TabIndex = 13;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Arial", 10F);
            this.btAdicionar.Location = new System.Drawing.Point(95, 122);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(80, 25);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // comboUnidade
            // 
            this.comboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnidade.Font = new System.Drawing.Font("Arial", 10F);
            this.comboUnidade.FormattingEnabled = true;
            this.comboUnidade.Items.AddRange(new object[] {
            "KG\t",
            "G",
            "PÇ",
            "L",
            "mL",
            ""});
            this.comboUnidade.Location = new System.Drawing.Point(134, 57);
            this.comboUnidade.Name = "comboUnidade";
            this.comboUnidade.Size = new System.Drawing.Size(76, 24);
            this.comboUnidade.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unidade:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Arial", 10F);
            this.txtValorUnitario.Location = new System.Drawing.Point(593, 57);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(210, 23);
            this.txtValorUnitario.TabIndex = 3;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 10F);
            this.txtQuantidade.Location = new System.Drawing.Point(308, 57);
            this.txtQuantidade.MaxLength = 20;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(177, 23);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.WordWrap = false;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // comboNomeProduto
            // 
            this.comboNomeProduto.Font = new System.Drawing.Font("Arial", 10F);
            this.comboNomeProduto.FormattingEnabled = true;
            this.comboNomeProduto.Items.AddRange(new object[] {
            "gmrjg"});
            this.comboNomeProduto.Location = new System.Drawing.Point(134, 27);
            this.comboNomeProduto.Name = "comboNomeProduto";
            this.comboNomeProduto.Size = new System.Drawing.Size(710, 24);
            this.comboNomeProduto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(491, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Unitário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(216, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantidade:";
            // 
            // lblNomedoProd
            // 
            this.lblNomedoProd.AutoSize = true;
            this.lblNomedoProd.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNomedoProd.Location = new System.Drawing.Point(6, 30);
            this.lblNomedoProd.Name = "lblNomedoProd";
            this.lblNomedoProd.Size = new System.Drawing.Size(122, 16);
            this.lblNomedoProd.TabIndex = 6;
            this.lblNomedoProd.Text = "Nome do Produto:";
            // 
            // listProdutos
            // 
            this.listProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Nome,
            this.coluna2Unidade,
            this.coluna3Quantidade,
            this.coluna4ValorUnit,
            this.coluna5ValorTotal,
            this.coluna6ICMS,
            this.coluna7IPI});
            this.listProdutos.Font = new System.Drawing.Font("Arial", 10F);
            this.listProdutos.Location = new System.Drawing.Point(13, 293);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(869, 214);
            this.listProdutos.TabIndex = 4;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.View = System.Windows.Forms.View.Details;
            // 
            // coluna1Nome
            // 
            this.coluna1Nome.Text = "Nome do Produto";
            this.coluna1Nome.Width = 300;
            // 
            // coluna2Unidade
            // 
            this.coluna2Unidade.Text = "UN";
            this.coluna2Unidade.Width = 40;
            // 
            // coluna3Quantidade
            // 
            this.coluna3Quantidade.Text = "Quantidade";
            this.coluna3Quantidade.Width = 110;
            // 
            // coluna4ValorUnit
            // 
            this.coluna4ValorUnit.Text = "Valor Unitário";
            this.coluna4ValorUnit.Width = 100;
            // 
            // coluna5ValorTotal
            // 
            this.coluna5ValorTotal.Text = "Valor Total";
            this.coluna5ValorTotal.Width = 140;
            // 
            // coluna6ICMS
            // 
            this.coluna6ICMS.Text = "ICMS (%)";
            this.coluna6ICMS.Width = 70;
            // 
            // coluna7IPI
            // 
            this.coluna7IPI.Text = "IPI (%)";
            // 
            // btConcluir
            // 
            this.btConcluir.Font = new System.Drawing.Font("Arial", 10F);
            this.btConcluir.Location = new System.Drawing.Point(13, 527);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(80, 25);
            this.btConcluir.TabIndex = 19;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Arial", 10F);
            this.btVoltar.Location = new System.Drawing.Point(802, 527);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(80, 25);
            this.btVoltar.TabIndex = 20;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Font = new System.Drawing.Font("Arial", 10F);
            this.btImprimir.Location = new System.Drawing.Point(117, 527);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(80, 25);
            this.btImprimir.TabIndex = 21;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // btLimparTela
            // 
            this.btLimparTela.Font = new System.Drawing.Font("Arial", 10F);
            this.btLimparTela.Location = new System.Drawing.Point(706, 527);
            this.btLimparTela.Name = "btLimparTela";
            this.btLimparTela.Size = new System.Drawing.Size(90, 25);
            this.btLimparTela.TabIndex = 22;
            this.btLimparTela.Text = "Limpar Tela";
            this.btLimparTela.UseVisualStyleBackColor = true;
            this.btLimparTela.Click += new System.EventHandler(this.btLimparTela_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 560);
            this.Controls.Add(this.btLimparTela);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.grpbProdutos);
            this.Controls.Add(this.grpbDados);
            this.Name = "FrmPedidos";
            this.Text = "Pedido de Compra";
            this.grpbDados.ResumeLayout(false);
            this.grpbDados.PerformLayout();
            this.grpbProdutos.ResumeLayout(false);
            this.grpbProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox comboFornecedor;
        private System.Windows.Forms.GroupBox grpbDados;
        private System.Windows.Forms.ComboBox comboEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.GroupBox grpbProdutos;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox comboNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomedoProd;
        private System.Windows.Forms.ComboBox comboUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.ColumnHeader coluna1Nome;
        private System.Windows.Forms.ColumnHeader coluna2Unidade;
        private System.Windows.Forms.ColumnHeader coluna3Quantidade;
        private System.Windows.Forms.ColumnHeader coluna4ValorUnit;
        private System.Windows.Forms.TextBox txtIPI;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ColumnHeader coluna5ValorTotal;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.ColumnHeader coluna6ICMS;
        private System.Windows.Forms.ColumnHeader coluna7IPI;
        private System.Windows.Forms.Button btLimparTela;
    }
}