using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Cadastros.CadastroProdutos
{
    public partial class FrmCadastroProdutos : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;
        


        public FrmCadastroProdutos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Cadastros\";
            imagem_normal = Image.FromFile(pasta_botoes + "BotaoAzulCadastros.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "BotaoAzulCadastrosMouse.png");
        }


        //CONFIGURACOES DAS LISTVIEW
        private void listMateriaCad_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listMateriaCad.Items.Count; i++)
            {
                listMateriaCad.ItemSelectionChanged -= listMateriaCad_ItemSelectionChanged;
                listMateriaCad.ItemCheck -= listMateriaCad_ItemCheck;
                listMateriaCad.Items[i].Selected = listMateriaCad.Items[i].Checked;
                listMateriaCad.ItemSelectionChanged += listMateriaCad_ItemSelectionChanged;
                listMateriaCad.ItemCheck += listMateriaCad_ItemCheck;
            }
        }
        private void listMateriaCad_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listMateriaCad.Items.Count; i++)
            {
                listMateriaCad.ItemChecked -= listMateriaCad_ItemChecked;
                listMateriaCad.ItemCheck -= listMateriaCad_ItemCheck;
                listMateriaCad.Items[i].Checked = listMateriaCad.Items[i].Selected;
                listMateriaCad.ItemChecked += listMateriaCad_ItemChecked;
                listMateriaCad.ItemCheck += listMateriaCad_ItemCheck;
            }
        }
        private void listMateriaCad_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listMateriaCad.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listMateriaCad.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listMateriaCad.Items[e.Index]) e.NewValue = CheckState.Checked;
        }

        private void listEmbaCad_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listEmbaCad.Items.Count; i++)
            {
                listEmbaCad.ItemSelectionChanged -= listEmbaCad_ItemSelectionChanged;
                listEmbaCad.ItemCheck -= listEmbaCad_ItemCheck;
                listEmbaCad.Items[i].Selected = listEmbaCad.Items[i].Checked;
                listEmbaCad.ItemSelectionChanged += listEmbaCad_ItemSelectionChanged;
                listEmbaCad.ItemCheck += listEmbaCad_ItemCheck;
            }
        }
        private void listEmbaCad_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listEmbaCad.Items.Count; i++)
            {
                listEmbaCad.ItemChecked -= listEmbaCad_ItemChecked;
                listEmbaCad.ItemCheck -= listEmbaCad_ItemCheck;
                listEmbaCad.Items[i].Checked = listEmbaCad.Items[i].Selected;
                listEmbaCad.ItemChecked += listEmbaCad_ItemChecked;
                listEmbaCad.ItemCheck += listEmbaCad_ItemCheck;
            }
        }
        private void listEmbaCad_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listEmbaCad.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listEmbaCad.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listEmbaCad.Items[e.Index]) e.NewValue = CheckState.Checked;
        }


        //CAIXA DE TEXTO
        private void txtProced_Click(object sender, EventArgs e)
        {
            if (txtProced.Text == "Escreva aqui...")
            {
                txtProced.Clear();
                txtProced.ForeColor = Color.Black;
            }
        }


        //CAIXAS DE TEXTO NUMERICAS
        private void txtQuantidadeMinima_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPIS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCOFINS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQtEmba_KeyPress(object sender, KeyPressEventArgs e)
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


        //CONFIGURACOES DE TIPO DE PRODUTO
        private void cbTipoDeItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDeItem.Text == "Embalagem")
            {
                cbDescrGrupo.Text = "";
                txtInicio.Enabled = false;
                lblInicio.Enabled = false;
                txtFinal.Enabled = false;
                lblFinal.Enabled = false;
                grpbGrupoDeProdutos.Enabled = true;
                cbDescrGrupo.Items.Clear();
                cbDescrGrupo.Items.AddRange(new string[] { "Tampa e Válvula", "Caixa de Embarque", "Frasco", "Rótulo", "Outros", "" });
                grpbUnidadeDeMedida.Enabled = true;

            }
            if(cbTipoDeItem.Text == "Matéria Prima")
            {
                cbDescrGrupo.Text = "";
                txtInicio.Enabled = false;
                lblInicio.Enabled = false;
                txtFinal.Enabled = false;
                lblFinal.Enabled = false;
                grpbGrupoDeProdutos.Enabled = true;
                cbDescrGrupo.Items.Clear();
                cbDescrGrupo.Items.AddRange(new string[] { "Ativos", "Ativos Secundários", "Corantes", "Essencias", "Outros", "" });
                grpbUnidadeDeMedida.Enabled = true;

            }
            if(cbTipoDeItem.Text == "Produto Acabado")
            {
                cbDescrGrupo.Text = "";
                txtInicio.Enabled = true;
                lblInicio.Enabled = true;
                txtFinal.Enabled = true;
                lblFinal.Enabled = true;
                grpbGrupoDeProdutos.Enabled = true;
                cbDescrGrupo.Items.Clear();
                cbDescrGrupo.Items.AddRange(new string[] { "Coloração", "Descoloração", "Higiene", "Oxidantes", "Outros", "" });
                grpbCodigoB.Enabled = true;
                grpbQtUn.Enabled = true;
                grpbUnidadeDeMedida.Enabled = true;
                tabControl2.Enabled = true;
            }
            else
            {
                grpbCodigoB.Enabled = false;
                tabControl2.Enabled = false;
            }
        }

        private void txtNomeDesc_TextChanged(object sender, EventArgs e)
        {
            int jj = txtNomeDesc.Text.Length;
            if (jj >= 1)
            {
                grpbOrigem.Enabled = true;
            }
            else
            {
                grpbOrigem.Enabled = false;
            }
        }


        //BOTOES
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbNomeMat.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome da Matéria Prima.");
            }
            else
            {
                if (string.IsNullOrEmpty(comboUnidadeMat.Text))
                {
                    MessageBox.Show("Por Favor, Informe a Unidade da Matéria Prima.");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtQuantidadeMat.Text))
                    {
                        MessageBox.Show("Por Favor, Infome a Quantidade Unitária da Matéria Prima");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new[] {cbNomeMat.Text,
                        comboUnidadeMat.Text, txtQuantidadeMat.Text});
                        listMateriaCad.Items.Add(item);
                        cbNomeMat.Text        = "";
                        comboUnidadeMat.Text  = "";
                        txtQuantidadeMat.Text = "";
                    }
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            

            for (int j = 0; j < listMateriaCad.Items.Count; j++)
            {
                if (listMateriaCad.Items[j].Selected)
                {
                    string Nome = listMateriaCad.Items[0].SubItems[0].Text;
                    cbNomeMat.Text = Nome;
                    string Especie = listMateriaCad.Items[0].SubItems[1].Text;
                    comboUnidadeMat.Text = Especie;
                    string Quantidade = listMateriaCad.Items[0].SubItems[2].Text;
                    txtQuantidadeMat.Text = Quantidade;

                    for (int i = 0; i < listMateriaCad.Items.Count; i++)
                    {
                        if (listMateriaCad.Items[i].Selected)
                        {
                            listMateriaCad.Items[i].Remove();
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
            for (int i = 0; i < listMateriaCad.Items.Count; i++)
            {
                if (listMateriaCad.Items[i].Selected)
                {
                  listMateriaCad.Items[i].Remove();

                }
            }
        }

        private void btAdicionarEmba_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbNomeEmba.Text))
            {
                MessageBox.Show("Por Favor, Informe o Nome da Embalagem.");
            }
            else
            {
                if (string.IsNullOrEmpty(comboUnidadeEmba.Text))
                {
                    MessageBox.Show("Por Favor, Informe a Unidade da Embalagem.");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtQtEmba.Text))
                    {
                        MessageBox.Show("Por Favor, Infome a Quantidade Unitária da Embalagem");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new[] {cbNomeEmba.Text,
                        comboUnidadeEmba.Text, txtQtEmba.Text});
                        listEmbaCad.Items.Add(item);
                        cbNomeEmba.Text       = "";
                        comboUnidadeEmba.Text = "";
                        txtQtEmba.Text        = "";
                    }
                }
            }
        }

        private void btEditarEmba_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();


            for (int j = 0; j < listMateriaCad.Items.Count; j++)
            {
                if (listEmbaCad.Items[1].Selected)
                {
                    string Nome = listEmbaCad.Items[0].SubItems[0].Text;
                    cbNomeEmba.Text = Nome;
                    string Especie = listEmbaCad.Items[0].SubItems[1].Text;
                    comboUnidadeEmba.Text = Especie;
                    string Quantidade = listEmbaCad.Items[0].SubItems[2].Text;
                    txtQtEmba.Text = Quantidade;

                    for (int i = 0; i < listEmbaCad.Items.Count; i++)
                    {
                        if (listEmbaCad.Items[i].Selected)
                        {
                            listEmbaCad.Items[i].Remove();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Não Há Nenhum Item Selecionado.");

                }
            }
        }

        private void btRemoverEmba_Click(object sender, EventArgs e)
        {
            ListView lista = new ListView();
            for (int i = 0; i < listEmbaCad.Items.Count; i++)
            {
                if (listEmbaCad.Items[i].Selected)
                {
                    listEmbaCad.Items[i].Remove();

                }
            }
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
                foreach (Control control in controls)
                    if (control is GroupBox)
                        (control as GroupBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            listMateriaCad.Items.Clear();
            listEmbaCad.Items.Clear();

           

            tabControl2.Enabled = false;
            func(Controls);
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            //CODIGO AQUI, ACIMA
            if (!string.IsNullOrEmpty(txtNomeDesc.Text))
            {
                lblSalvo.Visible = true;
                await Task.Delay(3000);
                lblSalvo.Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor, indique o nome do produto a ser cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
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

        private void pbRemoverMat_MouseEnter(object sender, EventArgs e)
        {
            pbRemoverMat.Image = imagem_mouse;
            lblRemoverMat.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbRemoverMat_MouseLeave(object sender, EventArgs e)
        {
            pbRemoverMat.Image = imagem_normal;
            lblRemoverMat.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbAdicionarEmba_MouseEnter(object sender, EventArgs e)
        {
            pbAdicionarEmba.Image = imagem_mouse;
            lblAdicionarEmba.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbAdicionarEmba_MouseLeave(object sender, EventArgs e)
        {
            pbAdicionarEmba.Image = imagem_normal;
            lblAdicionarEmba.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbEditarEmba_MouseEnter(object sender, EventArgs e)
        {
            pbEditarEmba.Image = imagem_mouse;
            lblEditarEmba.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbEditarEmba_MouseLeave(object sender, EventArgs e)
        {
            pbEditarEmba.Image = imagem_normal;
            lblEditarEmba.BackColor = Color.FromArgb(235, 239, 243);
        }

        private void pbRemoverEmba_MouseEnter(object sender, EventArgs e)
        {
            pbRemoverEmba.Image = imagem_mouse;
            lblRemoverEmba.BackColor = Color.FromArgb(210, 219, 227);
        }
        private void pbRemoverEmba_MouseLeave(object sender, EventArgs e)
        {
            pbRemoverEmba.Image = imagem_normal;
            lblRemoverEmba.BackColor = Color.FromArgb(235, 239, 243);
        }

        
    }
}
