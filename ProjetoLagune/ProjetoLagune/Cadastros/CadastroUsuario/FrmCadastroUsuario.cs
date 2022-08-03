using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Cadastros.CadastroUsuario
{
    public partial class FrmCadastroUsuario : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;

        
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Cadastros\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAzulCadastros.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAzulCadastrosMouse.png");
            

        }

        //BOTOES MINIMIZAR E FECHAR
        private void btX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(cbNomeUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                && (!string.IsNullOrEmpty(txtRepetirSenha.Text)) && (!string.IsNullOrEmpty(cbSetor.Text)))
            {
                lblUsuario.Text = "Usuário";
                lblUsuario.ForeColor = Color.Black;

                lblSenha.Text = "Senha";
                lblSenha.ForeColor = Color.Black;

                lblRepetirSenha.Text = "Repetir Senha";
                lblRepetirSenha.ForeColor = Color.Black;

                lblSetor.Text = "Setor";
                lblSetor.ForeColor = Color.Black;

                //CODIGO AQUI

                //LIMPAR TELA
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                    foreach (Control control in controls)
                        if (control is ComboBox)
                            (control as ComboBox).Text = "";
                        else
                            func(control.Controls);
                };

                func(Controls);

                //LABEL SALVO
                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
            }
            else
            {
                if(string.IsNullOrEmpty(cbNomeUsuario.Text))
                {
                    lblUsuario.Text = "Usuário*";
                    lblUsuario.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblUsuario.Text = "Usuário";
                    lblUsuario.ForeColor = Color.Black;
                }


                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    lblSenha.Text = "Senha*";
                    lblSenha.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblSenha.Text = "Senha";
                    lblSenha.ForeColor = Color.Black;
                }


                if (string.IsNullOrEmpty(txtRepetirSenha.Text))
                {
                    lblRepetirSenha.Text = "Repetir Senha*";
                    lblRepetirSenha.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblRepetirSenha.Text = "Repetir Senha";
                    lblRepetirSenha.ForeColor = Color.Black;
                }


                if (string.IsNullOrEmpty(cbSetor.Text))
                {
                    lblSetor.Text = "Setor*";
                    lblSetor.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblSetor.Text = "Setor";
                    lblSetor.ForeColor = Color.Black;
                }
                MessageBox.Show("Por favor, preencha todos os dados destacados.", "Erro", MessageBoxButtons.OK);
            }
            return;
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
        }


        //APARENCIA DOS BOTOES
        private void pbVoltar_MouseEnter(object sender, EventArgs e)
        {
            pbVoltar.Image = imagem_mouse;
            lblVoltar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbVoltar_MouseLeave(object sender, EventArgs e)
        {
            pbVoltar.Image = imagem_normal;
            lblVoltar.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbSalvar_MouseEnter(object sender, EventArgs e)
        {
            pbSalvar.Image = imagem_mouse;
            lblSalvar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbSalvar_MouseLeave(object sender, EventArgs e)
        {
            pbSalvar.Image = imagem_normal;
            lblSalvar.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbExcluir_MouseEnter(object sender, EventArgs e)
        {
            pbExcluir.Image = imagem_mouse;
            lblExcluir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbExcluir_MouseLeave(object sender, EventArgs e)
        {
            pbExcluir.Image = imagem_normal;
            lblExcluir.BackColor = Color.FromArgb(235, 239, 243);
        }


        //LOAD FORMULARIO
        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            pbVoltar.Image = imagem_normal;
            this.ActiveControl = btMin;
        }


        //IDENTIFICACAO DE SENHA E BOTAO EXCLUIR
        private void txtRepetirSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetirSenha.Text != txtSenha.Text)
            {
                lblSenhasIncorretas.Text = "As Senhas Não São Iguais.";
            }
            else
            {
                lblSenhasIncorretas.Text = "";
            }
            
            if ((!string.IsNullOrEmpty(cbNomeUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                && (!string.IsNullOrEmpty(txtRepetirSenha.Text)) && (!string.IsNullOrEmpty(cbSetor.Text)))
            {
                lblExcluir.Enabled = true;
                pbExcluir.Enabled = true;
            }
            else
            {
                lblExcluir.Enabled = false;
                pbExcluir.Enabled = false;
            }
            return;
        }

        private void cbNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(cbNomeUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                && (!string.IsNullOrEmpty(txtRepetirSenha.Text)) && (!string.IsNullOrEmpty(cbSetor.Text)))
            {
                lblExcluir.Enabled = true;
                pbExcluir.Enabled = true;
            }
            else
            {
                lblExcluir.Enabled = false;
                pbExcluir.Enabled = false;
            }
            return;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRepetirSenha.Text))
            {
                if (txtRepetirSenha.Text != txtSenha.Text)
                {
                    lblSenhasIncorretas.Text = "As Senhas Não São Iguais.";
                }
                else
                {
                    lblSenhasIncorretas.Text = "";
                }
            }
            
            else
            {
                lblSenhasIncorretas.Text = "";
            }

            if ((!string.IsNullOrEmpty(cbNomeUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                && (!string.IsNullOrEmpty(txtRepetirSenha.Text)) && (!string.IsNullOrEmpty(cbSetor.Text)))
            {
                lblExcluir.Enabled = true;
                pbExcluir.Enabled = true;
            }
            else
            {
                lblExcluir.Enabled = false;
                pbExcluir.Enabled = false;
            }
            return;
        }

        private void cbSetor_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(cbNomeUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                && (!string.IsNullOrEmpty(txtRepetirSenha.Text)) && (!string.IsNullOrEmpty(cbSetor.Text)))
            {
                lblExcluir.Enabled = true;
                pbExcluir.Enabled = true;
            }
            else
            {
                lblExcluir.Enabled = false;
                pbExcluir.Enabled = false;
            }
            return;
        }
    }
}
