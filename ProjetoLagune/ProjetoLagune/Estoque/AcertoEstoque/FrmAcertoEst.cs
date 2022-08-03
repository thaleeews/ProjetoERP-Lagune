using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Estoque
{
    public partial class FrmAcertoEst : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmAcertoEst()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Estoque\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoLaranjaEstoque.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoLaranjaEstoqueMouse.png");
        }


        //CONFIGURACOES DA LISTVIEW
        private void listAcerto_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listAcerto.Items.Count; i++)
            {
                listAcerto.ItemSelectionChanged -= listAcerto_ItemSelectionChanged;
                listAcerto.ItemCheck -= listAcerto_ItemCheck;
                listAcerto.Items[i].Selected = listAcerto.Items[i].Checked;
                listAcerto.ItemSelectionChanged += listAcerto_ItemSelectionChanged;
                listAcerto.ItemCheck += listAcerto_ItemCheck;
            }
        }
        private void listAcerto_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listAcerto.Items.Count; i++)
            {
                listAcerto.ItemChecked -= listAcerto_ItemChecked;
                listAcerto.ItemCheck -= listAcerto_ItemCheck;
                listAcerto.Items[i].Checked = listAcerto.Items[i].Selected;
                listAcerto.ItemChecked += listAcerto_ItemChecked;
                listAcerto.ItemCheck += listAcerto_ItemCheck;
            }
        }
        private void listAcerto_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listAcerto.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listAcerto.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listAcerto.Items[e.Index]) e.NewValue = CheckState.Checked;
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
            listAcerto.Items.Clear();
            
        }
        private void btConcluir_Click(object sender, EventArgs e)
        {

        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            lblLote.Enabled = true;
            txtLote.Enabled = true;

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btSalvar_Click(object sender, EventArgs e)
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


        //CHECKS
        private void rdMateria_CheckedChanged(object sender, EventArgs e)
        {
            if(rdEmbalagem.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdMateria.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdProduto.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
        }

        private void rdProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmbalagem.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdMateria.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdProduto.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
        }

        private void rdEmbalagem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmbalagem.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdMateria.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
            }
            if (rdProduto.Checked)
            {
                cbArmazem.Enabled = true;
                cbProduto.Enabled = true;
                grpEdicao.Enabled = true;
                listAcerto.Enabled = true;
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

        
    }
}
