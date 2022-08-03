using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Producao.PosEnvase
{
    public partial class FrmPosEnvase : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmPosEnvase()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Producao\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoRoxoProducao.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoRoxoProducaoMouse.png");
        }


        //CONFIGURACOES DAS LISTVIEW
        private void listOrdEn_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listPosOrd.Items.Count; i++)
            {
                listPosOrd.ItemSelectionChanged -= listOrdEn_ItemSelectionChanged;
                listPosOrd.ItemCheck -= listOrdEn_ItemCheck;
                listPosOrd.Items[i].Selected = listPosOrd.Items[i].Checked;
                listPosOrd.ItemSelectionChanged += listOrdEn_ItemSelectionChanged;
                listPosOrd.ItemCheck += listOrdEn_ItemCheck;
            }
        }
        private void listOrdEn_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listPosOrd.Items.Count; i++)
            {
                listPosOrd.ItemChecked -= listOrdEn_ItemChecked;
                listPosOrd.ItemCheck -= listOrdEn_ItemCheck;
                listPosOrd.Items[i].Checked = listPosOrd.Items[i].Selected;
                listPosOrd.ItemChecked += listOrdEn_ItemChecked;
                listPosOrd.ItemCheck += listOrdEn_ItemCheck;
            }
        }
        private void listOrdEn_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listPosOrd.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listPosOrd.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listPosOrd.Items[e.Index]) e.NewValue = CheckState.Checked;
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
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }


        //CONFIGURACAO DAS CAIXAS DE TEXTO NUMERICAS
        private void CaixasNumericas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pbAdicionar_MouseEnter(object sender, EventArgs e)
        {
            pbAdicionar.Image = imagem_mouse;
            lblAdicionar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbAdicionar_MouseLeave(object sender, EventArgs e)
        {
            pbAdicionar.Image = imagem_normal;
            lblAdicionar.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbEditar_MouseEnter(object sender, EventArgs e)
        {
            pbEditar.Image = imagem_mouse;
            lblEditar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbEditar_MouseLeave(object sender, EventArgs e)
        {
            pbEditar.Image = imagem_normal;
            lblEditar.BackColor = Color.FromArgb(235, 239, 243);
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
