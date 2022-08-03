using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Vendas.Orcamento
{
    public partial class FrmOrcamento : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;



        public FrmOrcamento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Vendas\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoVermelhoVendas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoVermelhoVendasMouse.png");
        }


        //CONFIGURACOES DO LISTVIEW
        private void listOrca_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listOrca.Items.Count; i++)
            {
                listOrca.ItemSelectionChanged -= listOrca_ItemSelectionChanged;
                listOrca.ItemCheck -= listOrca_ItemCheck;
                listOrca.Items[i].Selected = listOrca.Items[i].Checked;
                listOrca.ItemSelectionChanged += listOrca_ItemSelectionChanged;
                listOrca.ItemCheck += listOrca_ItemCheck;
            }
        }
        private void listOrca_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listOrca.Items.Count; i++)
            {
                listOrca.ItemChecked -= listOrca_ItemChecked;
                listOrca.ItemCheck -= listOrca_ItemCheck;
                listOrca.Items[i].Checked = listOrca.Items[i].Selected;
                listOrca.ItemChecked += listOrca_ItemChecked;
                listOrca.ItemCheck += listOrca_ItemCheck;
            }
        }
        private void listOrca_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listOrca.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listOrca.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listOrca.Items[e.Index]) e.NewValue = CheckState.Checked;
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
            listOrca.Items.Clear();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            decimal valort;

            decimal guarda;
            decimal valorlista;
            if (string.IsNullOrEmpty(cbCliente.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome do Cliente.");
            }
            else
            {
                if (string.IsNullOrEmpty(cbProduto.Text) || (string.IsNullOrEmpty(txtQuantidade.Text))
                    || (string.IsNullOrEmpty(txtValorUnitario.Text)) || (string.IsNullOrEmpty(cbUnidade.Text)))
                {
                    MessageBox.Show("Por Favor, Preencha Todos os Dados.");
                }
                else
                {
                    decimal qt = Convert.ToDecimal(txtQuantidade.Text);
                    decimal vu = Convert.ToDecimal(txtValorUnitario.Text);
                    if (string.IsNullOrEmpty(txtValorTotal.Text))
                    {

                        valort = qt * vu;
                        valorlista = valort;
                    }
                    else
                    {
                        guarda = Convert.ToDecimal(txtValorTotal.Text);
                        valort = (qt * vu) + guarda;
                        valorlista = valort - guarda;

                    }


                    txtValorTotal.Text = valort.ToString();
                    ListViewItem item = new ListViewItem(new[] { cbProduto.Text, cbUnidade.Text, txtQuantidade.Text,
                txtValorUnitario.Text, Convert.ToString(valorlista) });
                    listOrca.Items.Add(item);
                    txtQuantidade.Clear();
                    txtValorUnitario.Clear();
                    cbProduto.Text = "";
                    cbUnidade.Text = "";

                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbProduto.Text))
            {
                MessageBox.Show("Por Favor, Termine de Preencher os Dados Atuais.");
                return;
            }
            else
            {
                if (listOrca.SelectedItems.Count > 0)
                {
                    decimal valort = Convert.ToDecimal(txtValorTotal.Text);
                    decimal final;
                    if (listOrca.SelectedItems.Count == 0)
                    {
                        return;
                    }
                    ListViewItem item = listOrca.SelectedItems[0];
                    //fill the text boxes

                    string Nome = item.SubItems[0].Text;
                    cbProduto.Text = Nome;
                    string Especie = item.SubItems[1].Text;
                    cbUnidade.Text = Especie;
                    string Quantidade = item.SubItems[2].Text;
                    txtQuantidade.Text = Quantidade;
                    string ValorUnit = item.SubItems[3].Text;
                    txtValorUnitario.Text = ValorUnit;
                    decimal valortcalc = Convert.ToDecimal(item.SubItems[4].Text);
                    final = valort - valortcalc;
                    txtValorTotal.Text = final.ToString();



                    for (int i = 0; i < listOrca.Items.Count; i++)
                    {
                        if (listOrca.Items[i].Selected)
                        {
                            listOrca.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, Selecione Algum Item.");
                }

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listOrca.Items.Count; i++)
            {
                if (listOrca.Items[i].Selected)
                {
                    decimal valornovo;
                    decimal valoratual;
                    decimal valorexcluido;
                    string valore = listOrca.Items[0].SubItems[4].Text;
                    valorexcluido = Convert.ToDecimal(valore);
                    valoratual = Convert.ToDecimal(txtValorTotal.Text);
                    valornovo = valoratual - valorexcluido;
                    txtValorTotal.Text = valornovo.ToString();

                    listOrca.Items[i].Remove();

                }
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;
        }


        //CONFIGURACOES DAS CAIXAS DE TEXTO
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void FrmOrcamento_Load(object sender, EventArgs e)
        {

            
        }
    }
}
