namespace ProjetoLagune
{
    partial class FrmValidar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidar));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pbEntrar = new System.Windows.Forms.PictureBox();
            this.lbltxtSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.btXV = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Simplifica", 40F);
            this.lblUsuario.Location = new System.Drawing.Point(561, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(141, 59);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Simplifica", 40F);
            this.lblSenha.Location = new System.Drawing.Point(564, 236);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(121, 59);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(557, 300);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(145, 28);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // pbEntrar
            // 
            this.pbEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEntrar.Image = ((System.Drawing.Image)(resources.GetObject("pbEntrar.Image")));
            this.pbEntrar.Location = new System.Drawing.Point(539, 384);
            this.pbEntrar.Name = "pbEntrar";
            this.pbEntrar.Size = new System.Drawing.Size(173, 69);
            this.pbEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEntrar.TabIndex = 15;
            this.pbEntrar.TabStop = false;
            this.pbEntrar.Click += new System.EventHandler(this.btValidar_Click);
            this.pbEntrar.MouseEnter += new System.EventHandler(this.pbEntrar_MouseEnter);
            this.pbEntrar.MouseLeave += new System.EventHandler(this.pbEntrar_MouseLeave);
            // 
            // lbltxtSenha
            // 
            this.lbltxtSenha.BackColor = System.Drawing.Color.Gray;
            this.lbltxtSenha.Location = new System.Drawing.Point(557, 328);
            this.lbltxtSenha.Name = "lbltxtSenha";
            this.lbltxtSenha.Size = new System.Drawing.Size(145, 2);
            this.lbltxtSenha.TabIndex = 19;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(557, 136);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 28);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(557, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 2);
            this.label3.TabIndex = 21;
            // 
            // pbCor
            // 
            this.pbCor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCor.Image = ((System.Drawing.Image)(resources.GetObject("pbCor.Image")));
            this.pbCor.Location = new System.Drawing.Point(0, 0);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(5, 518);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 23;
            this.pbCor.TabStop = false;
            // 
            // btXV
            // 
            this.btXV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btXV.FlatAppearance.BorderSize = 0;
            this.btXV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXV.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXV.Location = new System.Drawing.Point(689, 0);
            this.btXV.Name = "btXV";
            this.btXV.Size = new System.Drawing.Size(25, 25);
            this.btXV.TabIndex = 8;
            this.btXV.Text = "X";
            this.btXV.UseVisualStyleBackColor = false;
            this.btXV.Click += new System.EventHandler(this.btXV_Click);
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Font = new System.Drawing.Font("Kano regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(664, 0);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(25, 25);
            this.btMin.TabIndex = 7;
            this.btMin.Text = "-";
            this.btMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.lblEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntrar.Font = new System.Drawing.Font("BigNoodleTitling", 22F);
            this.lblEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.lblEntrar.Location = new System.Drawing.Point(580, 402);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(92, 33);
            this.lblEntrar.TabIndex = 24;
            this.lblEntrar.Text = "Entrar >";
            this.lblEntrar.Click += new System.EventHandler(this.btValidar_Click);
            this.lblEntrar.MouseEnter += new System.EventHandler(this.pbEntrar_MouseEnter);
            this.lblEntrar.MouseLeave += new System.EventHandler(this.pbEntrar_MouseLeave);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(5, 0);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(532, 518);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 25;
            this.pbImagem.TabStop = false;
            // 
            // FrmValidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(714, 518);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.btXV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbltxtSenha);
            this.Controls.Add(this.lblSenha);
            this.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmValidar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidar";
            this.Load += new System.EventHandler(this.FrmValidar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pbEntrar;
        private System.Windows.Forms.Label lbltxtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Button btXV;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}