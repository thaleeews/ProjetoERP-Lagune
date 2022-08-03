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


namespace ProjetoLagune.Pedidos
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            decimal quantidade, valortotal, valorunit, IPI, ICMS;
            decimal guarda;
            decimal guardaparalista;
            decimal ICMSpCalc;
            decimal IPIpCalc;

            if (string.IsNullOrEmpty(comboFornecedor.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome do Fornecedor.");
            }
            else
            {
                if (string.IsNullOrEmpty(comboEstoque.Text))
                {
                    MessageBox.Show("Por Favor, Informe o Estoque Destinatário.");
                }
                else
                {
                    if (string.IsNullOrEmpty(comboNomeProduto.Text))
                    {
                        MessageBox.Show("Por Favor, Informe o Nome do Produto.");
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(txtQuantidade.Text))
                        {
                            MessageBox.Show("Por Favor, Informe a Quantidade.");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtValorUnitario.Text))
                            {
                                MessageBox.Show("Por Favor, Informe o Valor Unitário do Produto.");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(comboUnidade.Text))
                                {
                                    MessageBox.Show("Por Favor, Informe a Unidade do Produto.");
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(txtICMS.Text))
                                    {
                                        ICMS = Convert.ToDecimal(txtICMS.Text);
                                    }
                                    else
                                    {
                                        ICMS = 0;
                                    }
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
                                    ICMSpCalc = ICMS / 100;
                                    if (string.IsNullOrEmpty(txtValorTotal.Text))
                                    {

                                        valortotal = quantidade * valorunit;
                                        valortotal = (valortotal * ICMSpCalc) + (valortotal * IPIpCalc) + valortotal;
                                        txtValorTotal.Text = Convert.ToString(valortotal);
                                        ListViewItem item = new ListViewItem(new[] { Convert.ToString(comboNomeProduto.Text),
                        Convert.ToString(comboUnidade.Text), txtQuantidade.Text, txtValorUnitario.Text, txtValorTotal.Text, Convert.ToString(ICMS),
                        Convert.ToString(IPI)});
                                        listProdutos.Items.Add(item);

                                    }


                                    else
                                    {

                                        guarda = Convert.ToDecimal(txtValorTotal.Text);
                                        valortotal = quantidade * valorunit;
                                        valortotal = (valortotal * ICMSpCalc) + (valortotal * IPIpCalc) + valortotal;
                                        guardaparalista = valortotal;
                                        valortotal = valortotal + guarda;
                                        txtValorTotal.Text = Convert.ToString(valortotal);
                                        ListViewItem item = new ListViewItem(new[] { Convert.ToString(comboNomeProduto.Text),
                        Convert.ToString(comboUnidade.Text), txtQuantidade.Text, txtValorUnitario.Text, Convert.ToString(guardaparalista), Convert.ToString(ICMS),
                        Convert.ToString(IPI)});
                                        listProdutos.Items.Add(item);

                                    }
                                    comboNomeProduto.Text = "";
                                    comboUnidade.Text = "";
                                    txtValorUnitario.Text = "";
                                    txtQuantidade.Text = "";
                                    txtICMS.Text = "";
                                    txtIPI.Text = "";
                                }

                            }
                        }

                    }
                }
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

        private void btConcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns");
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            string Nome = listProdutos.Items[0].SubItems[0].Text;
            comboNomeProduto.Text = Nome;
            string Especie = listProdutos.Items[0].SubItems[1].Text;
            comboUnidade.Text = Especie;
            string Quantidade = listProdutos.Items[0].SubItems[2].Text;
            txtQuantidade.Text = Quantidade;
            string ValorUnit = listProdutos.Items[0].SubItems[3].Text;
            txtValorUnitario.Text = ValorUnit;
            string ValorT = listProdutos.Items[0].SubItems[4].Text;
            txtValorTotal.Text = ValorT;
            string ICMS = listProdutos.Items[0].SubItems[5].Text;
            txtICMS.Text = ICMS;
            string IPI = listProdutos.Items[0].SubItems[6].Text;
            txtIPI.Text = IPI;
            for (int i = 0; i < listProdutos.Items.Count; i++)
            {
                if (listProdutos.Items[i].Selected)
                { 
                    listProdutos.Items[i].Remove();
                }
            }
        }

        private void btLimparTela_Click(object sender, EventArgs e)
        {
            txtNumPedido.Text = "";
            comboFornecedor.Text = "";
            comboEstoque.Text = "";
            comboNomeProduto.Text = "";
            comboUnidade.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotal.Text = "";
            txtICMS.Text = "";
            txtIPI.Text = "";
            listProdutos.Items.Clear();
        }
    }
}
