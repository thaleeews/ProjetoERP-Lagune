namespace ProjetoLagune.Cadastros.CadastroProdutos
{
    partial class FrmEmbalagens
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpbValores.SuspendLayout();
            this.grpbNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Arial", 10F);
            this.btVoltar.Location = new System.Drawing.Point(733, 179);
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
            this.btExcluir.Location = new System.Drawing.Point(184, 179);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 25);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Arial", 10F);
            this.btAlterar.Location = new System.Drawing.Point(98, 179);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(80, 25);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 10F);
            this.btCadastrar.Location = new System.Drawing.Point(12, 179);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(80, 25);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // grpbValores
            // 
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
            this.grpbValores.Location = new System.Drawing.Point(12, 96);
            this.grpbValores.Name = "grpbValores";
            this.grpbValores.Size = new System.Drawing.Size(801, 76);
            this.grpbValores.TabIndex = 8;
            this.grpbValores.TabStop = false;
            this.grpbValores.Text = "Valores";
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
            this.txtICMS.Location = new System.Drawing.Point(147, 42);
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
            this.txtQuantidadeMinima.Location = new System.Drawing.Point(147, 13);
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
            this.grpbNome.Controls.Add(this.txtProduto);
            this.grpbNome.Controls.Add(this.lblProduto);
            this.grpbNome.Controls.Add(this.txtNome);
            this.grpbNome.Controls.Add(this.lblNome);
            this.grpbNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbNome.Location = new System.Drawing.Point(12, 12);
            this.grpbNome.Name = "grpbNome";
            this.grpbNome.Size = new System.Drawing.Size(801, 78);
            this.grpbNome.TabIndex = 7;
            this.grpbNome.TabStop = false;
            this.grpbNome.Text = "Nome";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtProduto.Location = new System.Drawing.Point(147, 42);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(648, 23);
            this.txtProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 10F);
            this.lblProduto.Location = new System.Drawing.Point(6, 45);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 16);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNome.Location = new System.Drawing.Point(147, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(648, 23);
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
            // FrmEmbalagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 211);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.grpbValores);
            this.Controls.Add(this.grpbNome);
            this.Name = "FrmEmbalagens";
            this.Text = "Cadastro de Embalagem";
            this.grpbValores.ResumeLayout(false);
            this.grpbValores.PerformLayout();
            this.grpbNome.ResumeLayout(false);
            this.grpbNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.GroupBox grpbValores;
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
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}