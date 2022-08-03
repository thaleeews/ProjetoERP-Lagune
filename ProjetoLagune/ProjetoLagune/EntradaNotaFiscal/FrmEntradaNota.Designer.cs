namespace ProjetoLagune.EntradaNotaFiscal
{
    partial class FrmEntradaNota
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.grpbDadosDaNota = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.mtxtNumeroSefaz = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.grpbDadosPagamento = new System.Windows.Forms.GroupBox();
            this.mtxt6Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.mtxt5Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.mtxt4Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.mtxt3Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.mtxt2Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.mtxt1Duplicata = new System.Windows.Forms.MaskedTextBox();
            this.comboCFOP = new System.Windows.Forms.ComboBox();
            this.lblCFOP = new System.Windows.Forms.Label();
            this.txt6Valor = new System.Windows.Forms.TextBox();
            this.txt5Valor = new System.Windows.Forms.TextBox();
            this.lblValor6 = new System.Windows.Forms.Label();
            this.lblValor5 = new System.Windows.Forms.Label();
            this.lbl6Duplicata = new System.Windows.Forms.Label();
            this.lbl5Duplicata = new System.Windows.Forms.Label();
            this.txt4Valor = new System.Windows.Forms.TextBox();
            this.lblValor4 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txt3Valor = new System.Windows.Forms.TextBox();
            this.lbl4Duplicata = new System.Windows.Forms.Label();
            this.txt2Valor = new System.Windows.Forms.TextBox();
            this.txt1Valor = new System.Windows.Forms.TextBox();
            this.lbl3Duplicata = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lbl2Duplicata = new System.Windows.Forms.Label();
            this.lbl1Duplicata = new System.Windows.Forms.Label();
            this.comboDuplicatas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.listProdutosNota = new System.Windows.Forms.ListView();
            this.coluna1Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbProdutoNota = new System.Windows.Forms.GroupBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.comboNome = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.grpbDadosDaNota.SuspendLayout();
            this.grpbDadosPagamento.SuspendLayout();
            this.grpbProdutoNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.Location = new System.Drawing.Point(274, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Nota:";
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNumeroNota.Location = new System.Drawing.Point(394, 13);
            this.txtNumeroNota.MaxLength = 10;
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(107, 25);
            this.txtNumeroNota.TabIndex = 1;
            this.txtNumeroNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroNota_KeyPress);
            // 
            // grpbDadosDaNota
            // 
            this.grpbDadosDaNota.Controls.Add(this.txtSerie);
            this.grpbDadosDaNota.Controls.Add(this.mtxtNumeroSefaz);
            this.grpbDadosDaNota.Controls.Add(this.label2);
            this.grpbDadosDaNota.Controls.Add(this.label4);
            this.grpbDadosDaNota.Controls.Add(this.lblNumeroPedido);
            this.grpbDadosDaNota.Controls.Add(this.label1);
            this.grpbDadosDaNota.Controls.Add(this.txtNumeroPedido);
            this.grpbDadosDaNota.Controls.Add(this.txtNumeroNota);
            this.grpbDadosDaNota.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDadosDaNota.Location = new System.Drawing.Point(12, 12);
            this.grpbDadosDaNota.Name = "grpbDadosDaNota";
            this.grpbDadosDaNota.Size = new System.Drawing.Size(660, 74);
            this.grpbDadosDaNota.TabIndex = 0;
            this.grpbDadosDaNota.TabStop = false;
            this.grpbDadosDaNota.Text = "Dados da Nota";
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtSerie.Location = new System.Drawing.Point(584, 13);
            this.txtSerie.MaxLength = 10;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(70, 25);
            this.txtSerie.TabIndex = 2;
            // 
            // mtxtNumeroSefaz
            // 
            this.mtxtNumeroSefaz.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtNumeroSefaz.Location = new System.Drawing.Point(141, 42);
            this.mtxtNumeroSefaz.Mask = "0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000";
            this.mtxtNumeroSefaz.Name = "mtxtNumeroSefaz";
            this.mtxtNumeroSefaz.Size = new System.Drawing.Size(360, 25);
            this.mtxtNumeroSefaz.TabIndex = 3;
            this.mtxtNumeroSefaz.Click += new System.EventHandler(this.mtxtNumeroSefaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Sefaz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label4.Location = new System.Drawing.Point(533, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Série:";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNumeroPedido.Location = new System.Drawing.Point(6, 16);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(131, 18);
            this.lblNumeroPedido.TabIndex = 4;
            this.lblNumeroPedido.Text = "Número do Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtNumeroPedido.Location = new System.Drawing.Point(141, 13);
            this.txtNumeroPedido.MaxLength = 10;
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(100, 25);
            this.txtNumeroPedido.TabIndex = 0;
            this.txtNumeroPedido.TextChanged += new System.EventHandler(this.txtNumeroPedido_TextChanged);
            this.txtNumeroPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPedido_KeyPress);
            // 
            // grpbDadosPagamento
            // 
            this.grpbDadosPagamento.Controls.Add(this.mtxt6Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.mtxt5Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.mtxt4Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.mtxt3Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.mtxt2Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.mtxt1Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.comboCFOP);
            this.grpbDadosPagamento.Controls.Add(this.lblCFOP);
            this.grpbDadosPagamento.Controls.Add(this.txt6Valor);
            this.grpbDadosPagamento.Controls.Add(this.txt5Valor);
            this.grpbDadosPagamento.Controls.Add(this.lblValor6);
            this.grpbDadosPagamento.Controls.Add(this.lblValor5);
            this.grpbDadosPagamento.Controls.Add(this.lbl6Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.lbl5Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.txt4Valor);
            this.grpbDadosPagamento.Controls.Add(this.lblValor4);
            this.grpbDadosPagamento.Controls.Add(this.lblValor3);
            this.grpbDadosPagamento.Controls.Add(this.lblValor2);
            this.grpbDadosPagamento.Controls.Add(this.txt3Valor);
            this.grpbDadosPagamento.Controls.Add(this.lbl4Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.txt2Valor);
            this.grpbDadosPagamento.Controls.Add(this.txt1Valor);
            this.grpbDadosPagamento.Controls.Add(this.lbl3Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.lblValor1);
            this.grpbDadosPagamento.Controls.Add(this.lbl2Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.lbl1Duplicata);
            this.grpbDadosPagamento.Controls.Add(this.comboDuplicatas);
            this.grpbDadosPagamento.Controls.Add(this.label5);
            this.grpbDadosPagamento.Controls.Add(this.mtxtDataEmissao);
            this.grpbDadosPagamento.Controls.Add(this.label3);
            this.grpbDadosPagamento.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDadosPagamento.Location = new System.Drawing.Point(12, 92);
            this.grpbDadosPagamento.Name = "grpbDadosPagamento";
            this.grpbDadosPagamento.Size = new System.Drawing.Size(660, 205);
            this.grpbDadosPagamento.TabIndex = 1;
            this.grpbDadosPagamento.TabStop = false;
            this.grpbDadosPagamento.Text = "Dados";
            // 
            // mtxt6Duplicata
            // 
            this.mtxt6Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt6Duplicata.Location = new System.Drawing.Point(313, 168);
            this.mtxt6Duplicata.Mask = "00/00/0000";
            this.mtxt6Duplicata.Name = "mtxt6Duplicata";
            this.mtxt6Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt6Duplicata.TabIndex = 13;
            this.mtxt6Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt6Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt6Duplicata.Visible = false;
            this.mtxt6Duplicata.Click += new System.EventHandler(this.mtxt6Duplicata_Click);
            // 
            // mtxt5Duplicata
            // 
            this.mtxt5Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt5Duplicata.Location = new System.Drawing.Point(313, 137);
            this.mtxt5Duplicata.Mask = "00/00/0000";
            this.mtxt5Duplicata.Name = "mtxt5Duplicata";
            this.mtxt5Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt5Duplicata.TabIndex = 11;
            this.mtxt5Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt5Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt5Duplicata.Visible = false;
            this.mtxt5Duplicata.Click += new System.EventHandler(this.mtxt5Duplicata_Click);
            // 
            // mtxt4Duplicata
            // 
            this.mtxt4Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt4Duplicata.Location = new System.Drawing.Point(313, 106);
            this.mtxt4Duplicata.Mask = "00/00/0000";
            this.mtxt4Duplicata.Name = "mtxt4Duplicata";
            this.mtxt4Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt4Duplicata.TabIndex = 9;
            this.mtxt4Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt4Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt4Duplicata.Visible = false;
            this.mtxt4Duplicata.Click += new System.EventHandler(this.mtxt4Duplicata_Click);
            // 
            // mtxt3Duplicata
            // 
            this.mtxt3Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt3Duplicata.Location = new System.Drawing.Point(313, 75);
            this.mtxt3Duplicata.Mask = "00/00/0000";
            this.mtxt3Duplicata.Name = "mtxt3Duplicata";
            this.mtxt3Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt3Duplicata.TabIndex = 7;
            this.mtxt3Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt3Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt3Duplicata.Visible = false;
            this.mtxt3Duplicata.Click += new System.EventHandler(this.mtxt3Duplicata_Click);
            // 
            // mtxt2Duplicata
            // 
            this.mtxt2Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt2Duplicata.Location = new System.Drawing.Point(313, 44);
            this.mtxt2Duplicata.Mask = "00/00/0000";
            this.mtxt2Duplicata.Name = "mtxt2Duplicata";
            this.mtxt2Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt2Duplicata.TabIndex = 5;
            this.mtxt2Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt2Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt2Duplicata.Visible = false;
            this.mtxt2Duplicata.Click += new System.EventHandler(this.mtxt2Duplicata_Click);
            // 
            // mtxt1Duplicata
            // 
            this.mtxt1Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxt1Duplicata.Location = new System.Drawing.Point(313, 13);
            this.mtxt1Duplicata.Mask = "00/00/0000";
            this.mtxt1Duplicata.Name = "mtxt1Duplicata";
            this.mtxt1Duplicata.Size = new System.Drawing.Size(100, 25);
            this.mtxt1Duplicata.TabIndex = 3;
            this.mtxt1Duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt1Duplicata.ValidatingType = typeof(System.DateTime);
            this.mtxt1Duplicata.Visible = false;
            this.mtxt1Duplicata.Click += new System.EventHandler(this.mtxt1Duplicata_Click);
            // 
            // comboCFOP
            // 
            this.comboCFOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCFOP.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboCFOP.FormattingEnabled = true;
            this.comboCFOP.Location = new System.Drawing.Point(134, 76);
            this.comboCFOP.Name = "comboCFOP";
            this.comboCFOP.Size = new System.Drawing.Size(73, 26);
            this.comboCFOP.TabIndex = 2;
            // 
            // lblCFOP
            // 
            this.lblCFOP.AutoSize = true;
            this.lblCFOP.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCFOP.Location = new System.Drawing.Point(6, 78);
            this.lblCFOP.Name = "lblCFOP";
            this.lblCFOP.Size = new System.Drawing.Size(46, 18);
            this.lblCFOP.TabIndex = 35;
            this.lblCFOP.Text = "CFOP:";
            // 
            // txt6Valor
            // 
            this.txt6Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt6Valor.Location = new System.Drawing.Point(484, 168);
            this.txt6Valor.MaxLength = 10;
            this.txt6Valor.Name = "txt6Valor";
            this.txt6Valor.Size = new System.Drawing.Size(170, 25);
            this.txt6Valor.TabIndex = 14;
            this.txt6Valor.Visible = false;
            this.txt6Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt6Valor_KeyPress);
            // 
            // txt5Valor
            // 
            this.txt5Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt5Valor.Location = new System.Drawing.Point(484, 137);
            this.txt5Valor.MaxLength = 10;
            this.txt5Valor.Name = "txt5Valor";
            this.txt5Valor.Size = new System.Drawing.Size(170, 25);
            this.txt5Valor.TabIndex = 12;
            this.txt5Valor.Visible = false;
            this.txt5Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt5Valor_KeyPress);
            // 
            // lblValor6
            // 
            this.lblValor6.AutoSize = true;
            this.lblValor6.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor6.Location = new System.Drawing.Point(419, 171);
            this.lblValor6.Name = "lblValor6";
            this.lblValor6.Size = new System.Drawing.Size(45, 18);
            this.lblValor6.TabIndex = 32;
            this.lblValor6.Text = "Valor:";
            this.lblValor6.Visible = false;
            // 
            // lblValor5
            // 
            this.lblValor5.AutoSize = true;
            this.lblValor5.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor5.Location = new System.Drawing.Point(419, 140);
            this.lblValor5.Name = "lblValor5";
            this.lblValor5.Size = new System.Drawing.Size(45, 18);
            this.lblValor5.TabIndex = 31;
            this.lblValor5.Text = "Valor:";
            this.lblValor5.Visible = false;
            // 
            // lbl6Duplicata
            // 
            this.lbl6Duplicata.AutoSize = true;
            this.lbl6Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl6Duplicata.Location = new System.Drawing.Point(218, 171);
            this.lbl6Duplicata.Name = "lbl6Duplicata";
            this.lbl6Duplicata.Size = new System.Drawing.Size(89, 18);
            this.lbl6Duplicata.TabIndex = 29;
            this.lbl6Duplicata.Text = "6ª Duplicata:";
            this.lbl6Duplicata.Visible = false;
            // 
            // lbl5Duplicata
            // 
            this.lbl5Duplicata.AutoSize = true;
            this.lbl5Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl5Duplicata.Location = new System.Drawing.Point(218, 140);
            this.lbl5Duplicata.Name = "lbl5Duplicata";
            this.lbl5Duplicata.Size = new System.Drawing.Size(89, 18);
            this.lbl5Duplicata.TabIndex = 27;
            this.lbl5Duplicata.Text = "5ª Duplicata:";
            this.lbl5Duplicata.Visible = false;
            // 
            // txt4Valor
            // 
            this.txt4Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt4Valor.Location = new System.Drawing.Point(484, 106);
            this.txt4Valor.MaxLength = 10;
            this.txt4Valor.Name = "txt4Valor";
            this.txt4Valor.Size = new System.Drawing.Size(170, 25);
            this.txt4Valor.TabIndex = 10;
            this.txt4Valor.Visible = false;
            this.txt4Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4Valor_KeyPress);
            // 
            // lblValor4
            // 
            this.lblValor4.AutoSize = true;
            this.lblValor4.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor4.Location = new System.Drawing.Point(419, 109);
            this.lblValor4.Name = "lblValor4";
            this.lblValor4.Size = new System.Drawing.Size(45, 18);
            this.lblValor4.TabIndex = 25;
            this.lblValor4.Text = "Valor:";
            this.lblValor4.Visible = false;
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor3.Location = new System.Drawing.Point(419, 78);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(45, 18);
            this.lblValor3.TabIndex = 24;
            this.lblValor3.Text = "Valor:";
            this.lblValor3.Visible = false;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor2.Location = new System.Drawing.Point(419, 47);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(45, 18);
            this.lblValor2.TabIndex = 23;
            this.lblValor2.Text = "Valor:";
            this.lblValor2.Visible = false;
            // 
            // txt3Valor
            // 
            this.txt3Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt3Valor.Location = new System.Drawing.Point(484, 75);
            this.txt3Valor.MaxLength = 10;
            this.txt3Valor.Name = "txt3Valor";
            this.txt3Valor.Size = new System.Drawing.Size(170, 25);
            this.txt3Valor.TabIndex = 8;
            this.txt3Valor.Visible = false;
            this.txt3Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3Valor_KeyPress);
            // 
            // lbl4Duplicata
            // 
            this.lbl4Duplicata.AutoSize = true;
            this.lbl4Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl4Duplicata.Location = new System.Drawing.Point(217, 109);
            this.lbl4Duplicata.Name = "lbl4Duplicata";
            this.lbl4Duplicata.Size = new System.Drawing.Size(90, 18);
            this.lbl4Duplicata.TabIndex = 19;
            this.lbl4Duplicata.Text = "4ª Duplicata:";
            this.lbl4Duplicata.Visible = false;
            // 
            // txt2Valor
            // 
            this.txt2Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt2Valor.Location = new System.Drawing.Point(484, 44);
            this.txt2Valor.MaxLength = 10;
            this.txt2Valor.Name = "txt2Valor";
            this.txt2Valor.Size = new System.Drawing.Size(170, 25);
            this.txt2Valor.TabIndex = 6;
            this.txt2Valor.Visible = false;
            this.txt2Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Valor_KeyPress);
            // 
            // txt1Valor
            // 
            this.txt1Valor.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txt1Valor.Location = new System.Drawing.Point(484, 13);
            this.txt1Valor.MaxLength = 10;
            this.txt1Valor.Name = "txt1Valor";
            this.txt1Valor.Size = new System.Drawing.Size(170, 25);
            this.txt1Valor.TabIndex = 4;
            this.txt1Valor.Visible = false;
            this.txt1Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1Valor_KeyPress);
            // 
            // lbl3Duplicata
            // 
            this.lbl3Duplicata.AutoSize = true;
            this.lbl3Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl3Duplicata.Location = new System.Drawing.Point(218, 78);
            this.lbl3Duplicata.Name = "lbl3Duplicata";
            this.lbl3Duplicata.Size = new System.Drawing.Size(89, 18);
            this.lbl3Duplicata.TabIndex = 16;
            this.lbl3Duplicata.Text = "3ª Duplicata:";
            this.lbl3Duplicata.Visible = false;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValor1.Location = new System.Drawing.Point(419, 16);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(45, 18);
            this.lblValor1.TabIndex = 15;
            this.lblValor1.Text = "Valor:";
            this.lblValor1.Visible = false;
            // 
            // lbl2Duplicata
            // 
            this.lbl2Duplicata.AutoSize = true;
            this.lbl2Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl2Duplicata.Location = new System.Drawing.Point(218, 47);
            this.lbl2Duplicata.Name = "lbl2Duplicata";
            this.lbl2Duplicata.Size = new System.Drawing.Size(89, 18);
            this.lbl2Duplicata.TabIndex = 13;
            this.lbl2Duplicata.Text = "2ª Duplicata:";
            this.lbl2Duplicata.Visible = false;
            // 
            // lbl1Duplicata
            // 
            this.lbl1Duplicata.AutoSize = true;
            this.lbl1Duplicata.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lbl1Duplicata.Location = new System.Drawing.Point(221, 16);
            this.lbl1Duplicata.Name = "lbl1Duplicata";
            this.lbl1Duplicata.Size = new System.Drawing.Size(86, 18);
            this.lbl1Duplicata.TabIndex = 12;
            this.lbl1Duplicata.Text = "1ª Duplicata:";
            this.lbl1Duplicata.Visible = false;
            // 
            // comboDuplicatas
            // 
            this.comboDuplicatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuplicatas.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboDuplicatas.FormattingEnabled = true;
            this.comboDuplicatas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            ""});
            this.comboDuplicatas.Location = new System.Drawing.Point(134, 44);
            this.comboDuplicatas.Name = "comboDuplicatas";
            this.comboDuplicatas.Size = new System.Drawing.Size(73, 26);
            this.comboDuplicatas.TabIndex = 1;
            this.comboDuplicatas.SelectedIndexChanged += new System.EventHandler(this.comboDuplicatas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Duplicatas:";
            // 
            // mtxtDataEmissao
            // 
            this.mtxtDataEmissao.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtDataEmissao.Location = new System.Drawing.Point(134, 13);
            this.mtxtDataEmissao.Mask = "00/00/0000";
            this.mtxtDataEmissao.Name = "mtxtDataEmissao";
            this.mtxtDataEmissao.Size = new System.Drawing.Size(73, 25);
            this.mtxtDataEmissao.TabIndex = 0;
            this.mtxtDataEmissao.ValidatingType = typeof(System.DateTime);
            this.mtxtDataEmissao.Click += new System.EventHandler(this.mtxtDataEmissao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Emissão:";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btRegistrar.Location = new System.Drawing.Point(12, 602);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(85, 26);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btPesquisar.Location = new System.Drawing.Point(103, 602);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(85, 26);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btVoltar.Location = new System.Drawing.Point(587, 602);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 26);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // listProdutosNota
            // 
            this.listProdutosNota.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1Nome,
            this.coluna2Quantidade,
            this.coluna3Lote,
            this.coluna4Validade});
            this.listProdutosNota.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.listProdutosNota.Location = new System.Drawing.Point(12, 425);
            this.listProdutosNota.Name = "listProdutosNota";
            this.listProdutosNota.Size = new System.Drawing.Size(660, 171);
            this.listProdutosNota.TabIndex = 7;
            this.listProdutosNota.UseCompatibleStateImageBehavior = false;
            this.listProdutosNota.View = System.Windows.Forms.View.Details;
            // 
            // coluna1Nome
            // 
            this.coluna1Nome.Text = "Nome do Produto";
            this.coluna1Nome.Width = 250;
            // 
            // coluna2Quantidade
            // 
            this.coluna2Quantidade.Text = "Quantidade";
            this.coluna2Quantidade.Width = 90;
            // 
            // coluna3Lote
            // 
            this.coluna3Lote.Text = "Lote";
            this.coluna3Lote.Width = 150;
            // 
            // coluna4Validade
            // 
            this.coluna4Validade.Text = "Validade";
            this.coluna4Validade.Width = 80;
            // 
            // grpbProdutoNota
            // 
            this.grpbProdutoNota.Controls.Add(this.btAdicionar);
            this.grpbProdutoNota.Controls.Add(this.btRemover);
            this.grpbProdutoNota.Controls.Add(this.comboNome);
            this.grpbProdutoNota.Controls.Add(this.btNovo);
            this.grpbProdutoNota.Controls.Add(this.btEditar);
            this.grpbProdutoNota.Controls.Add(this.txtQuantidade);
            this.grpbProdutoNota.Controls.Add(this.lblQuantidade);
            this.grpbProdutoNota.Controls.Add(this.mtxtValidade);
            this.grpbProdutoNota.Controls.Add(this.lblValidade);
            this.grpbProdutoNota.Controls.Add(this.lblLote);
            this.grpbProdutoNota.Controls.Add(this.lblNome);
            this.grpbProdutoNota.Controls.Add(this.txtLote);
            this.grpbProdutoNota.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProdutoNota.Location = new System.Drawing.Point(12, 303);
            this.grpbProdutoNota.Name = "grpbProdutoNota";
            this.grpbProdutoNota.Size = new System.Drawing.Size(660, 116);
            this.grpbProdutoNota.TabIndex = 2;
            this.grpbProdutoNota.TabStop = false;
            this.grpbProdutoNota.Text = "Produtos da Nota";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btAdicionar.Location = new System.Drawing.Point(264, 85);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(80, 25);
            this.btAdicionar.TabIndex = 45;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btRemover.Location = new System.Drawing.Point(178, 85);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(80, 25);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // comboNome
            // 
            this.comboNome.Enabled = false;
            this.comboNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.comboNome.FormattingEnabled = true;
            this.comboNome.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            ""});
            this.comboNome.Location = new System.Drawing.Point(65, 16);
            this.comboNome.Name = "comboNome";
            this.comboNome.Size = new System.Drawing.Size(589, 26);
            this.comboNome.TabIndex = 43;
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btNovo.Location = new System.Drawing.Point(92, 85);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(80, 25);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btEditar.Location = new System.Drawing.Point(6, 85);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(80, 25);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtQuantidade.Location = new System.Drawing.Point(533, 48);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(121, 25);
            this.txtQuantidade.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblQuantidade.Location = new System.Drawing.Point(441, 51);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 18);
            this.lblQuantidade.TabIndex = 44;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.mtxtValidade.Location = new System.Drawing.Point(350, 48);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(85, 25);
            this.mtxtValidade.TabIndex = 1;
            this.mtxtValidade.ValidatingType = typeof(System.DateTime);
            this.mtxtValidade.Click += new System.EventHandler(this.mtxtValidade_Click);
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblValidade.Location = new System.Drawing.Point(276, 51);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(68, 18);
            this.lblValidade.TabIndex = 8;
            this.lblValidade.Text = "Validade:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblLote.Location = new System.Drawing.Point(6, 51);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(41, 18);
            this.lblLote.TabIndex = 2;
            this.lblLote.Text = "Lote:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblNome.Location = new System.Drawing.Point(6, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.txtLote.Location = new System.Drawing.Point(65, 48);
            this.txtLote.MaxLength = 10;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(205, 25);
            this.txtLote.TabIndex = 0;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btLimpar.Location = new System.Drawing.Point(486, 602);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 26);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar Tela";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmEntradaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 639);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.grpbProdutoNota);
            this.Controls.Add(this.listProdutosNota);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.grpbDadosPagamento);
            this.Controls.Add(this.grpbDadosDaNota);
            this.Name = "FrmEntradaNota";
            this.Text = "Entrada de Nota Fiscal";
            this.grpbDadosDaNota.ResumeLayout(false);
            this.grpbDadosDaNota.PerformLayout();
            this.grpbDadosPagamento.ResumeLayout(false);
            this.grpbDadosPagamento.PerformLayout();
            this.grpbProdutoNota.ResumeLayout(false);
            this.grpbProdutoNota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.GroupBox grpbDadosDaNota;
        private System.Windows.Forms.MaskedTextBox mtxtNumeroSefaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.GroupBox grpbDadosPagamento;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt6Valor;
        private System.Windows.Forms.TextBox txt5Valor;
        private System.Windows.Forms.Label lblValor6;
        private System.Windows.Forms.Label lblValor5;
        private System.Windows.Forms.Label lbl6Duplicata;
        private System.Windows.Forms.Label lbl5Duplicata;
        private System.Windows.Forms.TextBox txt4Valor;
        private System.Windows.Forms.Label lblValor4;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txt3Valor;
        private System.Windows.Forms.Label lbl4Duplicata;
        private System.Windows.Forms.TextBox txt2Valor;
        private System.Windows.Forms.TextBox txt1Valor;
        private System.Windows.Forms.Label lbl3Duplicata;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lbl2Duplicata;
        private System.Windows.Forms.Label lbl1Duplicata;
        private System.Windows.Forms.ComboBox comboDuplicatas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCFOP;
        private System.Windows.Forms.Label lblCFOP;
        private System.Windows.Forms.MaskedTextBox mtxt6Duplicata;
        private System.Windows.Forms.MaskedTextBox mtxt5Duplicata;
        private System.Windows.Forms.MaskedTextBox mtxt4Duplicata;
        private System.Windows.Forms.MaskedTextBox mtxt3Duplicata;
        private System.Windows.Forms.MaskedTextBox mtxt2Duplicata;
        private System.Windows.Forms.MaskedTextBox mtxt1Duplicata;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.ListView listProdutosNota;
        private System.Windows.Forms.GroupBox grpbProdutoNota;
        private System.Windows.Forms.ComboBox comboNome;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.ColumnHeader coluna1Nome;
        private System.Windows.Forms.ColumnHeader coluna2Quantidade;
        private System.Windows.Forms.ColumnHeader coluna3Lote;
        private System.Windows.Forms.ColumnHeader coluna4Validade;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAdicionar;
    }
}