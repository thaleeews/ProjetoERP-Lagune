using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.EntradasSaidas.AcompanhamentoCarga
{
    public partial class FrmAcompanha : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmAcompanha()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Entradas e Saidas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoEntradasESaidas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoEntradasESaidasMouse.png");
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaAcom p = new FrmPesquisaAcom();
            p.ShowDialog();
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
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;
        }


        //CONFIGURACOES DAS CIAXAS DE TEXTO
        private void cbNumNota_TextChanged(object sender, EventArgs e)
        {
            txtNomeCliente.Enabled = true;
            txtTransp.Enabled = true;
            txtValorF.Enabled = true;
            mtxtDataE.Enabled = true;

        }
        private void txtValorF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void mtxtDataE_Click(object sender, EventArgs e)
        {
            mtxtDataE.SelectionStart = 0;
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
