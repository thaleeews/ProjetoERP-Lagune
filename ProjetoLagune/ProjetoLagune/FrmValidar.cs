using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLagune
{
    public partial class FrmValidar : Form
    {
        string pasta_botoes = "";
        string pasta_imagens = "";
        Image imagem_normal;
        Image imagem_mouse;
        Image img1;
        Image img2;
        Image img3;
        Image img4;

        public FrmValidar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Botoes Planos\";
            pasta_imagens = Application.StartupPath + @"\Imagens\";
            imagem_normal = Image.FromFile(pasta_botoes + "botaoplanologin.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "botaoplanologinmouse.png");
            img1 = Image.FromFile(pasta_imagens + "IMG_20181210_155330.jpg");
            img2 = Image.FromFile(pasta_imagens + "IMG_20181210_155355.jpg");
            img3 = Image.FromFile(pasta_imagens + "IMG_20181210_155429.jpg");
            img4 = Image.FromFile(pasta_imagens + "IMG_20181210_155522.jpg");

        }
        public static string SetValueForText1 = "";




        
        //BOTAO
        private void btValidar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsuario.Text))
            {
                if (txtSenha.Text == "admin")
                {
                    SetValueForText1 = txtUsuario.Text;
                    FrmPrincipal pri = new FrmPrincipal();
                    pri.Show();
                    this.Hide();
                    
                    
                }
                else
                {
                    MessageBox.Show("Senha Incorreta.", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Digite o Nome de Usuário.", "Erro", MessageBoxButtons.OK);
            }
        }


        //BOTOES MINIMIZAR E FECHAR
        private void btXV_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //PRESSIONAR O BOTAO E ENTRAR
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (txtSenha.Text == "admin")
                    {
                        SetValueForText1 = txtUsuario.Text;
                        FrmPrincipal pri = new FrmPrincipal();
                        pri.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta.");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o Nome de Usuário.");
                }
            }
                
        }

        private void cbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (txtSenha.Text == "admin")
                    {
                        SetValueForText1 = txtUsuario.Text;
                        FrmPrincipal pri = new FrmPrincipal();
                        pri.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta.");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o Nome de Usuário.");
                }
            }
        }

        private async void FrmValidar_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblUsuario;
            bool a = true;
            while (a)
            {
                pbImagem.Image = img1;
                await Task.Delay(2000);
                pbImagem.Image = img2;
                await Task.Delay(2000);
                pbImagem.Image = img3;
                await Task.Delay(2000);
                pbImagem.Image = img4;
                await Task.Delay(2000);
            }
        }


        //APARENCIA DO BOTAO
        private void pbEntrar_MouseEnter(object sender, EventArgs e)
        {
            pbEntrar.Image = imagem_mouse;
            lblEntrar.BackColor = Color.FromArgb(27, 188, 155);
            lblEntrar.ForeColor = Color.White;
        }
        private void pbEntrar_MouseLeave(object sender, EventArgs e)
        {
            pbEntrar.Image = imagem_normal;
            lblEntrar.BackColor = Color.FromArgb(235, 239, 243);
            lblEntrar.ForeColor = Color.FromArgb(27, 188, 155);
        }
    }
}
