using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Estoque.Transferencia
{
    public partial class FrmAprovar : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;



        public FrmAprovar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Estoque\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoLaranjaEstoque.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoLaranjaEstoqueMouse.png");
        }


        //LOAD
        private void FrmAprovar_Load(object sender, EventArgs e)
        {
            //exibir lista de produtos nao aprovados
        }


        //CONFIGURACOES DA LISTVIEW
        private void listTransf_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listTransf.Items.Count; i++)
            {
                listTransf.ItemSelectionChanged -= listTransf_ItemSelectionChanged;
                listTransf.ItemCheck -= listTransf_ItemCheck;
                listTransf.Items[i].Selected = listTransf.Items[i].Checked;
                listTransf.ItemSelectionChanged += listTransf_ItemSelectionChanged;
                listTransf.ItemCheck += listTransf_ItemCheck;
            }
        }
        private void listTransf_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listTransf.Items.Count; i++)
            {
                listTransf.ItemChecked -= listTransf_ItemChecked;
                listTransf.ItemCheck -= listTransf_ItemCheck;
                listTransf.Items[i].Checked = listTransf.Items[i].Selected;
                listTransf.ItemChecked += listTransf_ItemChecked;
                listTransf.ItemCheck += listTransf_ItemCheck;
            }
        }
        private void listTransf_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listTransf.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listTransf.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listTransf.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            //CODIGO ACIMA
            if ((listTransf.SelectedItems.Count > 0) && (listTransf.SelectedItems.Count <= 1))
            {
                if (listTransf.SelectedItems.Count == 0)
                {
                    return;
                }
                ListViewItem item = listTransf.SelectedItems[0];
                //fill the text boxes
                lblNome.Enabled = true;
                cbNome.Enabled = true;

                lblLote.Enabled = true;
                txtLote.Enabled = true;

                lblLocal.Enabled = true;
                txtLocal.Enabled = true;

                lblArmazem.Enabled = true;
                cbArmazem.Enabled = true;

                string Nome = item.SubItems[0].Text;
                cbNome.Text = Nome;
                string Lote = item.SubItems[1].Text;
                txtLote.Text = Lote;
                string Quantidade = item.SubItems[2].Text;
                txtQuantidade.Text = Quantidade;
                string Local = item.SubItems[3].Text;
                txtLocal.Text = Local;
                string Armazem = item.SubItems[4].Text;
                cbArmazem.Text = Armazem;

                


                for (int i = 0; i < listTransf.Items.Count; i++)
                {
                    if (listTransf.Items[i].Selected)
                    {
                        listTransf.Items[i].Remove();
                    }
                }
            }
            else
            {
                if (listTransf.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Por favor, selecione apenas um item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(listTransf.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Por favor, selecione algum item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            


        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            if (lblNome.Enabled == true)
            {
                if ((string.IsNullOrEmpty(cbNome.Text)) || (string.IsNullOrEmpty(txtLocal.Text)) ||
                    (string.IsNullOrEmpty(txtLote.Text)) || (string.IsNullOrEmpty(cbArmazem.Text)) ||
                    (string.IsNullOrEmpty(txtQuantidade.Text)))
                {

                    //NOME
                    if (string.IsNullOrEmpty(cbNome.Text))
                    {
                        lblNome.Text = "Nome do Produto*:";
                        lblNome.ForeColor = Color.FromArgb(255, 121, 121);
                    }
                    else
                    {
                        lblNome.Text = "Nome do Produto:";
                        lblNome.ForeColor = Color.Black;
                    }

                    //Localização
                    if (string.IsNullOrEmpty(txtLocal.Text))
                    {
                        lblLocal.Text = "Localização*:";
                        lblLocal.ForeColor = Color.FromArgb(255, 121, 121);
                    }
                    else
                    {
                        lblLocal.Text = "Localização:";
                        lblLocal.ForeColor = Color.Black;
                    }

                    //Armazém
                    if (string.IsNullOrEmpty(cbArmazem.Text))
                    {
                        lblArmazem.Text = "Armazém*:";
                        lblArmazem.ForeColor = Color.FromArgb(255, 121, 121);
                    }
                    else
                    {
                        lblArmazem.Text = "Armazém:";
                        lblArmazem.ForeColor = Color.Black;
                    }

                    //Lote
                    if (string.IsNullOrEmpty(txtLote.Text))
                    {
                        lblLote.Text = "Lote*:";
                        lblLote.ForeColor = Color.FromArgb(255, 121, 121);
                    }
                    else
                    {
                        lblLote.Text = "Lote:";
                        lblLote.ForeColor = Color.Black;
                    }

                    //Quantidade
                    if (string.IsNullOrEmpty(txtQuantidade.Text))
                    {
                        lblQuantidade.Text = "Quantidade*:";
                        lblQuantidade.ForeColor = Color.FromArgb(255, 121, 121);
                    }
                    else
                    {
                        lblQuantidade.Text = "Quantidade:";
                        lblQuantidade.ForeColor = Color.Black;
                    }
                    MessageBox.Show("Por favor, preencha todos os dados destacados.", "Erro", MessageBoxButtons.OK);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new[] {cbNome.Text, txtLote.Text, txtQuantidade.Text,
                    txtLocal.Text, cbArmazem.Text});
                    listTransf.Items.Add(item);

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
                    };

                    func(Controls);
                    lblNome.Enabled = false;
                    cbNome.Enabled = false;

                    lblLote.Enabled = false;
                    txtLote.Enabled = false;

                    lblLocal.Enabled = false;
                    txtLocal.Enabled = false;

                    lblArmazem.Enabled = false;
                    cbArmazem.Enabled = false;
                }
            }
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            
            DialogResult d = MessageBox.Show("Tem certeza de que deseja aprovar?", "Aprovar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                //CODIGO AQUI, ACIMA
                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
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
