using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.CadastroClientes
{
    public partial class FrmCadastroClientes : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;

        public FrmCadastroClientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Cadastros\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAzulCadastros.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAzulCadastrosMouse.png");
        }


        //CAIXAS DE TEXTO NUMERICAS
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //POSICOES DE CURSOR
        private void mtxtCEP_Click(object sender, EventArgs e)
        {
            mtxtCEP.SelectionStart = 0;
        }
        private void mtxtCelular_Click(object sender, EventArgs e)
        {
            mtxtCelular.SelectionStart = 0;
        }
        private void mtxtFone_Click(object sender, EventArgs e)
        {
            mtxtFone.SelectionStart = 0;
        }
        private void mtxtCelular2_Click(object sender, EventArgs e)
        {
            mtxtCelular2.SelectionStart = 0;
        }
        private void mtxtFixo2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtFixo2.SelectionStart = 0;
        }
        private void mtxtFixo3_Click(object sender, EventArgs e)
        {
            mtxtFixo3.SelectionStart = 0;

        }
        private void mtxtMovel3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtMovel3.SelectionStart = 0;
        }
        
        //BOTOES
        private void btLimpar_Click(object sender, EventArgs e)
        {
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
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
            };

            func(Controls);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtRazao.Text)) && (!string.IsNullOrEmpty(txtLogradouro.Text))
                && (!string.IsNullOrEmpty(txtBairro.Text)) && (!string.IsNullOrEmpty(txtCidade.Text)) &&
                (!string.IsNullOrEmpty(txtNumero.Text)) && (!string.IsNullOrEmpty(txtComp.Text)) &&
                (!string.IsNullOrEmpty(cbUF.Text)) && (!string.IsNullOrEmpty(mtxtCEP.Text)))
            {
                lblRazao.Text = "Razão Social:";
                lblRazao.ForeColor = Color.Black;

                lblLogradouro.Text = "Logradouro:";
                lblLogradouro.ForeColor = Color.Black;

                lblBairroVila.Text = "Bairro/Vila:";
                lblBairroVila.ForeColor = Color.Black;

                lblCidade.Text = "Cidade:";
                lblCidade.ForeColor = Color.Black;

                lblNumero.Text = "Número:";
                lblNumero.ForeColor = Color.Black;
                
                lblUF.Text = "UF:";
                lblUF.ForeColor = Color.Black;

                lblCEP.Text = "CEP:";
                lblCEP.ForeColor = Color.Black;

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
                    foreach (Control control in controls)
                        if (control is MaskedTextBox)
                            (control as MaskedTextBox).Clear();
                        else
                            func(control.Controls);
                    foreach (Control control in controls)
                        if (control is CheckBox)
                            (control as CheckBox).Checked = false;
                };

                func(Controls);

                //LABEL SALVO, CODIGO DE SALVAMENTO ACIMA
                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
            }
            else
            {
                //RAZAO
                if (string.IsNullOrEmpty(txtRazao.Text))
                {
                    lblRazao.Text = "Razão Social*:";
                    lblRazao.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblRazao.Text = "Razão Social:";
                    lblRazao.ForeColor = Color.Black;
                }

                //LOGRADOURO
                if (string.IsNullOrEmpty(txtLogradouro.Text))
                {
                    lblLogradouro.Text = "Logradouro*:";
                    lblLogradouro.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblLogradouro.Text = "Logradouro:";
                    lblLogradouro.ForeColor = Color.Black;
                }

                //BAIRO/VILA
                if (string.IsNullOrEmpty(txtBairro.Text))
                {
                    lblBairroVila.Text = "Bairro/Vila*:";
                    lblBairroVila.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblBairroVila.Text = "Bairro/Vila:";
                    lblBairroVila.ForeColor = Color.Black;
                }

                //CIDADE
                if (string.IsNullOrEmpty(txtCidade.Text))
                {
                    lblCidade.Text = "Cidade*:";
                    lblCidade.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblCidade.Text = "Cidade:";
                    lblCidade.ForeColor = Color.Black;
                }

                //NUMERO
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    lblNumero.Text = "Numero*:";
                    lblNumero.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblNumero.Text = "Número:";
                    lblNumero.ForeColor = Color.Black;
                }
                
                //UF
                if (string.IsNullOrEmpty(cbUF.Text))
                {
                    lblUF.Text = "UF*:";
                    lblUF.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblUF.Text = "UF:";
                    lblUF.ForeColor = Color.Black;
                }

                //CEP
                if (!mtxtCEP.MaskCompleted)
                {
                    lblCEP.Text = "CEP*:";
                    lblCEP.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblCEP.Text = "CEP:";
                    lblCEP.ForeColor = Color.Black;
                }
                MessageBox.Show("Por favor, preencha todos os dados destacados.", "Erro", MessageBoxButtons.OK);
            }
            return;

            
        }

        //CONFIGURACOES DE TELEFONES
        private void ckbFixo1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbFixo1.Checked)
            {
                ckbFixo1.Visible = false;
                ckbMovel1.Visible = false;

                mtxtFone.Visible = true;
            }
            else
            {
                ckbFixo1.Visible = true;
                ckbMovel1.Visible = true;

                mtxtFone.Visible = false;
            }
        }
        private void ckbMovel1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMovel1.Checked)
            {
                ckbMovel1.Visible = false;
                ckbFixo1.Visible = false;

                mtxtCelular.Visible = true;
            }
            else
            {
                ckbMovel1.Visible = true;
                ckbFixo1.Visible = true;

                mtxtCelular.Visible = false;
            }
        }
        private void ckbFixo2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFixo2.Checked)
            {
                ckbFixo2.Visible = false;
                ckbMovel2.Visible = false;

                mtxtFixo2.Visible = true;
            }
            else
            {
                ckbFixo2.Visible = true;
                ckbMovel2.Visible = true;

                mtxtFixo2.Visible = false;
            }
        }
        private void ckbMovel2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMovel2.Checked)
            {
                ckbMovel2.Visible = false;
                ckbFixo2.Visible = false;

                mtxtCelular2.Visible = true;
            }
            else
            {
                ckbMovel2.Visible = true;
                ckbFixo2.Visible = true;

                mtxtCelular2.Visible = false;
            }
        }
        private void ckbFixo3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFixo3.Checked)
            {
                ckbFixo3.Visible = false;
                ckbMovel3.Visible = false;

                mtxtFixo3.Visible = true;
            }
            else
            {
                ckbFixo3.Visible = true;
                ckbMovel3.Visible = true;

                mtxtFixo3.Visible = false;
            }
        }
        private void ckbMovel3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMovel3.Checked)
            {
                ckbMovel3.Visible = false;
                ckbFixo3.Visible = false;

                mtxtMovel3.Visible = true;
            }
            else
            {
                ckbMovel3.Visible = true;
                ckbFixo3.Visible = true;

                mtxtMovel3.Visible = false;
            }
        }
        private void mtxtFixo2_Click(object sender, EventArgs e)
        {
            StartPosition = 0;
        }

        //BOTOES MINIMIZAR E FECHAR
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btX_Click(object sender, EventArgs e)
        {
            Close();
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

        //APARENCIA BOTOES
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

        private void pbLimparTela_MouseEnter(object sender, EventArgs e)
        {
            pbLimparTela.Image = imagem_mouse;
            lblLimparTela.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbLimparTela_MouseLeave(object sender, EventArgs e)
        {
            pbLimparTela.Image = imagem_normal;
            lblLimparTela.BackColor = Color.FromArgb(235, 239, 243);
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

    }
}
