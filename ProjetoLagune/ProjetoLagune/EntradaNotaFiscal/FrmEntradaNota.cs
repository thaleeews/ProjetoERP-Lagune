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
        public FrmEntradaNota()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

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

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {
            
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

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtxtValidade_Click(object sender, EventArgs e)
        {
            mtxtValidade.SelectionStart = 0;
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
                comboNome.Enabled = false;
                ListViewItem item = new ListViewItem(new[] {comboNome.Text,
                txtQuantidade.Text, txtLote.Text, mtxtValidade.Text});
                listProdutosNota.Items.Add(item);
                comboNome.Text = "";
                txtQuantidade.Text = "";
                txtLote.Text = "";
                mtxtValidade.Text = "";
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            comboNome.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();


            for (int j = 0; j < listProdutosNota.Items.Count; j++)
            {
                if (listProdutosNota.Items[j].Selected)
                {
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
                    listProdutosNota.Items[i].Remove();

                }
            }
        }
    }
}
