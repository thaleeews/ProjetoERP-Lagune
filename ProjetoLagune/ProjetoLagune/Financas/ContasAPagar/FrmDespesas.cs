using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Financas
{
    public partial class FrmDespesas : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmDespesas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Financas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoVerdeFinancas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoVerdeFinancasMouse.png");
        }


        //CONFIGURACOES DAS LISTVIEWS
        private void listAPagar_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listAPagar.Items.Count; i++)
            {
                listAPagar.ItemSelectionChanged -= listAPagar_ItemSelectionChanged;
                listAPagar.ItemCheck -= listAPagar_ItemCheck;
                listAPagar.Items[i].Selected = listAPagar.Items[i].Checked;
                listAPagar.ItemSelectionChanged += listAPagar_ItemSelectionChanged;
                listAPagar.ItemCheck += listAPagar_ItemCheck;
            }
        }
        private void listAPagar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listAPagar.Items.Count; i++)
            {
                listAPagar.ItemChecked -= listAPagar_ItemChecked;
                listAPagar.ItemCheck -= listAPagar_ItemCheck;
                listAPagar.Items[i].Checked = listAPagar.Items[i].Selected;
                listAPagar.ItemChecked += listAPagar_ItemChecked;
                listAPagar.ItemCheck += listAPagar_ItemCheck;
            }
        }
        private void listAPagar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listAPagar.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listAPagar.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listAPagar.Items[e.Index]) e.NewValue = CheckState.Checked;
        }

        private void listLanca_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listLanca.Items.Count; i++)
            {
                listLanca.ItemSelectionChanged -= listLanca_ItemSelectionChanged;
                listLanca.ItemCheck -= listLanca_ItemCheck;
                listLanca.Items[i].Selected = listLanca.Items[i].Checked;
                listLanca.ItemSelectionChanged += listLanca_ItemSelectionChanged;
                listLanca.ItemCheck += listLanca_ItemCheck;
            }
        }
        private void listLanca_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listLanca.Items.Count; i++)
            {
                listLanca.ItemChecked -= listLanca_ItemChecked;
                listLanca.ItemCheck -= listLanca_ItemCheck;
                listLanca.Items[i].Checked = listLanca.Items[i].Selected;
                listLanca.ItemChecked += listLanca_ItemChecked;
                listLanca.ItemCheck += listLanca_ItemCheck;
            }
        }
        private void listLanca_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listLanca.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listLanca.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listLanca.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //CONFIGURACAO DAS CAIXAS DE TEXTO NUMERICAS
        private void TXTNUMERICA_KeyPress(object sender, KeyPressEventArgs e)
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


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btLancar_Click(object sender, EventArgs e)
        {

        }

        private void btCorrigir_Click(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btBaixar_Click(object sender, EventArgs e)
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

        private void pbLancar_MouseEnter(object sender, EventArgs e)
        {
            pbLancar.Image = imagem_mouse;
            lblLancar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbLancar_MouseLeave(object sender, EventArgs e)
        {
            pbLancar.Image = imagem_normal;
            lblLancar.BackColor = Color.White;
        }

        private void pbAdicionar_MouseEnter(object sender, EventArgs e)
        {
            pbAdicionar.Image = imagem_mouse;
            lblAdicionar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbAdicionar_MouseLeave(object sender, EventArgs e)
        {
            pbAdicionar.Image = imagem_normal;
            lblAdicionar.BackColor = Color.White;
        }

        private void pbRemover_MouseEnter(object sender, EventArgs e)
        {
            pbRemover.Image = imagem_mouse;
            lblRemover.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbRemover_MouseLeave(object sender, EventArgs e)
        {
            pbRemover.Image = imagem_normal;
            lblRemover.BackColor = Color.White;
        }

        private void pbCorrigir_MouseEnter(object sender, EventArgs e)
        {
            pbCorrigir.Image = imagem_mouse;
            lblCorrigir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbCorrigir_MouseLeave(object sender, EventArgs e)
        {
            pbCorrigir.Image = imagem_normal;
            lblCorrigir.BackColor = Color.White;
        }

        private void pbConfirmar_MouseEnter(object sender, EventArgs e)
        {
            pbConfirmar.Image = imagem_mouse;
            lblConfirmar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbConfirmar_MouseLeave(object sender, EventArgs e)
        {
            pbConfirmar.Image = imagem_normal;
            lblConfirmar.BackColor = Color.White;
        }

        private void pbBaixar_MouseEnter(object sender, EventArgs e)
        {
            pbBaixar.Image = imagem_mouse;
            lblBaixar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbBaixar_MouseLeave(object sender, EventArgs e)
        {
            pbBaixar.Image = imagem_normal;
            lblBaixar.BackColor = Color.White;
        }

        private void pbImprimir_MouseEnter(object sender, EventArgs e)
        {
            pbImprimir.Image = imagem_mouse;
            lblImprimir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbImprimir_MouseLeave(object sender, EventArgs e)
        {
            pbImprimir.Image = imagem_normal;
            lblImprimir.BackColor = Color.White;
        }
    }
}
