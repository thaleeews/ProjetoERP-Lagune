using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Financas.ControleCheques
{
    public partial class FrmControleCheques : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmControleCheques()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Financas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoVerdeFinancas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoVerdeFinancasMouse.png");
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

        private void btBaixar_Click(object sender, EventArgs e)
        {

        }


        //CONFIGURACOES DAS LISTVIEW
        private void listCheques_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listCheques.Items.Count; i++)
            {
                listCheques.ItemSelectionChanged -= listCheques_ItemSelectionChanged;
                listCheques.ItemCheck -= listCheques_ItemCheck;
                listCheques.Items[i].Selected = listCheques.Items[i].Checked;
                listCheques.ItemSelectionChanged += listCheques_ItemSelectionChanged;
                listCheques.ItemCheck += listCheques_ItemCheck;
            }
        }
        private void listCheques_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listCheques.Items.Count; i++)
            {
                listCheques.ItemChecked -= listCheques_ItemChecked;
                listCheques.ItemCheck -= listCheques_ItemCheck;
                listCheques.Items[i].Checked = listCheques.Items[i].Selected;
                listCheques.ItemChecked += listCheques_ItemChecked;
                listCheques.ItemCheck += listCheques_ItemCheck;
            }
        }
        private void listCheques_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listCheques.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listCheques.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listCheques.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //CONFIGURACOES DAS CAIXAS DE TEXTO NUMERICAS E MASKEDS
        private void txtNumericas_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNumericasSemVirg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void mtxtVencimento_Click(object sender, EventArgs e)
        {
            mtxtVencimento.SelectionStart = 0;
        }
        private void mtxtEntrada_Click(object sender, EventArgs e)
        {
            mtxtEntrada.SelectionStart = 0;
        }
        private void mtxtSaida_Click(object sender, EventArgs e)
        {
            mtxtSaida.SelectionStart = 0;
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

        private void pbSalvar_MouseEnter(object sender, EventArgs e)
        {
            pbSalvar.Image = imagem_mouse;
            lblSalvar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbSalvar_MouseLeave(object sender, EventArgs e)
        {
            pbSalvar.Image = imagem_normal;
            lblSalvar.BackColor = Color.White;
        }

        private void pbExcluir_MouseEnter(object sender, EventArgs e)
        {
            pbExcluir.Image = imagem_mouse;
            lblExcluir.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbExcluir_MouseLeave(object sender, EventArgs e)
        {
            pbExcluir.Image = imagem_normal;
            lblExcluir.BackColor = Color.White;
        }

        private void pbEditar_MouseEnter(object sender, EventArgs e)
        {
            pbEditar.Image = imagem_mouse;
            lblEditar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbEditar_MouseLeave(object sender, EventArgs e)
        {
            pbEditar.Image = imagem_normal;
            lblEditar.BackColor = Color.White;
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

        
    }
}
