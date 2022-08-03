using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLagune.Compras.Pedidos;


namespace ProjetoLagune.Pedidos
{
    public partial class FrmPedidos : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;

        public FrmPedidos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Compras\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAmareloCompras.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAmareloComprasMouse.png");

        }


        //CONFIGURACOES DO LISTVIEW
        private void listProdutos_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listProdutos.Items.Count; i++)
            {
                listProdutos.ItemSelectionChanged -= listProdutos_ItemSelectionChanged;
                listProdutos.ItemCheck -= listProdutos_ItemCheck;
                listProdutos.Items[i].Selected = listProdutos.Items[i].Checked;
                listProdutos.ItemSelectionChanged += listProdutos_ItemSelectionChanged;
                listProdutos.ItemCheck += listProdutos_ItemCheck;
            }
        }
        private void listProdutos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listProdutos.Items.Count; i++)
            {
                listProdutos.ItemChecked -= listProdutos_ItemChecked;
                listProdutos.ItemCheck -= listProdutos_ItemCheck;
                listProdutos.Items[i].Checked = listProdutos.Items[i].Selected;
                listProdutos.ItemChecked += listProdutos_ItemChecked;
                listProdutos.ItemCheck += listProdutos_ItemCheck;
            }
        }
        private void listProdutos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listProdutos.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listProdutos.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listProdutos.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //CONFIGURACOES DAS CAIXAS DE TEXTO NUMERICAS 
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtICMS_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtIPI_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            decimal quantidade, valortotal, valorunit, IPI;
            decimal guarda;
            decimal guardaparalista;
            
            decimal IPIpCalc;

            if (string.IsNullOrEmpty(cbFornecedor.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome do Fornecedor.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(cbArmazem.Text))
                {
                    MessageBox.Show("Por Favor, Informe o Estoque Destinatário.", "Erro", MessageBoxButtons.OK);
                }
                else
                {
                    if (string.IsNullOrEmpty(cbNomeProduto.Text))
                    {
                        MessageBox.Show("Por Favor, Informe o Nome do Produto.", "Erro", MessageBoxButtons.OK);
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(txtQuantidade.Text))
                        {
                            MessageBox.Show("Por Favor, Informe a Quantidade.", "Erro", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtValorUnitario.Text))
                            {
                                MessageBox.Show("Por Favor, Informe o Valor Unitário do Produto.", "Erro", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cbUnidade.Text))
                                {
                                    MessageBox.Show("Por Favor, Informe a Unidade do Produto.", "Erro", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    
                                    if (!string.IsNullOrEmpty(txtIPI.Text))
                                    {
                                        IPI = Convert.ToDecimal(txtIPI.Text);
                                    }
                                    else
                                    {
                                        IPI = 0;
                                    }
                                    quantidade = Convert.ToDecimal(txtQuantidade.Text);
                                    valorunit = Convert.ToDecimal(txtValorUnitario.Text);
                                    IPIpCalc = IPI / 100;
                                    
                                    if (string.IsNullOrEmpty(txtValorTotal.Text))
                                    {

                                        valortotal = quantidade * valorunit;
                                        valortotal = (valortotal * IPIpCalc) + valortotal;
                                        txtValorTotal.Text = Convert.ToString(valortotal);
                                        ListViewItem item = new ListViewItem(new[] { Convert.ToString(cbNomeProduto.Text),
                                        Convert.ToString(cbUnidade.Text), txtQuantidade.Text, txtValorUnitario.Text,
                                        txtValorTotal.Text, Convert.ToString(IPI)});
                                        listProdutos.Items.Add(item);


                                    }


                                    else
                                    {

                                        guarda = Convert.ToDecimal(txtValorTotal.Text);
                                        valortotal = quantidade * valorunit;
                                        valortotal = (valortotal * IPIpCalc) + valortotal;
                                        guardaparalista = valortotal;
                                        valortotal = valortotal + guarda;
                                        txtValorTotal.Text = Convert.ToString(valortotal);
                                        ListViewItem item = new ListViewItem(new[] { Convert.ToString(cbNomeProduto.Text),
                                        Convert.ToString(cbUnidade.Text), txtQuantidade.Text, txtValorUnitario.Text,
                                        Convert.ToString(guardaparalista),
                                        Convert.ToString(IPI)});
                                        listProdutos.Items.Add(item);

                                    }
                                    cbNomeProduto.Text = "";
                                    cbUnidade.Text = "";
                                    txtValorUnitario.Text = "";
                                    txtQuantidade.Text = "";
                                    
                                    txtIPI.Text = "";
                                }

                            }
                        }

                    }
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            for (int i = 0; i < listProdutos.Items.Count; i++)
            {
                if (listProdutos.Items[i].Selected)
                {
                    decimal valornovo;
                    decimal valoratual;
                    decimal valorexcluido;
                    string valore = listProdutos.Items[0].SubItems[4].Text;
                    valorexcluido = Convert.ToDecimal(valore);
                    valoratual = Convert.ToDecimal(txtValorTotal.Text);
                    valornovo = valoratual - valorexcluido;
                    txtValorTotal.Text = valornovo.ToString();

                    listProdutos.Items[i].Remove();
                    
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            pbImprimir.Enabled = true;
            lblImprimir.Enabled = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            if (!string.IsNullOrEmpty(cbNomeProduto.Text))
            {
                MessageBox.Show("Por Favor, Termine de Preencher os Dados Atuais.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                
                if ((listProdutos.SelectedItems.Count > 0) && (listProdutos.SelectedItems.Count <= 1))
                {
                    decimal valort = Convert.ToDecimal(txtValorTotal.Text);
                    decimal final;
                    if (listProdutos.SelectedItems.Count == 0)
                    {
                        return;
                    }
                    ListViewItem item = listProdutos.SelectedItems[0];
                    //fill the text boxes

                    string Nome = item.SubItems[0].Text;
                    cbNomeProduto.Text = Nome;
                    string Especie = item.SubItems[1].Text;
                    cbUnidade.Text = Especie;
                    string Quantidade = item.SubItems[2].Text;
                    txtQuantidade.Text = Quantidade;
                    string ValorUnit = item.SubItems[3].Text;
                    txtValorUnitario.Text = ValorUnit;
                    decimal valortcalc = Convert.ToDecimal(item.SubItems[4].Text);
                    final = valort - valortcalc;
                    txtValorTotal.Text = final.ToString();
                    
                    string IPI = item.SubItems[5].Text;
                    txtIPI.Text = IPI;


                    for (int i = 0; i < listProdutos.Items.Count; i++)
                    {
                        if (listProdutos.Items[i].Selected)
                        {
                            listProdutos.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    if (listProdutos.SelectedItems.Count > 1)
                    {
                        MessageBox.Show("Por favor, selecione apenas um item.", "Erro", MessageBoxButtons.OK);
                    }
                    if (listProdutos.SelectedItems.Count <= 0)
                    {
                        MessageBox.Show("Por favor, selecione algum item.", "Erro", MessageBoxButtons.OK);
                    }

                }

            }
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHistorico HIST = new FrmHistorico();
            HIST.ShowDialog();
            Show();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmHistorico f = new FrmHistorico();
            f.ShowDialog();
        }

        //ESCOLHA DE TIPO DE PRODUTO
        private void rdMateria_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMateria.Checked)
            {
                lblNomedoProd.Enabled = true;
                lblQuantidade.Enabled = true;
                lblValorU.Enabled = true;
                lblValorTotal.Enabled = true;
                lblUnidade.Enabled = true;
                lblIPI.Enabled = true;

                txtIPI.Enabled = true;
                txtQuantidade.Enabled = true;
                txtValorUnitario.Enabled = true;
                cbNomeProduto.Enabled = true;
                cbUnidade.Enabled = true;

                lblAdicionar.Enabled = true;
                lblEditar.Enabled = true;
                lblExcluir.Enabled = true;
                pbAdicionar.Enabled = true;
                pbEditar.Enabled = true;
                pbExcluir.Enabled = true;
                listProdutos.Enabled = true;
            }
        }
        private void rdEmba_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmba.Checked)
            {
                lblNomedoProd.Enabled = true;
                lblQuantidade.Enabled = true;
                lblValorTotal.Enabled = true;
                lblValorU.Enabled = true;
                lblUnidade.Enabled = true;
                lblIPI.Enabled = true;

                txtIPI.Enabled = true;
                txtQuantidade.Enabled = true;
                txtValorUnitario.Enabled = true;
                cbNomeProduto.Enabled = true;
                cbUnidade.Enabled = true;

                lblAdicionar.Enabled = true;
                lblEditar.Enabled = true;
                lblExcluir.Enabled = true;
                pbAdicionar.Enabled = true;
                pbEditar.Enabled = true;
                pbExcluir.Enabled = true;
                listProdutos.Enabled = true;
            }
        }
        private void rdPAcaba_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPAcaba.Checked)
            {
                lblNomedoProd.Enabled = true;
                lblQuantidade.Enabled = true;
                lblValorTotal.Enabled = true;
                lblValorU.Enabled = true;
                lblUnidade.Enabled = true;
                lblIPI.Enabled = true;

                txtIPI.Enabled = true;
                txtQuantidade.Enabled = true;
                txtValorUnitario.Enabled = true;
                cbNomeProduto.Enabled = true;
                cbUnidade.Enabled = true;

                lblAdicionar.Enabled = true;
                lblEditar.Enabled = true;
                lblExcluir.Enabled = true;
                pbAdicionar.Enabled = true;
                pbEditar.Enabled = true;
                pbExcluir.Enabled = true;
                listProdutos.Enabled = true;
            }
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
            pbHistorico.Image = imagem_mouse;
            lblHistorico.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbLimparTela_MouseLeave(object sender, EventArgs e)
        {
            pbHistorico.Image = imagem_normal;
            lblHistorico.BackColor = Color.FromArgb(235, 239, 243);
        }

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
    }
}
