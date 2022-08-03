using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Financas.Estimativas
{
    public partial class FrmEstimativas : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;
        Image imagem_mouse2;
        Image imagem_normal2;



        public FrmEstimativas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Financas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoVerdeFinancas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoVerdeFinancasMouse.png");
            imagem_mouse2 = Image.FromFile(pasta_botoes + "BotaoVerdeFinancasMouse2.png");
            imagem_normal2 = Image.FromFile(pasta_botoes + "BotaoVerdeFinancas2.png");
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

        private void btImprimir_Click(object sender, EventArgs e)
        {

        }

        //APARENCIA DOS BOTOES
        private void pbImprimir_MouseEnter(object sender, EventArgs e)
        {
            pbImprimir.Image = imagem_mouse;
            lblImprimir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbImprimir_MouseLeave(object sender, EventArgs e)
        {
            pbImprimir.Image = imagem_normal;
            lblImprimir.BackColor = Color.FromArgb(235, 239, 243);
        }

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

        private void pbDetalhes1_MouseEnter(object sender, EventArgs e)
        {
            pbDetalhes1.Image = imagem_mouse2;
            lblDetalhes1.BackColor = Color.FromArgb(200, 210, 221);
        }
        private void pbDetalhes1_MouseLeave(object sender, EventArgs e)
        {
            pbDetalhes1.Image = imagem_normal2;
            lblDetalhes1.BackColor = Color.FromArgb(216, 223, 231);
        }

        private void pbDetalhes2_MouseEnter(object sender, EventArgs e)
        {
            pbDetalhes2.Image = imagem_mouse2;
            lblDetalhes2.BackColor = Color.FromArgb(200, 210, 221);
        }
        private void pbDetalhes2_MouseLeave(object sender, EventArgs e)
        {
            pbDetalhes2.Image = imagem_normal2;
            lblDetalhes2.BackColor = Color.FromArgb(216, 223, 231);
        }

        private void pbDetalhes3_MouseEnter(object sender, EventArgs e)
        {
            pbDetalhes3.Image = imagem_mouse2;
            lblDetalhes3.BackColor = Color.FromArgb(200, 210, 221);
        }
        private void pbDetalhes3_MouseLeave(object sender, EventArgs e)
        {
            pbDetalhes3.Image = imagem_normal2;
            lblDetalhes3.BackColor = Color.FromArgb(216, 223, 231);
        }
    }
}
