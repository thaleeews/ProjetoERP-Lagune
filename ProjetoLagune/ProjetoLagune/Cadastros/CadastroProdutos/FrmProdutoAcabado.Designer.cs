namespace ProjetoLagune.Cadastros.CadastroProdutos
{
    partial class FrmProdutoAcabado
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.grpbValores = new System.Windows.Forms.GroupBox();
            this.txtQntPorCaixa = new System.Windows.Forms.TextBox();
            this.lblEmbalagemVenda = new System.Windows.Forms.Label();
            this.txtCOFINS = new System.Windows.Forms.TextBox();
            this.lblCOFINS = new System.Windows.Forms.Label();
            this.txtPIS = new System.Windows.Forms.TextBox();
            this.lblPIS = new System.Windows.Forms.Label();
            this.lblIPI = new System.Windows.Forms.Label();
            this.txtIPI = new System.Windows.Forms.TextBox();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.lblICMS = new System.Windows.Forms.Label();
            this.txtQuantidadeMinima = new System.Windows.Forms.TextBox();
            this.lblQuantidadeMinima = new System.Windows.Forms.Label();
            this.grpbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.comboLinha = new System.Windows.Forms.ComboBox();
            this.comboFabricante = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblFabrica = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoB = new System.Windows.Forms.Label();
            this.lblPesoMinimo = new System.Windows.Forms.Label();
            this.txtPesoMinimo = new System.Windows.Forms.TextBox();
            this.txtValidade = new System.Windows.Forms.TextBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtPesoPadrao = new System.Windows.Forms.TextBox();
            this.lblPesoPadrao = new System.Windows.Forms.Label();
            this.grpbLote = new System.Windows.Forms.GroupBox();
            this.grpbValores.SuspendLayout();
            this.grpbNome.SuspendLayout();
            this.grpbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Arial", 10F);
            this.btVoltar.Location = new System.Drawing.Point(733, 477);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(80, 25);
            this.btVoltar.TabIndex = 12;
            this.btVoltar.Text = "< Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Arial", 10F);
            this.btExcluir.Location = new System.Drawing.Point(184, 477);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 25);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Arial", 10F);
            this.btAlterar.Location = new System.Drawing.Point(98, 477);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(80, 25);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 10F);
            this.btCadastrar.Location = new System.Drawing.Point(12, 477);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(80, 25);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // grpbValores
            // 
            this.grpbValores.Controls.Add(this.txtQntPorCaixa);
            this.grpbValores.Controls.Add(this.lblEmbalagemVenda);
            this.grpbValores.Controls.Add(this.txtCOFINS);
            this.grpbValores.Controls.Add(this.lblCOFINS);
            this.grpbValores.Controls.Add(this.txtPIS);
            this.grpbValores.Controls.Add(this.lblPIS);
            this.grpbValores.Controls.Add(this.lblIPI);
            this.grpbValores.Controls.Add(this.txtIPI);
            this.grpbValores.Controls.Add(this.txtICMS);
            this.grpbValores.Controls.Add(this.lblICMS);
            this.grpbValores.Controls.Add(this.txtQuantidadeMinima);
            this.grpbValores.Controls.Add(this.lblQuantidadeMinima);
            this.grpbValores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbValores.Location = new System.Drawing.Point(12, 122);
            this.grpbValores.Name = "grpbValores";
            this.grpbValores.Size = new System.Drawing.Size(814, 103);
            this.grpbValores.TabIndex = 2;
            this.grpbValores.TabStop = false;
            this.grpbValores.Text = "Valores";
            // 
            // txtQntPorCaixa
            // 
            this.txtQntPorCaixa.Font = new System.Drawing.Font("Arial", 10F);
            this.txtQntPorCaixa.Location = new System.Drawing.Point(162, 71);
            this.txtQntPorCaixa.MaxLength = 10;
            this.txtQntPorCaixa.Name = "txtQntPorCaixa";
            this.txtQntPorCaixa.Size = new System.Drawing.Size(138, 23);
            this.txtQntPorCaixa.TabIndex = 5;
            // 
            // lblEmbalagemVenda
            // 
            this.lblEmbalagemVenda.AutoSize = true;
            this.lblEmbalagemVenda.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEmbalagemVenda.Location = new System.Drawing.Point(6, 74);
            this.lblEmbalagemVenda.Name = "lblEmbalagemVenda";
            this.lblEmbalagemVenda.Size = new System.Drawing.Size(151, 16);
            this.lblEmbalagemVenda.TabIndex = 10;
            this.lblEmbalagemVenda.Text = "Quantidade Por Caixa:";
            // 
            // txtCOFINS
            // 
            this.txtCOFINS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCOFINS.Location = new System.Drawing.Point(657, 13);
            this.txtCOFINS.MaxLength = 10;
            this.txtCOFINS.Name = "txtCOFINS";
            this.txtCOFINS.Size = new System.Drawing.Size(138, 23);
            this.txtCOFINS.TabIndex = 4;
            this.txtCOFINS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCOFINS_KeyPress);
            // 
            // lblCOFINS
            // 
            this.lblCOFINS.AutoSize = true;
            this.lblCOFINS.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCOFINS.Location = new System.Drawing.Point(588, 16);
            this.lblCOFINS.Name = "lblCOFINS";
            this.lblCOFINS.Size = new System.Drawing.Size(63, 16);
            this.lblCOFINS.TabIndex = 8;
            this.lblCOFINS.Text = "COFINS:";
            // 
            // txtPIS
            // 
            this.txtPIS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPIS.Location = new System.Drawing.Point(408, 42);
            this.txtPIS.MaxLength = 10;
            this.txtPIS.Name = "txtPIS";
            this.txtPIS.Size = new System.Drawing.Size(138, 23);
            this.txtPIS.TabIndex = 3;
            this.txtPIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIS_KeyPress);
            // 
            // lblPIS
            // 
            this.lblPIS.AutoSize = true;
            this.lblPIS.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPIS.Location = new System.Drawing.Point(369, 45);
            this.lblPIS.Name = "lblPIS";
            this.lblPIS.Size = new System.Drawing.Size(33, 16);
            this.lblPIS.TabIndex = 6;
            this.lblPIS.Text = "PIS:";
            // 
            // lblIPI
            // 
            this.lblIPI.AutoSize = true;
            this.lblIPI.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIPI.Location = new System.Drawing.Point(369, 16);
            this.lblIPI.Name = "lblIPI";
            this.lblIPI.Size = new System.Drawing.Size(27, 16);
            this.lblIPI.TabIndex = 5;
            this.lblIPI.Text = "IPI:";
            // 
            // txtIPI
            // 
            this.txtIPI.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIPI.Location = new System.Drawing.Point(408, 13);
            this.txtIPI.MaxLength = 10;
            this.txtIPI.Name = "txtIPI";
            this.txtIPI.Size = new System.Drawing.Size(138, 23);
            this.txtIPI.TabIndex = 2;
            this.txtIPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPI_KeyPress);
            // 
            // txtICMS
            // 
            this.txtICMS.Font = new System.Drawing.Font("Arial", 10F);
            this.txtICMS.Location = new System.Drawing.Point(162, 42);
            this.txtICMS.MaxLength = 10;
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(138, 23);
            this.txtICMS.TabIndex = 1;
            this.txtICMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtICMS_KeyPress);
            // 
            // lblICMS
            // 
            this.lblICMS.AutoSize = true;
            this.lblICMS.Font = new System.Drawing.Font("Arial", 10F);
            this.lblICMS.Location = new System.Drawing.Point(6, 45);
            this.lblICMS.Name = "lblICMS";
            this.lblICMS.Size = new System.Drawing.Size(45, 16);
            this.lblICMS.TabIndex = 2;
            this.lblICMS.Text = "ICMS:";
            // 
            // txtQuantidadeMinima
            // 
            this.txtQuantidadeMinima.Font = new System.Drawing.Font("Arial", 10F);
            this.txtQuantidadeMinima.Location = new System.Drawing.Point(162, 13);
            this.txtQuantidadeMinima.MaxLength = 10;
            this.txtQuantidadeMinima.Name = "txtQuantidadeMinima";
            this.txtQuantidadeMinima.Size = new System.Drawing.Size(138, 23);
            this.txtQuantidadeMinima.TabIndex = 0;
            this.txtQuantidadeMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeMinima_KeyPress);
            // 
            // lblQuantidadeMinima
            // 
            this.lblQuantidadeMinima.AutoSize = true;
            this.lblQuantidadeMinima.Font = new System.Drawing.Font("Arial", 10F);
            this.lblQuantidadeMinima.Location = new System.Drawing.Point(6, 16);
            this.lblQuantidadeMinima.Name = "lblQuantidadeMinima";
            this.lblQuantidadeMinima.Size = new System.Drawing.Size(135, 16);
            this.lblQuantidadeMinima.TabIndex = 0;
            this.lblQuantidadeMinima.Text = "Quantidade Mínima:";
            // 
            // grpbNome
            // 
            this.grpbNome.Controls.Add(this.txtNome);
            this.grpbNome.Controls.Add(this.lblNome);
            this.grpbNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNome.Location = new System.Drawing.Point(12, 12);
            this.grpbNome.Name = "grpbNome";
            this.grpbNome.Size = new System.Drawing.Size(814, 49);
            this.grpbNome.TabIndex = 0;
            this.grpbNome.TabStop = false;
            this.grpbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNome.Location = new System.Drawing.Point(162, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(633, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.comboLinha);
            this.grpbInfo.Controls.Add(this.comboFabricante);
            this.grpbInfo.Controls.Add(this.lblFamilia);
            this.grpbInfo.Controls.Add(this.lblFabrica);
            this.grpbInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbInfo.Location = new System.Drawing.Point(12, 67);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(814, 49);
            this.grpbInfo.TabIndex = 1;
            this.grpbInfo.TabStop = false;
            this.grpbInfo.Text = "Informações";
            // 
            // comboLinha
            // 
            this.comboLinha.Font = new System.Drawing.Font("Arial", 10F);
            this.comboLinha.FormattingEnabled = true;
            this.comboLinha.Location = new System.Drawing.Point(476, 13);
            this.comboLinha.Name = "comboLinha";
            this.comboLinha.Size = new System.Drawing.Size(319, 24);
            this.comboLinha.TabIndex = 1;
            // 
            // comboFabricante
            // 
            this.comboFabricante.Font = new System.Drawing.Font("Arial", 10F);
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.Location = new System.Drawing.Point(162, 13);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(240, 24);
            this.comboFabricante.TabIndex = 0;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFamilia.Location = new System.Drawing.Point(412, 16);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(58, 16);
            this.lblFamilia.TabIndex = 5;
            this.lblFamilia.Text = "Família:";
            // 
            // lblFabrica
            // 
            this.lblFabrica.AutoSize = true;
            this.lblFabrica.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFabrica.Location = new System.Drawing.Point(6, 16);
            this.lblFabrica.Name = "lblFabrica";
            this.lblFabrica.Size = new System.Drawing.Size(80, 16);
            this.lblFabrica.TabIndex = 4;
            this.lblFabrica.Text = "Fabricante:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassificacao);
            this.groupBox1.Controls.Add(this.lblClassificacao);
            this.groupBox1.Controls.Add(this.txtPesoMaximo);
            this.groupBox1.Controls.Add(this.lblPesoMaximo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigoB);
            this.groupBox1.Controls.Add(this.lblPesoMinimo);
            this.groupBox1.Controls.Add(this.txtPesoMinimo);
            this.groupBox1.Controls.Add(this.txtValidade);
            this.groupBox1.Controls.Add(this.lblValidade);
            this.groupBox1.Controls.Add(this.txtPesoPadrao);
            this.groupBox1.Controls.Add(this.lblPesoPadrao);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Adicionais";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Arial", 10F);
            this.txtClassificacao.Location = new System.Drawing.Point(162, 71);
            this.txtClassificacao.MaxLength = 20;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(138, 23);
            this.txtClassificacao.TabIndex = 4;
            this.txtClassificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassificacao_KeyPress);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Arial", 10F);
            this.lblClassificacao.Location = new System.Drawing.Point(6, 74);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(136, 16);
            this.lblClassificacao.TabIndex = 10;
            this.lblClassificacao.Text = "Classificação Fiscal:";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPesoMaximo.Location = new System.Drawing.Point(657, 13);
            this.txtPesoMaximo.MaxLength = 10;
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(138, 23);
            this.txtPesoMaximo.TabIndex = 2;
            this.txtPesoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMaximo_KeyPress);
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPesoMaximo.Location = new System.Drawing.Point(556, 16);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(95, 16);
            this.lblPesoMaximo.TabIndex = 8;
            this.lblPesoMaximo.Text = "Peso Máximo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(162, 100);
            this.txtCodigo.MaxLength = 25;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 23);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigoB
            // 
            this.lblCodigoB.AutoSize = true;
            this.lblCodigoB.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCodigoB.Location = new System.Drawing.Point(6, 103);
            this.lblCodigoB.Name = "lblCodigoB";
            this.lblCodigoB.Size = new System.Drawing.Size(123, 16);
            this.lblCodigoB.TabIndex = 6;
            this.lblCodigoB.Text = "Código de Barras:";
            // 
            // lblPesoMinimo
            // 
            this.lblPesoMinimo.AutoSize = true;
            this.lblPesoMinimo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPesoMinimo.Location = new System.Drawing.Point(309, 16);
            this.lblPesoMinimo.Name = "lblPesoMinimo";
            this.lblPesoMinimo.Size = new System.Drawing.Size(93, 16);
            this.lblPesoMinimo.TabIndex = 5;
            this.lblPesoMinimo.Text = "Peso Mínimo:";
            // 
            // txtPesoMinimo
            // 
            this.txtPesoMinimo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPesoMinimo.Location = new System.Drawing.Point(408, 13);
            this.txtPesoMinimo.MaxLength = 10;
            this.txtPesoMinimo.Name = "txtPesoMinimo";
            this.txtPesoMinimo.Size = new System.Drawing.Size(138, 23);
            this.txtPesoMinimo.TabIndex = 1;
            this.txtPesoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMinimo_KeyPress);
            // 
            // txtValidade
            // 
            this.txtValidade.Font = new System.Drawing.Font("Arial", 10F);
            this.txtValidade.Location = new System.Drawing.Point(162, 42);
            this.txtValidade.MaxLength = 10;
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(138, 23);
            this.txtValidade.TabIndex = 3;
            this.txtValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidade_KeyPress);
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Arial", 10F);
            this.lblValidade.Location = new System.Drawing.Point(6, 45);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(121, 16);
            this.lblValidade.TabIndex = 2;
            this.lblValidade.Text = "Validade (Meses):";
            // 
            // txtPesoPadrao
            // 
            this.txtPesoPadrao.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPesoPadrao.Location = new System.Drawing.Point(162, 13);
            this.txtPesoPadrao.MaxLength = 10;
            this.txtPesoPadrao.Name = "txtPesoPadrao";
            this.txtPesoPadrao.Size = new System.Drawing.Size(138, 23);
            this.txtPesoPadrao.TabIndex = 0;
            this.txtPesoPadrao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoPadrao_KeyPress);
            // 
            // lblPesoPadrao
            // 
            this.lblPesoPadrao.AutoSize = true;
            this.lblPesoPadrao.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPesoPadrao.Location = new System.Drawing.Point(6, 16);
            this.lblPesoPadrao.Name = "lblPesoPadrao";
            this.lblPesoPadrao.Size = new System.Drawing.Size(94, 16);
            this.lblPesoPadrao.TabIndex = 0;
            this.lblPesoPadrao.Text = "Peso Padrão:";
            // 
            // grpbLote
            // 
            this.grpbLote.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbLote.Location = new System.Drawing.Point(12, 371);
            this.grpbLote.Name = "grpbLote";
            this.grpbLote.Size = new System.Drawing.Size(814, 87);
            this.grpbLote.TabIndex = 4;
            this.grpbLote.TabStop = false;
            this.grpbLote.Text = "Lote";
            // 
            // FrmProdutoAcabado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 514);
            this.Controls.Add(this.grpbLote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbInfo);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.grpbValores);
            this.Controls.Add(this.grpbNome);
            this.Name = "FrmProdutoAcabado";
            this.Text = "Cadastro de Produto Acabado";
            this.grpbValores.ResumeLayout(false);
            this.grpbValores.PerformLayout();
            this.grpbNome.ResumeLayout(false);
            this.grpbNome.PerformLayout();
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.GroupBox grpbValores;
        private System.Windows.Forms.TextBox txtQntPorCaixa;
        private System.Windows.Forms.Label lblEmbalagemVenda;
        private System.Windows.Forms.TextBox txtCOFINS;
        private System.Windows.Forms.Label lblCOFINS;
        private System.Windows.Forms.TextBox txtPIS;
        private System.Windows.Forms.Label lblPIS;
        private System.Windows.Forms.Label lblIPI;
        private System.Windows.Forms.TextBox txtIPI;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.Label lblICMS;
        private System.Windows.Forms.TextBox txtQuantidadeMinima;
        private System.Windows.Forms.Label lblQuantidadeMinima;
        private System.Windows.Forms.GroupBox grpbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.ComboBox comboLinha;
        private System.Windows.Forms.ComboBox comboFabricante;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblFabrica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoB;
        private System.Windows.Forms.Label lblPesoMinimo;
        private System.Windows.Forms.TextBox txtPesoMinimo;
        private System.Windows.Forms.TextBox txtValidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtPesoPadrao;
        private System.Windows.Forms.Label lblPesoPadrao;
        private System.Windows.Forms.GroupBox grpbLote;
    }
}