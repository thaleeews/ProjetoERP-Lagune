using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Cadastros.CadastroTransp
{
    public partial class FrmTransp : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmTransp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Cadastros\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAzulCadastros.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAzulCadastrosMouse.png");
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            };

            func(Controls);
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            //SE TODOS OS TEXT ESTAO OK
            if ((!string.IsNullOrEmpty(txtNome.Text)) && (!string.IsNullOrEmpty(txtLogradouroForn.Text)) && (!string.IsNullOrEmpty(txtBairroForn.Text)) &&
                (!string.IsNullOrEmpty(txtNumeroForn.Text)) &&
                (!string.IsNullOrEmpty(txtCidadeForn.Text)) && (mtxtCEPForn.MaskCompleted) &&
                (!string.IsNullOrEmpty(txtEstadoForn.Text)) && (!string.IsNullOrEmpty(cbUFForn.Text)) &&
                (mtxtCNPJ.MaskCompleted))
            {
                lblNome.Text = "Nome:";
                lblNome.ForeColor = Color.Black;



                lblBairroForn.Text = "Bairro/Vila:";
                lblBairroForn.ForeColor = Color.Black;

                lblLogradouroForn.Text = "Logradouro:";
                lblLogradouroForn.ForeColor = Color.Black;

                lblNumeroForn.Text = "Número:";
                lblNumeroForn.ForeColor = Color.Black;



                lblCidadeForn.Text = "Cidade:";
                lblCidadeForn.ForeColor = Color.Black;

                lblCEPForn.Text = "CEP:";
                lblCEPForn.ForeColor = Color.Black;

                lblEstadoForn.Text = "Estado:";
                lblEstadoForn.ForeColor = Color.Black;

                lblUFForn.Text = "UF:";
                lblUFForn.ForeColor = Color.Black;

                lblCNPJ.Text = "CNPJ:";
                lblCNPJ.ForeColor = Color.Black;

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
                //========================================================================================
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    lblNome.Text = "Nome*:";
                    lblNome.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblNome.Text = "Nome:";
                    lblNome.ForeColor = Color.Black;
                }

                //========================================================================================


                //========================================================================================
                if (string.IsNullOrEmpty(txtBairroForn.Text))
                {
                    lblBairroForn.Text = "Bairro/Vila*:";
                    lblBairroForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblBairroForn.Text = "Bairro/Vila:";
                    lblBairroForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (string.IsNullOrEmpty(txtLogradouroForn.Text))
                {
                    lblLogradouroForn.Text = "Logradouro*:";
                    lblLogradouroForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblLogradouroForn.Text = "Logradouro:";
                    lblLogradouroForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (string.IsNullOrEmpty(txtNumeroForn.Text))
                {
                    lblNumeroForn.Text = "Número*:";
                    lblNumeroForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblNumeroForn.Text = "Número:";
                    lblNumeroForn.ForeColor = Color.Black;
                }

                //========================================================================================


                //========================================================================================
                if (string.IsNullOrEmpty(txtCidadeForn.Text))
                {
                    lblCidadeForn.Text = "Cidade*:";
                    lblCidadeForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblCidadeForn.Text = "Cidade:";
                    lblCidadeForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (!mtxtCEPForn.MaskCompleted)
                {
                    lblCEPForn.Text = "CEP*:";
                    lblCEPForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblCEPForn.Text = "CEP:";
                    lblCEPForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (string.IsNullOrEmpty(txtEstadoForn.Text))
                {
                    lblEstadoForn.Text = "Estado*:";
                    lblEstadoForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblEstadoForn.Text = "Estado:";
                    lblEstadoForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (string.IsNullOrEmpty(cbUFForn.Text))
                {
                    lblUFForn.Text = "UF*:";
                    lblUFForn.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblUFForn.Text = "UF:";
                    lblUFForn.ForeColor = Color.Black;
                }

                //========================================================================================
                if (!mtxtCNPJ.MaskCompleted)
                {
                    lblCNPJ.Text = "CNPJ*:";
                    lblCNPJ.ForeColor = Color.FromArgb(255, 121, 121);
                }
                else
                {
                    lblCNPJ.Text = "CNPJ:";
                    lblCNPJ.ForeColor = Color.Black;
                }
                MessageBox.Show("Por favor, preencha todos os dados destacados.", "Erro", MessageBoxButtons.OK);
            }
        }


        //BOTOES DE MINIMIZAR E FECHAR
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
    }
}
