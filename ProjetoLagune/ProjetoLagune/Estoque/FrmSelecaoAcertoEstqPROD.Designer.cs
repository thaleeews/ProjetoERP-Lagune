namespace ProjetoLagune
{
    partial class FrmSelecaoAcertoEstqPROD
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
            this.rdbMateriaPrima = new System.Windows.Forms.RadioButton();
            this.grpbSelecione = new System.Windows.Forms.GroupBox();
            this.rdbProdutoAcabado = new System.Windows.Forms.RadioButton();
            this.rdbEmbalagem = new System.Windows.Forms.RadioButton();
            this.btContinuar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.grpbSelecione.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual o Tipo de Produto?";
            // 
            // rdbMateriaPrima
            // 
            this.rdbMateriaPrima.AutoSize = true;
            this.rdbMateriaPrima.Font = new System.Drawing.Font("Arial", 13F);
            this.rdbMateriaPrima.Location = new System.Drawing.Point(6, 33);
            this.rdbMateriaPrima.Name = "rdbMateriaPrima";
            this.rdbMateriaPrima.Size = new System.Drawing.Size(139, 25);
            this.rdbMateriaPrima.TabIndex = 1;
            this.rdbMateriaPrima.TabStop = true;
            this.rdbMateriaPrima.Text = "Matéria Prima";
            this.rdbMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // grpbSelecione
            // 
            this.grpbSelecione.Controls.Add(this.rdbProdutoAcabado);
            this.grpbSelecione.Controls.Add(this.rdbEmbalagem);
            this.grpbSelecione.Controls.Add(this.rdbMateriaPrima);
            this.grpbSelecione.Font = new System.Drawing.Font("Arial", 8.25F);
            this.grpbSelecione.Location = new System.Drawing.Point(39, 47);
            this.grpbSelecione.Name = "grpbSelecione";
            this.grpbSelecione.Size = new System.Drawing.Size(202, 175);
            this.grpbSelecione.TabIndex = 2;
            this.grpbSelecione.TabStop = false;
            this.grpbSelecione.Text = "Selecione";
            // 
            // rdbProdutoAcabado
            // 
            this.rdbProdutoAcabado.AutoSize = true;
            this.rdbProdutoAcabado.Font = new System.Drawing.Font("Arial", 13F);
            this.rdbProdutoAcabado.Location = new System.Drawing.Point(6, 129);
            this.rdbProdutoAcabado.Name = "rdbProdutoAcabado";
            this.rdbProdutoAcabado.Size = new System.Drawing.Size(165, 25);
            this.rdbProdutoAcabado.TabIndex = 3;
            this.rdbProdutoAcabado.TabStop = true;
            this.rdbProdutoAcabado.Text = "Produto Acabado";
            this.rdbProdutoAcabado.UseVisualStyleBackColor = true;
            // 
            // rdbEmbalagem
            // 
            this.rdbEmbalagem.AutoSize = true;
            this.rdbEmbalagem.Font = new System.Drawing.Font("Arial", 13F);
            this.rdbEmbalagem.Location = new System.Drawing.Point(6, 81);
            this.rdbEmbalagem.Name = "rdbEmbalagem";
            this.rdbEmbalagem.Size = new System.Drawing.Size(122, 25);
            this.rdbEmbalagem.TabIndex = 2;
            this.rdbEmbalagem.TabStop = true;
            this.rdbEmbalagem.Text = "Embalagem";
            this.rdbEmbalagem.UseVisualStyleBackColor = true;
            // 
            // btContinuar
            // 
            this.btContinuar.Font = new System.Drawing.Font("Arial", 9F);
            this.btContinuar.Location = new System.Drawing.Point(150, 246);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(91, 23);
            this.btContinuar.TabIndex = 3;
            this.btContinuar.Text = "Continuar >";
            this.btContinuar.UseVisualStyleBackColor = true;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Arial", 9F);
            this.btVoltar.Location = new System.Drawing.Point(39, 246);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(91, 23);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "< Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FrmSelecaoAcertoEstqPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.grpbSelecione);
            this.Controls.Add(this.label1);
            this.Name = "FrmSelecaoAcertoEstqPROD";
            this.Text = "FrmSelecaoAcertoEstqPROD";
            this.grpbSelecione.ResumeLayout(false);
            this.grpbSelecione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMateriaPrima;
        private System.Windows.Forms.GroupBox grpbSelecione;
        private System.Windows.Forms.RadioButton rdbProdutoAcabado;
        private System.Windows.Forms.RadioButton rdbEmbalagem;
        private System.Windows.Forms.Button btContinuar;
        private System.Windows.Forms.Button btVoltar;
    }
}