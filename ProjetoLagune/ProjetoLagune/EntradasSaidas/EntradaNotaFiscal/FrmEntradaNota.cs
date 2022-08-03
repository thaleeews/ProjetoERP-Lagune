using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.EntradaNotaFiscal
{
    public partial class FrmEntradaNota : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmEntradaNota()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Entradas e Saidas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoEntradasESaidas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoEntradasESaidasMouse.png");
        }


        //CONFIGURACOES DA LISTVIEW
        private void listProdutosNota_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listProdutosNota.Items.Count; i++)
            {
                listProdutosNota.ItemSelectionChanged -= listProdutosNota_ItemSelectionChanged;
                listProdutosNota.ItemCheck -= listProdutosNota_ItemCheck;
                listProdutosNota.Items[i].Selected = listProdutosNota.Items[i].Checked;
                listProdutosNota.ItemSelectionChanged += listProdutosNota_ItemSelectionChanged;
                listProdutosNota.ItemCheck += listProdutosNota_ItemCheck;
            }
        }
        private void listProdutosNota_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listProdutosNota.Items.Count; i++)
            {
                listProdutosNota.ItemChecked -= listProdutosNota_ItemChecked;
                listProdutosNota.ItemCheck -= listProdutosNota_ItemCheck;
                listProdutosNota.Items[i].Checked = listProdutosNota.Items[i].Selected;
                listProdutosNota.ItemChecked += listProdutosNota_ItemChecked;
                listProdutosNota.ItemCheck += listProdutosNota_ItemCheck;
            }
        }
        private void listProdutosNota_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listProdutosNota.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listProdutosNota.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listProdutosNota.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //CONFIGURACOES DAS CAIXAS DE TEXTO
        private void mtxtNumeroSefaz_Click(object sender, EventArgs e)
        {
            mtxtNumeroSefaz.SelectionStart = 0;
        }
        private void txtNumeroNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void mtxtDataEmissao_Click(object sender, EventArgs e)
        {
            mtxtDataEmissao.SelectionStart = 0;
        }
        private void txt1Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt2Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt3Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt4Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt5Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt6Valor_KeyPress(object sender, KeyPressEventArgs e)
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
        private void mtxt1Duplicata_Click(object sender, EventArgs e)
        {
            mtxt1Duplicata.SelectionStart = 0;
        }
        private void mtxt2Duplicata_Click(object sender, EventArgs e)
        {
            mtxt2Duplicata.SelectionStart = 0;
        }
        private void mtxt3Duplicata_Click(object sender, EventArgs e)
        {
            mtxt3Duplicata.SelectionStart = 0;
        }
        private void mtxt4Duplicata_Click(object sender, EventArgs e)
        {
            mtxt4Duplicata.SelectionStart = 0;
        }
        private void mtxt5Duplicata_Click(object sender, EventArgs e)
        {
            mtxt5Duplicata.SelectionStart = 0;
        }
        private void mtxt6Duplicata_Click(object sender, EventArgs e)
        {
            mtxt6Duplicata.SelectionStart = 0;
        }
        private void comboDuplicatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDuplicatas.SelectedItem == "1")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = false;
                mtxt2Duplicata.Visible = false;
                lblValor2.Visible = false;
                txt2Valor.Visible = false;

                lbl3Duplicata.Visible = false;
                mtxt3Duplicata.Visible = false;
                lblValor3.Visible = false;
                txt3Valor.Visible = false;

                lbl4Duplicata.Visible = false;
                mtxt4Duplicata.Visible = false;
                lblValor4.Visible = false;
                txt4Valor.Visible = false;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
            if (comboDuplicatas.SelectedItem == "2")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = true;
                mtxt2Duplicata.Visible = true;
                lblValor2.Visible = true;
                txt2Valor.Visible = true;

                lbl3Duplicata.Visible = false;
                mtxt3Duplicata.Visible = false;
                lblValor3.Visible = false;
                txt3Valor.Visible = false;

                lbl4Duplicata.Visible = false;
                mtxt4Duplicata.Visible = false;
                lblValor4.Visible = false;
                txt4Valor.Visible = false;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
            if (comboDuplicatas.SelectedItem == "3")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = true;
                mtxt2Duplicata.Visible = true;
                lblValor2.Visible = true;
                txt2Valor.Visible = true;

                lbl3Duplicata.Visible = true;
                mtxt3Duplicata.Visible = true;
                lblValor3.Visible = true;
                txt3Valor.Visible = true;

                lbl4Duplicata.Visible = false;
                mtxt4Duplicata.Visible = false;
                lblValor4.Visible = false;
                txt4Valor.Visible = false;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;

            }
            if (comboDuplicatas.SelectedItem == "4")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = true;
                mtxt2Duplicata.Visible = true;
                lblValor2.Visible = true;
                txt2Valor.Visible = true;

                lbl3Duplicata.Visible = true;
                mtxt3Duplicata.Visible = true;
                lblValor3.Visible = true;
                txt3Valor.Visible = true;

                lbl4Duplicata.Visible = true;
                mtxt4Duplicata.Visible = true;
                lblValor4.Visible = true;
                txt4Valor.Visible = true;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
            if (comboDuplicatas.SelectedItem == "5")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = true;
                mtxt2Duplicata.Visible = true;
                lblValor2.Visible = true;
                txt2Valor.Visible = true;

                lbl3Duplicata.Visible = true;
                mtxt3Duplicata.Visible = true;
                lblValor3.Visible = true;
                txt3Valor.Visible = true;

                lbl4Duplicata.Visible = true;
                mtxt4Duplicata.Visible = true;
                lblValor4.Visible = true;
                txt4Valor.Visible = true;

                lbl5Duplicata.Visible = true;
                mtxt5Duplicata.Visible = true;
                lblValor5.Visible = true;
                txt5Valor.Visible = true;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
            if (comboDuplicatas.SelectedItem == "6")
            {
                lbl1Duplicata.Visible = true;
                mtxt1Duplicata.Visible = true;
                lblValor1.Visible = true;
                txt1Valor.Visible = true;

                lbl2Duplicata.Visible = true;
                mtxt2Duplicata.Visible = true;
                lblValor2.Visible = true;
                txt2Valor.Visible = true;

                lbl3Duplicata.Visible = true;
                mtxt3Duplicata.Visible = true;
                lblValor3.Visible = true;
                txt3Valor.Visible = true;

                lbl4Duplicata.Visible = true;
                mtxt4Duplicata.Visible = true;
                lblValor4.Visible = true;
                txt4Valor.Visible = true;

                lbl5Duplicata.Visible = true;
                mtxt5Duplicata.Visible = true;
                lblValor5.Visible = true;
                txt5Valor.Visible = true;

                lbl6Duplicata.Visible = true;
                mtxt6Duplicata.Visible = true;
                lblValor6.Visible = true;
                txt6Valor.Visible = true;
            }
            if (comboDuplicatas.SelectedItem == "0")
            {
                lbl1Duplicata.Visible = false;
                mtxt1Duplicata.Visible = false;
                lblValor1.Visible = false;
                txt1Valor.Visible = false;

                lbl2Duplicata.Visible = false;
                mtxt2Duplicata.Visible = false;
                lblValor2.Visible = false;
                txt2Valor.Visible = false;

                lbl3Duplicata.Visible = false;
                mtxt3Duplicata.Visible = false;
                lblValor3.Visible = false;
                txt3Valor.Visible = false;

                lbl4Duplicata.Visible = false;
                mtxt4Duplicata.Visible = false;
                lblValor4.Visible = false;
                txt4Valor.Visible = false;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
            if (comboDuplicatas.SelectedItem == "")
            {
                lbl1Duplicata.Visible = false;
                mtxt1Duplicata.Visible = false;
                lblValor1.Visible = false;
                txt1Valor.Visible = false;

                lbl2Duplicata.Visible = false;
                mtxt2Duplicata.Visible = false;
                lblValor2.Visible = false;
                txt2Valor.Visible = false;

                lbl3Duplicata.Visible = false;
                mtxt3Duplicata.Visible = false;
                lblValor3.Visible = false;
                txt3Valor.Visible = false;

                lbl4Duplicata.Visible = false;
                mtxt4Duplicata.Visible = false;
                lblValor4.Visible = false;
                txt4Valor.Visible = false;

                lbl5Duplicata.Visible = false;
                mtxt5Duplicata.Visible = false;
                lblValor5.Visible = false;
                txt5Valor.Visible = false;

                lbl6Duplicata.Visible = false;
                mtxt6Duplicata.Visible = false;
                lblValor6.Visible = false;
                txt6Valor.Visible = false;
            }
        }
        private void mtxtValidade_Click(object sender, EventArgs e)
        {
            mtxtValidade.SelectionStart = 0;
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
            listProdutosNota.Items.Clear();

            comboNome.Enabled = false;
            txtLote.Enabled = false;
            mtxtValidade.Enabled = false;
            txtQuantidade.Enabled = false;

            lblNome.Enabled = false;
            lblLote.Enabled = false;
            lblQuantidade.Enabled = false;
            lblValidade.Enabled = false;

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboNome.Text) || string.IsNullOrEmpty(txtLote.Text) ||
                string.IsNullOrEmpty(mtxtValidade.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Por Favor, Preencha Todos os Dados.");
            }
            else
            {
                
                ListViewItem item = new ListViewItem(new[] {comboNome.Text,
                txtQuantidade.Text, txtLote.Text, mtxtValidade.Text});
                listProdutosNota.Items.Add(item);
                comboNome.Text = "";
                txtQuantidade.Text = "";
                txtLote.Text = "";
                mtxtValidade.Text = "";

                comboNome.Enabled = false;
                txtLote.Enabled = false;
                mtxtValidade.Enabled = false;
                txtQuantidade.Enabled = false;

                lblNome.Enabled = false;
                lblLote.Enabled = false;
                lblQuantidade.Enabled = false;
                lblValidade.Enabled = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            comboNome.Enabled = true;
            txtLote.Enabled = true;
            mtxtValidade.Enabled = true;
            txtQuantidade.Enabled = true;

            lblNome.Enabled = true;
            lblLote.Enabled = true;
            lblQuantidade.Enabled = true;
            lblValidade.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();


            for (int j = 0; j < listProdutosNota.Items.Count; j++)
            {
                if (listProdutosNota.Items[j].Selected)
                {
                    comboNome.Enabled = true;
                    txtLote.Enabled = true;
                    mtxtValidade.Enabled = true;
                    txtQuantidade.Enabled = true;

                    lblNome.Enabled = true;
                    lblLote.Enabled = true;
                    lblQuantidade.Enabled = true;
                    lblValidade.Enabled = true;

                    string Nome = listProdutosNota.Items[0].SubItems[0].Text;
                    comboNome.Text = Nome;
                    
                    string Quantidade = listProdutosNota.Items[0].SubItems[1].Text;
                    txtQuantidade.Text = Quantidade;

                    string Lote = listProdutosNota.Items[0].SubItems[2].Text;
                    txtLote.Text = Lote;

                    string Validade = listProdutosNota.Items[0].SubItems[3].Text;
                    mtxtValidade.Text = Validade;

                    for (int i = 0; i < listProdutosNota.Items.Count; i++)
                    {
                        if (listProdutosNota.Items[i].Selected)
                        {
                            listProdutosNota.Items[i].Remove();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Não Há Nenhum Item Selecionado.");

                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            for (int i = 0; i < listProdutosNota.Items.Count; i++)
            {
                if (listProdutosNota.Items[i].Selected)
                {
                    comboNome.Enabled = false;
                    txtLote.Enabled = false;
                    mtxtValidade.Enabled = false;
                    txtQuantidade.Enabled = false;

                    lblNome.Enabled = false;
                    lblLote.Enabled = false;
                    lblQuantidade.Enabled = false;
                    lblValidade.Enabled = false;

                    listProdutosNota.Items[i].Remove();

                }
            }
        }

        private async void btRegistrar_Click(object sender, EventArgs e)
        {
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
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

        private void pbNovo_MouseEnter(object sender, EventArgs e)
        {
            pbNovo.Image = imagem_mouse;
            lblNovo.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbNovo_MouseLeave(object sender, EventArgs e)
        {
            pbNovo.Image = imagem_normal;
            lblNovo.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbRegistrar_MouseEnter(object sender, EventArgs e)
        {
            pbRegistrar.Image = imagem_mouse;
            lblRegistrar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbRegistrar_MouseLeave(object sender, EventArgs e)
        {
            pbRegistrar.Image = imagem_normal;
            lblRegistrar.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbPesquisar_MouseEnter(object sender, EventArgs e)
        {
            pbPesquisar.Image = imagem_mouse;
            lblPesquisar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbPesquisar_MouseLeave(object sender, EventArgs e)
        {
            pbPesquisar.Image = imagem_normal;
            lblPesquisar.BackColor = Color.FromArgb(235, 239, 243);
        }
    }
}
