using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Vendas
{
    public partial class FrmNovaVenda : Form
    {
        public FrmNovaVenda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

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
                if (listProdutosV.SelectedItems.Count > 0)
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
                    MessageBox.Show("Por Favor, Selecione Algum Item");
                }

            }
        }

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
            listProdutosV.Items.Clear();
        }
    }
}
        

