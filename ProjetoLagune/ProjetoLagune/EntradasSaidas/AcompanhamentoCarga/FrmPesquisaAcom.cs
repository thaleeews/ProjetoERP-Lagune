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
    public partial class FrmPesquisaAcom : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmPesquisaAcom()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Entradas e Saidas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoEntradasESaidas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoEntradasESaidasMouse.png");
        }


        //CONFIGURACOES DO LISTVIEW
        private void listPesq_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listPesq.Items.Count; i++)
            {
                listPesq.ItemSelectionChanged -= listPesq_ItemSelectionChanged;
                listPesq.ItemCheck -= listPesq_ItemCheck;
                listPesq.Items[i].Selected = listPesq.Items[i].Checked;
                listPesq.ItemSelectionChanged += listPesq_ItemSelectionChanged;
                listPesq.ItemCheck += listPesq_ItemCheck;
            }
        }
        private void listPesq_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listPesq.Items.Count; i++)
            {
                listPesq.ItemChecked -= listPesq_ItemChecked;
                listPesq.ItemCheck -= listPesq_ItemCheck;
                listPesq.Items[i].Checked = listPesq.Items[i].Selected;
                listPesq.ItemChecked += listPesq_ItemChecked;
                listPesq.ItemCheck += listPesq_ItemCheck;
            }
        }
        private void listPesq_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listPesq.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listPesq.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listPesq.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //BOTOES
        private void btVoltarPesq_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSelecionarPesq_Click(object sender, EventArgs e)
        {
            
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

        private void pbSelecionar_MouseEnter(object sender, EventArgs e)
        {
            pbSelecionar.Image = imagem_mouse;
            lblSelecionar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbSelecionar_MouseLeave(object sender, EventArgs e)
        {
            pbSelecionar.Image = imagem_normal;
            lblSelecionar.BackColor = Color.FromArgb(235, 239, 243);
        }
    }
}
