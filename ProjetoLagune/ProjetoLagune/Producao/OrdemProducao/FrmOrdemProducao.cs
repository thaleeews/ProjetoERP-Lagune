using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Producao.OrdemProducao
{
    public partial class FrmOrdemProducao : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmOrdemProducao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Producao\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoRoxoProducao.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoRoxoProducaoMouse.png");

        }


        //CONFIGURACOES DAS LISTVIEW
        private void listMateriaPrima_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listMateriaPrima.Items.Count; i++)
            {
                listMateriaPrima.ItemSelectionChanged -= listMateriaPrima_ItemSelectionChanged;
                listMateriaPrima.ItemCheck -= listMateriaPrima_ItemCheck;
                listMateriaPrima.Items[i].Selected = listMateriaPrima.Items[i].Checked;
                listMateriaPrima.ItemSelectionChanged += listMateriaPrima_ItemSelectionChanged;
                listMateriaPrima.ItemCheck += listMateriaPrima_ItemCheck;
            }
        }
        private void listMateriaPrima_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listMateriaPrima.Items.Count; i++)
            {
                listMateriaPrima.ItemChecked -= listMateriaPrima_ItemChecked;
                listMateriaPrima.ItemCheck -= listMateriaPrima_ItemCheck;
                listMateriaPrima.Items[i].Checked = listMateriaPrima.Items[i].Selected;
                listMateriaPrima.ItemChecked += listMateriaPrima_ItemChecked;
                listMateriaPrima.ItemCheck += listMateriaPrima_ItemCheck;
            }
        }
        private void listMateriaPrima_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listMateriaPrima.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listMateriaPrima.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listMateriaPrima.Items[e.Index]) e.NewValue = CheckState.Checked;
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
        private void txtQuantidadeEmba_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtQuantidadeMat_KeyPress(object sender, KeyPressEventArgs e)
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
        private void comboNomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNomeProduto.Text))
            {
                tabOrdemProd.Enabled = true;
            }
        }


        //BOTOES
        private void btAdicionarMat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboNomeMat.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome da Matéria Prima.");
            }
            else
            {
                if(string.IsNullOrEmpty(txtQuantidadeMat.Text))
                {
                    MessageBox.Show("Por Favor, Informe a Quantidade da Matéria Prima.");
                }
                else
                {
                    if(string.IsNullOrEmpty(comboEspecieMat.Text))
                    {
                        MessageBox.Show("Por Favor, Informe a Unidade da Matéria Prima.");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new[] {comboNomeMat.Text, comboEspecieMat.Text, txtQuantidadeMat.Text});
                        listMateriaPrima.Items.Add(item);
                        comboNomeMat.Text = "";
                        txtQuantidadeMat.Text = "";
                        comboEspecieMat.Text = "";
                    }
                }
            }
            
        }

        private void btEditarMat_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            if (!string.IsNullOrEmpty(comboNomeMat.Text))
            {
                MessageBox.Show("Por Favor, Termine de Preencher os Dados Atuais.");
            }
            else
            {
                if (listMateriaPrima.SelectedItems.Count > 0)
                {
                    if (listMateriaPrima.SelectedItems.Count == 0)
                    {
                        return;
                    }
                    ListViewItem item = listMateriaPrima.SelectedItems[0];
                    //fill the text boxes

                    string Nome = item.SubItems[0].Text;
                    comboNomeMat.Text = Nome;
                    string Especie = item.SubItems[1].Text;
                    comboEspecieMat.Text = Especie;
                    string Quantidade = item.SubItems[2].Text;
                    txtQuantidadeMat.Text = Quantidade;
                    


                    for (int i = 0; i < listMateriaPrima.Items.Count; i++)
                    {
                        if (listMateriaPrima.Items[i].Selected)
                        {
                            listMateriaPrima.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, Selecione Algum Item");
                }

            }
        }

        private void btExcluirMat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listMateriaPrima.Items.Count; i++)
            {
                if (listMateriaPrima.Items[i].Selected)
                {
                    listMateriaPrima.Items[i].Remove();
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
            
            listMateriaPrima.Items.Clear();
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            //CODIGO AQUI, ACIMA
            lblSalvo.Visible = true;
            await Task.Delay(3000);
            lblSalvo.Visible = false;
        }

        private void btConcluir_Click(object sender, EventArgs e)
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

        private void pbEditarMat_MouseEnter(object sender, EventArgs e)
        {
            pbEditarMat.Image = imagem_mouse;
            lblEditarMat.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbEditarMat_MouseLeave(object sender, EventArgs e)
        {
            pbEditarMat.Image = imagem_normal;
            lblEditarMat.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbExcluirMat_MouseEnter(object sender, EventArgs e)
        {
            pbExcluirMat.Image = imagem_mouse;
            lblExcluirMat.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbExcluirMat_MouseLeave(object sender, EventArgs e)
        {
            pbExcluirMat.Image = imagem_normal;
            lblExcluirMat.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbAdicionarMat_MouseEnter(object sender, EventArgs e)
        {
            pbAdicionarMat.Image = imagem_mouse;
            lblAdicionarMat.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbAdicionarMat_MouseLeave(object sender, EventArgs e)
        {
            pbAdicionarMat.Image = imagem_normal;
            lblAdicionarMat.BackColor = Color.FromArgb(235, 239, 243);
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
