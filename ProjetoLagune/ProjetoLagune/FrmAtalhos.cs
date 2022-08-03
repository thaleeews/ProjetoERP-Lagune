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
    public partial class FrmAtalhos : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;
        FrmPrincipal Principal;
        public FrmAtalhos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Entradas e Saidas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoEntradasESaidas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoEntradasESaidasMouse.png");
            this.Principal = Principal;
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btConcluir_Click(object sender, EventArgs e)
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
        private void pbConcluir_MouseEnter(object sender, EventArgs e)
        {
            pbConcluir.Image = imagem_mouse;
            lblConcluir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbConcluir_MouseLeave(object sender, EventArgs e)
        {
            pbConcluir.Image = imagem_normal;
            lblConcluir.BackColor = Color.FromArgb(235, 239, 243);
        }
        public static string atalho1;
        public static string atalho2;
        public static string atalho3;
        public static string atalho4;


    }
}
