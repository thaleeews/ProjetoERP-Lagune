namespace ProjetoLagune.Financas.ContasPagas
{
    partial class FrmContasPagas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagas));
            this.btMin = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coluna1DataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna2DataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna3Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna4Beneficiario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna5Descri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalGasto = new System.Windows.Forms.Label();
            this.lblValorTotalGasto = new System.Windows.Forms.Label();
            this.lblJaneiro = new System.Windows.Forms.Label();
            this.lblFevereiro = new System.Windows.Forms.Label();
            this.lblMarco = new System.Windows.Forms.Label();
            this.lblValorMarco = new System.Windows.Forms.Label();
            this.lblValorFevereiro = new System.Windows.Forms.Label();
            this.lblValorJaneiro = new System.Windows.Forms.Label();
            this.lblValorAbril = new System.Windows.Forms.Label();
            this.lblAbril = new System.Windows.Forms.Label();
            this.lblValorMaio = new System.Windows.Forms.Label();
            this.lblMaio = new System.Windows.Forms.Label();
            this.lblValorJunho = new System.Windows.Forms.Label();
            this.lblJunho = new System.Windows.Forms.Label();
            this.lblValorJulho = new System.Windows.Forms.Label();
            this.lblJulho = new System.Windows.Forms.Label();
            this.lblValorSetembro = new System.Windows.Forms.Label();
            this.lblSetembro = new System.Windows.Forms.Label();
            this.lblValorAgosto = new System.Windows.Forms.Label();
            this.lblAgosto = new System.Windows.Forms.Label();
            this.lblValorDezembro = new System.Windows.Forms.Label();
            this.lblDezembro = new System.Windows.Forms.Label();
            this.lblValorNovembro = new System.Windows.Forms.Label();
            this.lblNovembro = new System.Windows.Forms.Label();
            this.lblValorOutubro = new System.Windows.Forms.Label();
            this.lblOutubro = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDdP = new System.Windows.Forms.Label();
            this.dtpDdP = new System.Windows.Forms.DateTimePicker();
            this.dtpDdV = new System.Windows.Forms.DateTimePicker();
            this.lblDdV = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblBen = new System.Windows.Forms.Label();
            this.cbBen = new ProjetoLagune.Controls.ComboAuto();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(742, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 6;
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
            this.btX.Location = new System.Drawing.Point(767, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 5;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 8;
            this.label7.Tag = "";
            this.label7.Text = "CONTAS PAGAS";
            // 
            // pbCor
            // 
            this.pbCor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCor.Image = ((System.Drawing.Image)(resources.GetObject("pbCor.Image")));
            this.pbCor.Location = new System.Drawing.Point(0, 0);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(5, 668);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 9;
            this.pbCor.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna1DataPagamento,
            this.coluna2DataVencimento,
            this.coluna3Valor,
            this.coluna4Beneficiario,
            this.coluna5Descri});
            this.listView1.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.listView1.Location = new System.Drawing.Point(13, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 223);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // coluna1DataPagamento
            // 
            this.coluna1DataPagamento.Text = "Data de Pagamento";
            this.coluna1DataPagamento.Width = 113;
            // 
            // coluna2DataVencimento
            // 
            this.coluna2DataVencimento.Text = "Data de Vencimento";
            this.coluna2DataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna2DataVencimento.Width = 131;
            // 
            // coluna3Valor
            // 
            this.coluna3Valor.Text = "Valor";
            this.coluna3Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna3Valor.Width = 88;
            // 
            // coluna4Beneficiario
            // 
            this.coluna4Beneficiario.Text = "Beneficiário";
            this.coluna4Beneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna4Beneficiario.Width = 233;
            // 
            // coluna5Descri
            // 
            this.coluna5Descri.Text = "Descrição";
            this.coluna5Descri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluna5Descri.Width = 198;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.lblValorDezembro);
            this.panel1.Controls.Add(this.lblDezembro);
            this.panel1.Controls.Add(this.lblValorNovembro);
            this.panel1.Controls.Add(this.lblNovembro);
            this.panel1.Controls.Add(this.lblValorOutubro);
            this.panel1.Controls.Add(this.lblOutubro);
            this.panel1.Controls.Add(this.lblValorSetembro);
            this.panel1.Controls.Add(this.lblSetembro);
            this.panel1.Controls.Add(this.lblValorAgosto);
            this.panel1.Controls.Add(this.lblAgosto);
            this.panel1.Controls.Add(this.lblValorJulho);
            this.panel1.Controls.Add(this.lblJulho);
            this.panel1.Controls.Add(this.lblValorJunho);
            this.panel1.Controls.Add(this.lblJunho);
            this.panel1.Controls.Add(this.lblValorMaio);
            this.panel1.Controls.Add(this.lblMaio);
            this.panel1.Controls.Add(this.lblValorAbril);
            this.panel1.Controls.Add(this.lblAbril);
            this.panel1.Controls.Add(this.lblValorJaneiro);
            this.panel1.Controls.Add(this.lblValorFevereiro);
            this.panel1.Controls.Add(this.lblValorMarco);
            this.panel1.Controls.Add(this.lblMarco);
            this.panel1.Controls.Add(this.lblFevereiro);
            this.panel1.Controls.Add(this.lblJaneiro);
            this.panel1.Controls.Add(this.lblValorTotalGasto);
            this.panel1.Controls.Add(this.lblTotalGasto);
            this.panel1.Location = new System.Drawing.Point(13, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 175);
            this.panel1.TabIndex = 11;
            // 
            // lblTotalGasto
            // 
            this.lblTotalGasto.AutoSize = true;
            this.lblTotalGasto.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.lblTotalGasto.Location = new System.Drawing.Point(4, 4);
            this.lblTotalGasto.Name = "lblTotalGasto";
            this.lblTotalGasto.Size = new System.Drawing.Size(135, 24);
            this.lblTotalGasto.TabIndex = 0;
            this.lblTotalGasto.Text = "TOTAL GASTO:";
            // 
            // lblValorTotalGasto
            // 
            this.lblValorTotalGasto.AutoSize = true;
            this.lblValorTotalGasto.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.lblValorTotalGasto.Location = new System.Drawing.Point(145, 4);
            this.lblValorTotalGasto.Name = "lblValorTotalGasto";
            this.lblValorTotalGasto.Size = new System.Drawing.Size(151, 24);
            this.lblValorTotalGasto.TabIndex = 1;
            this.lblValorTotalGasto.Text = "R$ 00000000,00";
            // 
            // lblJaneiro
            // 
            this.lblJaneiro.AutoSize = true;
            this.lblJaneiro.Location = new System.Drawing.Point(5, 38);
            this.lblJaneiro.Name = "lblJaneiro";
            this.lblJaneiro.Size = new System.Drawing.Size(61, 18);
            this.lblJaneiro.TabIndex = 2;
            this.lblJaneiro.Text = "Janeiro:";
            // 
            // lblFevereiro
            // 
            this.lblFevereiro.AutoSize = true;
            this.lblFevereiro.Location = new System.Drawing.Point(5, 84);
            this.lblFevereiro.Name = "lblFevereiro";
            this.lblFevereiro.Size = new System.Drawing.Size(75, 18);
            this.lblFevereiro.TabIndex = 3;
            this.lblFevereiro.Text = "Fevereiro:";
            // 
            // lblMarco
            // 
            this.lblMarco.AutoSize = true;
            this.lblMarco.Location = new System.Drawing.Point(5, 130);
            this.lblMarco.Name = "lblMarco";
            this.lblMarco.Size = new System.Drawing.Size(52, 18);
            this.lblMarco.TabIndex = 4;
            this.lblMarco.Text = "Março:";
            // 
            // lblValorMarco
            // 
            this.lblValorMarco.AutoSize = true;
            this.lblValorMarco.Location = new System.Drawing.Point(5, 148);
            this.lblValorMarco.Name = "lblValorMarco";
            this.lblValorMarco.Size = new System.Drawing.Size(97, 18);
            this.lblValorMarco.TabIndex = 5;
            this.lblValorMarco.Text = "R$ 000000,00";
            // 
            // lblValorFevereiro
            // 
            this.lblValorFevereiro.AutoSize = true;
            this.lblValorFevereiro.Location = new System.Drawing.Point(5, 102);
            this.lblValorFevereiro.Name = "lblValorFevereiro";
            this.lblValorFevereiro.Size = new System.Drawing.Size(97, 18);
            this.lblValorFevereiro.TabIndex = 6;
            this.lblValorFevereiro.Text = "R$ 000000,00";
            // 
            // lblValorJaneiro
            // 
            this.lblValorJaneiro.AutoSize = true;
            this.lblValorJaneiro.Location = new System.Drawing.Point(5, 56);
            this.lblValorJaneiro.Name = "lblValorJaneiro";
            this.lblValorJaneiro.Size = new System.Drawing.Size(97, 18);
            this.lblValorJaneiro.TabIndex = 7;
            this.lblValorJaneiro.Text = "R$ 000000,00";
            // 
            // lblValorAbril
            // 
            this.lblValorAbril.AutoSize = true;
            this.lblValorAbril.Location = new System.Drawing.Point(227, 56);
            this.lblValorAbril.Name = "lblValorAbril";
            this.lblValorAbril.Size = new System.Drawing.Size(97, 18);
            this.lblValorAbril.TabIndex = 9;
            this.lblValorAbril.Text = "R$ 000000,00";
            // 
            // lblAbril
            // 
            this.lblAbril.AutoSize = true;
            this.lblAbril.Location = new System.Drawing.Point(227, 38);
            this.lblAbril.Name = "lblAbril";
            this.lblAbril.Size = new System.Drawing.Size(43, 18);
            this.lblAbril.TabIndex = 8;
            this.lblAbril.Text = "Abril:";
            // 
            // lblValorMaio
            // 
            this.lblValorMaio.AutoSize = true;
            this.lblValorMaio.Location = new System.Drawing.Point(227, 102);
            this.lblValorMaio.Name = "lblValorMaio";
            this.lblValorMaio.Size = new System.Drawing.Size(97, 18);
            this.lblValorMaio.TabIndex = 11;
            this.lblValorMaio.Text = "R$ 000000,00";
            // 
            // lblMaio
            // 
            this.lblMaio.AutoSize = true;
            this.lblMaio.Location = new System.Drawing.Point(227, 84);
            this.lblMaio.Name = "lblMaio";
            this.lblMaio.Size = new System.Drawing.Size(43, 18);
            this.lblMaio.TabIndex = 10;
            this.lblMaio.Text = "Maio:";
            // 
            // lblValorJunho
            // 
            this.lblValorJunho.AutoSize = true;
            this.lblValorJunho.Location = new System.Drawing.Point(227, 148);
            this.lblValorJunho.Name = "lblValorJunho";
            this.lblValorJunho.Size = new System.Drawing.Size(97, 18);
            this.lblValorJunho.TabIndex = 13;
            this.lblValorJunho.Text = "R$ 000000,00";
            // 
            // lblJunho
            // 
            this.lblJunho.AutoSize = true;
            this.lblJunho.Location = new System.Drawing.Point(227, 130);
            this.lblJunho.Name = "lblJunho";
            this.lblJunho.Size = new System.Drawing.Size(51, 18);
            this.lblJunho.TabIndex = 12;
            this.lblJunho.Text = "Junho:";
            // 
            // lblValorJulho
            // 
            this.lblValorJulho.AutoSize = true;
            this.lblValorJulho.Location = new System.Drawing.Point(449, 56);
            this.lblValorJulho.Name = "lblValorJulho";
            this.lblValorJulho.Size = new System.Drawing.Size(97, 18);
            this.lblValorJulho.TabIndex = 15;
            this.lblValorJulho.Text = "R$ 000000,00";
            // 
            // lblJulho
            // 
            this.lblJulho.AutoSize = true;
            this.lblJulho.Location = new System.Drawing.Point(449, 38);
            this.lblJulho.Name = "lblJulho";
            this.lblJulho.Size = new System.Drawing.Size(47, 18);
            this.lblJulho.TabIndex = 14;
            this.lblJulho.Text = "Julho:";
            // 
            // lblValorSetembro
            // 
            this.lblValorSetembro.AutoSize = true;
            this.lblValorSetembro.Location = new System.Drawing.Point(449, 148);
            this.lblValorSetembro.Name = "lblValorSetembro";
            this.lblValorSetembro.Size = new System.Drawing.Size(97, 18);
            this.lblValorSetembro.TabIndex = 19;
            this.lblValorSetembro.Text = "R$ 000000,00";
            // 
            // lblSetembro
            // 
            this.lblSetembro.AutoSize = true;
            this.lblSetembro.Location = new System.Drawing.Point(449, 130);
            this.lblSetembro.Name = "lblSetembro";
            this.lblSetembro.Size = new System.Drawing.Size(76, 18);
            this.lblSetembro.TabIndex = 18;
            this.lblSetembro.Text = "Setembro:";
            // 
            // lblValorAgosto
            // 
            this.lblValorAgosto.AutoSize = true;
            this.lblValorAgosto.Location = new System.Drawing.Point(449, 102);
            this.lblValorAgosto.Name = "lblValorAgosto";
            this.lblValorAgosto.Size = new System.Drawing.Size(97, 18);
            this.lblValorAgosto.TabIndex = 17;
            this.lblValorAgosto.Text = "R$ 000000,00";
            // 
            // lblAgosto
            // 
            this.lblAgosto.AutoSize = true;
            this.lblAgosto.Location = new System.Drawing.Point(449, 84);
            this.lblAgosto.Name = "lblAgosto";
            this.lblAgosto.Size = new System.Drawing.Size(58, 18);
            this.lblAgosto.TabIndex = 16;
            this.lblAgosto.Text = "Agosto:";
            // 
            // lblValorDezembro
            // 
            this.lblValorDezembro.AutoSize = true;
            this.lblValorDezembro.Location = new System.Drawing.Point(661, 148);
            this.lblValorDezembro.Name = "lblValorDezembro";
            this.lblValorDezembro.Size = new System.Drawing.Size(97, 18);
            this.lblValorDezembro.TabIndex = 25;
            this.lblValorDezembro.Text = "R$ 000000,00";
            // 
            // lblDezembro
            // 
            this.lblDezembro.AutoSize = true;
            this.lblDezembro.Location = new System.Drawing.Point(661, 130);
            this.lblDezembro.Name = "lblDezembro";
            this.lblDezembro.Size = new System.Drawing.Size(79, 18);
            this.lblDezembro.TabIndex = 24;
            this.lblDezembro.Text = "Dezembro:";
            // 
            // lblValorNovembro
            // 
            this.lblValorNovembro.AutoSize = true;
            this.lblValorNovembro.Location = new System.Drawing.Point(661, 102);
            this.lblValorNovembro.Name = "lblValorNovembro";
            this.lblValorNovembro.Size = new System.Drawing.Size(97, 18);
            this.lblValorNovembro.TabIndex = 23;
            this.lblValorNovembro.Text = "R$ 000000,00";
            // 
            // lblNovembro
            // 
            this.lblNovembro.AutoSize = true;
            this.lblNovembro.Location = new System.Drawing.Point(661, 84);
            this.lblNovembro.Name = "lblNovembro";
            this.lblNovembro.Size = new System.Drawing.Size(81, 18);
            this.lblNovembro.TabIndex = 22;
            this.lblNovembro.Text = "Novembro:";
            // 
            // lblValorOutubro
            // 
            this.lblValorOutubro.AutoSize = true;
            this.lblValorOutubro.Location = new System.Drawing.Point(661, 56);
            this.lblValorOutubro.Name = "lblValorOutubro";
            this.lblValorOutubro.Size = new System.Drawing.Size(97, 18);
            this.lblValorOutubro.TabIndex = 21;
            this.lblValorOutubro.Text = "R$ 000000,00";
            // 
            // lblOutubro
            // 
            this.lblOutubro.AutoSize = true;
            this.lblOutubro.Location = new System.Drawing.Point(661, 38);
            this.lblOutubro.Name = "lblOutubro";
            this.lblOutubro.Size = new System.Drawing.Size(64, 18);
            this.lblOutubro.TabIndex = 20;
            this.lblOutubro.Text = "Outubro:";
            // 
            // lblVoltar
            // 
            this.lblVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblVoltar.Location = new System.Drawing.Point(704, 627);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(53, 22);
            this.lblVoltar.TabIndex = 26;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltar.Image")));
            this.pbVoltar.Location = new System.Drawing.Point(680, 621);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(100, 35);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 25;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pbVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pbVoltar_MouseLeave);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblEditar.Location = new System.Drawing.Point(38, 443);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(50, 22);
            this.lblEditar.TabIndex = 38;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.lblEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.lblEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(13, 437);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(100, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 37;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.btEditar_Click);
            this.pbEditar.MouseEnter += new System.EventHandler(this.pbEditar_MouseEnter);
            this.pbEditar.MouseLeave += new System.EventHandler(this.pbEditar_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBen);
            this.groupBox1.Controls.Add(this.lblBen);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblDdV);
            this.groupBox1.Controls.Add(this.dtpDdV);
            this.groupBox1.Controls.Add(this.dtpDdP);
            this.groupBox1.Controls.Add(this.lblDdP);
            this.groupBox1.Location = new System.Drawing.Point(13, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 136);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // lblDdP
            // 
            this.lblDdP.AutoSize = true;
            this.lblDdP.Location = new System.Drawing.Point(5, 29);
            this.lblDdP.Name = "lblDdP";
            this.lblDdP.Size = new System.Drawing.Size(136, 18);
            this.lblDdP.TabIndex = 0;
            this.lblDdP.Text = "Data de Pagamento";
            // 
            // dtpDdP
            // 
            this.dtpDdP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDdP.Location = new System.Drawing.Point(147, 24);
            this.dtpDdP.Name = "dtpDdP";
            this.dtpDdP.Size = new System.Drawing.Size(112, 25);
            this.dtpDdP.TabIndex = 1;
            // 
            // dtpDdV
            // 
            this.dtpDdV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDdV.Location = new System.Drawing.Point(409, 24);
            this.dtpDdV.Name = "dtpDdV";
            this.dtpDdV.Size = new System.Drawing.Size(112, 25);
            this.dtpDdV.TabIndex = 2;
            // 
            // lblDdV
            // 
            this.lblDdV.AutoSize = true;
            this.lblDdV.Location = new System.Drawing.Point(265, 29);
            this.lblDdV.Name = "lblDdV";
            this.lblDdV.Size = new System.Drawing.Size(138, 18);
            this.lblDdV.TabIndex = 3;
            this.lblDdV.Text = "Data de Vencimento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(527, 29);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 18);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(576, 24);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(149, 25);
            this.txtValor.TabIndex = 5;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUMERICA_KeyPress);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(5, 58);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 18);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(147, 55);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(578, 25);
            this.txtDesc.TabIndex = 7;
            // 
            // lblBen
            // 
            this.lblBen.AutoSize = true;
            this.lblBen.Location = new System.Drawing.Point(5, 89);
            this.lblBen.Name = "lblBen";
            this.lblBen.Size = new System.Drawing.Size(88, 18);
            this.lblBen.TabIndex = 8;
            this.lblBen.Text = "Beneficiário";
            // 
            // cbBen
            // 
            this.cbBen.FormattingEnabled = true;
            this.cbBen.LimitToList = true;
            this.cbBen.Location = new System.Drawing.Point(147, 86);
            this.cbBen.Name = "cbBen";
            this.cbBen.Size = new System.Drawing.Size(578, 26);
            this.cbBen.TabIndex = 9;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfirmar.Font = new System.Drawing.Font("BigNoodleTitling", 15F);
            this.lblConfirmar.Location = new System.Drawing.Point(130, 443);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(77, 22);
            this.lblConfirmar.TabIndex = 50;
            this.lblConfirmar.Text = "Confirmar";
            this.lblConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            this.lblConfirmar.MouseEnter += new System.EventHandler(this.pbConfirmar_MouseEnter);
            this.lblConfirmar.MouseLeave += new System.EventHandler(this.pbConfirmar_MouseLeave);
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(119, 437);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(100, 35);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmar.TabIndex = 49;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            this.pbConfirmar.MouseEnter += new System.EventHandler(this.pbConfirmar_MouseEnter);
            this.pbConfirmar.MouseLeave += new System.EventHandler(this.pbConfirmar_MouseLeave);
            // 
            // FrmContasPagas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(792, 668);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btX);
            this.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmContasPagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Pagas";
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coluna1DataPagamento;
        private System.Windows.Forms.ColumnHeader coluna2DataVencimento;
        private System.Windows.Forms.ColumnHeader coluna3Valor;
        private System.Windows.Forms.ColumnHeader coluna4Beneficiario;
        private System.Windows.Forms.ColumnHeader coluna5Descri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorDezembro;
        private System.Windows.Forms.Label lblDezembro;
        private System.Windows.Forms.Label lblValorNovembro;
        private System.Windows.Forms.Label lblNovembro;
        private System.Windows.Forms.Label lblValorOutubro;
        private System.Windows.Forms.Label lblOutubro;
        private System.Windows.Forms.Label lblValorSetembro;
        private System.Windows.Forms.Label lblSetembro;
        private System.Windows.Forms.Label lblValorAgosto;
        private System.Windows.Forms.Label lblAgosto;
        private System.Windows.Forms.Label lblValorJulho;
        private System.Windows.Forms.Label lblJulho;
        private System.Windows.Forms.Label lblValorJunho;
        private System.Windows.Forms.Label lblJunho;
        private System.Windows.Forms.Label lblValorMaio;
        private System.Windows.Forms.Label lblMaio;
        private System.Windows.Forms.Label lblValorAbril;
        private System.Windows.Forms.Label lblAbril;
        private System.Windows.Forms.Label lblValorJaneiro;
        private System.Windows.Forms.Label lblValorFevereiro;
        private System.Windows.Forms.Label lblValorMarco;
        private System.Windows.Forms.Label lblMarco;
        private System.Windows.Forms.Label lblFevereiro;
        private System.Windows.Forms.Label lblJaneiro;
        private System.Windows.Forms.Label lblValorTotalGasto;
        private System.Windows.Forms.Label lblTotalGasto;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ComboAuto cbBen;
        private System.Windows.Forms.Label lblBen;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDdV;
        private System.Windows.Forms.DateTimePicker dtpDdV;
        private System.Windows.Forms.DateTimePicker dtpDdP;
        private System.Windows.Forms.Label lblDdP;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.PictureBox pbConfirmar;
    }
}