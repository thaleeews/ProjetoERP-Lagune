using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Vendas.CancelarOuAlterar
{
    public partial class FrmCancelarOuAlterar : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmCancelarOuAlterar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Vendas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoVermelhoVendas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoVermelhoVendasMouse.png");
        }


        //CONFIGURACOES DO LISTVIEW
        private void listProdutosV_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listProdutosV.Items.Count; i++)
            {
                listProdutosV.ItemSelectionChanged -= listProdutosV_ItemSelectionChanged;
                listProdutosV.ItemCheck -= listProdutosV_ItemCheck;
                listProdutosV.Items[i].Selected = listProdutosV.Items[i].Checked;
                listProdutosV.ItemSelectionChanged += listProdutosV_ItemSelectionChanged;
                listProdutosV.ItemCheck += listProdutosV_ItemCheck;
            }
        }
        private void listProdutosV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listProdutosV.Items.Count; i++)
            {
                listProdutosV.ItemChecked -= listProdutosV_ItemChecked;
                listProdutosV.ItemCheck -= listProdutosV_ItemCheck;
                listProdutosV.Items[i].Checked = listProdutosV.Items[i].Selected;
                listProdutosV.ItemChecked += listProdutosV_ItemChecked;
                listProdutosV.ItemCheck += listProdutosV_ItemCheck;
            }
        }
        private void listProdutosV_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listProdutosV.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listProdutosV.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listProdutosV.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //BOTOES
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            decimal quantidade, valortotal, valorunit;
            quantidade = Convert.ToDecimal(txtQuantidade.Text);
            valorunit = Convert.ToDecimal(txtValorUnit.Text);
            decimal guarda;
            decimal guardaparalista;



            if (string.IsNullOrEmpty(txtValorTotal.Text))
            {

                valortotal = quantidade * valorunit;
                txtValorTotal.Text = Convert.ToString(valortotal);
                ListViewItem item = new ListViewItem(new[] { Convert.ToString(comboProduto.Text),
                Convert.ToString(comboEspecie.Text), txtQuantidade.Text, txtValorUnit.Text, txtValorTotal.Text });
                listProdutosV.Items.Add(item);

            }
            else
            {
                guarda = Convert.ToDecimal(txtValorTotal.Text);
                valortotal = quantidade * valorunit;
                guardaparalista = valortotal;
                valortotal = valortotal + guarda;
                txtValorTotal.Text = Convert.ToString(valortotal);
                ListViewItem item = new ListViewItem(new[] { Convert.ToString(comboProduto.Text),
                Convert.ToString(comboEspecie.Text), txtQuantidade.Text, txtValorUnit.Text, Convert.ToString(guardaparalista)});
                listProdutosV.Items.Add(item);

            }
            comboProduto.Text = "";
            comboEspecie.Text = "";
            txtValorUnit.Text = "";
            txtQuantidade.Text = "";




        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            for (int i = 0; i < listProdutosV.Items.Count; i++)
            {
                if (listProdutosV.Items[i].Selected)
                {
                    decimal valornovo;
                    decimal valoratual;
                    decimal valorexcluido;
                    string valore = listProdutosV.Items[0].SubItems[4].Text;
                    valorexcluido = Convert.ToDecimal(valore);
                    valoratual = Convert.ToDecimal(txtValorTotal.Text);
                    valornovo = valoratual - valorexcluido;
                    txtValorTotal.Text = valornovo.ToString();

                    listProdutosV.Items[i].Remove();

                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(comboProduto.Text))
            {
                MessageBox.Show("Por Favor, Termine de Preencher os Dados Atuais.");
            }
            else
            {
                if ((listProdutosV.SelectedItems.Count > 0) && (listProdutosV.SelectedItems.Count <= 1))
                {
                    decimal valort = Convert.ToDecimal(txtValorTotal.Text);
                    decimal final;
                    if (listProdutosV.SelectedItems.Count == 0)
                    {
                        return;
                    }
                    ListViewItem item = listProdutosV.SelectedItems[0];
                    //fill the text boxes

                    string Nome = item.SubItems[0].Text;
                    comboProduto.Text = Nome;
                    string Especie = item.SubItems[1].Text;
                    comboEspecie.Text = Especie;
                    string Quantidade = item.SubItems[2].Text;
                    txtQuantidade.Text = Quantidade;
                    string ValorUnit = item.SubItems[3].Text;
                    txtValorUnit.Text = ValorUnit;
                    decimal valortcalc = Convert.ToDecimal(item.SubItems[4].Text);
                    final = valort - valortcalc;
                    txtValorTotal.Text = final.ToString();



                    for (int i = 0; i < listProdutosV.Items.Count; i++)
                    {
                        if (listProdutosV.Items[i].Selected)
                        {
                            listProdutosV.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    if (listProdutosV.SelectedItems.Count > 1)
                    {
                        MessageBox.Show("Por favor, selecione apenas um item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (listProdutosV.SelectedItems.Count <= 0)
                    {
                        MessageBox.Show("Por favor, selecione algum item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {

        }

        private async void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
        }


        //CONFIGURACOES DAS CAIXAS DE TEXTO
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
        private void txtValorUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pbCancelar_MouseEnter(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_mouse;
            lblCancelar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbCancelar_MouseLeave(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_normal;
            lblCancelar.BackColor = Color.FromArgb(235, 239, 243);
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

        private void pbAlterar_MouseEnter(object sender, EventArgs e)
        {
            pbAlterar.Image = imagem_mouse;
            lblAlterar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbAlterar_MouseLeave(object sender, EventArgs e)
        {
            pbAlterar.Image = imagem_normal;
            lblAlterar.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbImprimir_MouseEnter(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_mouse;
            lblCancelar.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbImprimir_MouseLeave(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_normal;
            lblCancelar.BackColor = Color.FromArgb(235, 239, 243);
        }
    }
}

