using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Compras.Pedidos
{
    public partial class FrmHistorico : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmHistorico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Compras\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAmareloCompras.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAmareloComprasMouse.png");
        }


        //CONFIGURACOES DO LISTVIEW
        private void listHist_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listHist.Items.Count; i++)
            {
                listHist.ItemSelectionChanged -= listHist_ItemSelectionChanged;
                listHist.ItemCheck -= listHist_ItemCheck;
                listHist.Items[i].Selected = listHist.Items[i].Checked;
                listHist.ItemSelectionChanged += listHist_ItemSelectionChanged;
                listHist.ItemCheck += listHist_ItemCheck;
            }
        }
        private void listHist_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listHist.Items.Count; i++)
            {
                listHist.ItemChecked -= listHist_ItemChecked;
                listHist.ItemCheck -= listHist_ItemCheck;
                listHist.Items[i].Checked = listHist.Items[i].Selected;
                listHist.ItemChecked += listHist_ItemChecked;
                listHist.ItemCheck += listHist_ItemCheck;
            }
        }
        private void listHist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listHist.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listHist.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listHist.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
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
