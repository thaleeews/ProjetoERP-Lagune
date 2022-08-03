using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune.Financas
{
    public partial class FrmContasAReceber : Form
    {
        string pasta_botoes = "";
        Image imagem_normal;
        Image imagem_mouse;


        public FrmContasAReceber()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Botoes Planos\";
            imagem_normal = Image.FromFile(pasta_botoes + "botaoplanofinancas.png");
            imagem_mouse = Image.FromFile(pasta_botoes + "botaoplano.png");
        }


        //CONFIGURACOES DAS LISTVIEW
        private void listBaixarConta_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listBaixarConta.Items.Count; i++)
            {
                listBaixarConta.ItemSelectionChanged -= listBaixarConta_ItemSelectionChanged;
                listBaixarConta.ItemCheck -= listBaixarConta_ItemCheck;
                listBaixarConta.Items[i].Selected = listBaixarConta.Items[i].Checked;
                listBaixarConta.ItemSelectionChanged += listBaixarConta_ItemSelectionChanged;
                listBaixarConta.ItemCheck += listBaixarConta_ItemCheck;
            }
        }
        private void listBaixarConta_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listBaixarConta.Items.Count; i++)
            {
                listBaixarConta.ItemChecked -= listBaixarConta_ItemChecked;
                listBaixarConta.ItemCheck -= listBaixarConta_ItemCheck;
                listBaixarConta.Items[i].Checked = listBaixarConta.Items[i].Selected;
                listBaixarConta.ItemChecked += listBaixarConta_ItemChecked;
                listBaixarConta.ItemCheck += listBaixarConta_ItemCheck;
            }
        }
        private void listBaixarConta_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listBaixarConta.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listBaixarConta.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listBaixarConta.Items[e.Index]) e.NewValue = CheckState.Checked;
        }

        private void listLancarConta_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listLancarConta.Items.Count; i++)
            {
                listLancarConta.ItemSelectionChanged -= listLancarConta_ItemSelectionChanged;
                listLancarConta.ItemCheck -= listLancarConta_ItemCheck;
                listLancarConta.Items[i].Selected = listLancarConta.Items[i].Checked;
                listLancarConta.ItemSelectionChanged += listLancarConta_ItemSelectionChanged;
                listLancarConta.ItemCheck += listLancarConta_ItemCheck;
            }
        }
        private void listLancarConta_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listLancarConta.Items.Count; i++)
            {
                listLancarConta.ItemChecked -= listLancarConta_ItemChecked;
                listLancarConta.ItemCheck -= listLancarConta_ItemCheck;
                listLancarConta.Items[i].Checked = listLancarConta.Items[i].Selected;
                listLancarConta.ItemChecked += listLancarConta_ItemChecked;
                listLancarConta.ItemCheck += listLancarConta_ItemCheck;
            }
        }
        private void listLancarConta_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            Point locaPoint = listLancarConta.PointToClient(MousePosition);
            ListViewItem prevHoverdItem = listLancarConta.GetItemAt(locaPoint.X, locaPoint.Y);
            if (prevHoverdItem == null) return;
            if (prevHoverdItem != listLancarConta.Items[e.Index]) e.NewValue = CheckState.Checked;
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


        //FILTROS
        private void pbJaneiro_Click(object sender, EventArgs e)
        {
            //JANEIRO - SELECIONADO
            pbJaneiro.Image = imagem_mouse;
            lblJaneiro.BackColor = Color.FromArgb(210, 219, 227);
            lblJaneiro.ForeColor = Color.Black;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbFevereiro_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO - SELECIONADO
            pbFevereiro.Image = imagem_mouse;
            lblFevereiro.BackColor = Color.FromArgb(210, 219, 227);
            lblFevereiro.ForeColor = Color.Black;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbMarco_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO 
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO - SELECIONADO
            pbMarco.Image = imagem_mouse;
            lblMarco.BackColor = Color.FromArgb(210, 219, 227);
            lblMarco.ForeColor = Color.Black;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbAbril_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL - SELECIONADO
            pbAbril.Image = imagem_mouse;
            lblAbril.BackColor = Color.FromArgb(210, 219, 227);
            lblAbril.ForeColor = Color.Black;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbMaio_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO - SELECIONADO
            pbMaio.Image = imagem_mouse;
            lblMaio.BackColor = Color.FromArgb(210, 219, 227);
            lblMaio.ForeColor = Color.Black;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbJunho_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO - SELECIONADO
            pbJunho.Image = imagem_mouse;
            lblJunho.BackColor = Color.FromArgb(210, 219, 227);
            lblJunho.ForeColor = Color.Black;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbJulho_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO - SELECIONADO
            pbJulho.Image = imagem_mouse;
            lblJulho.BackColor = Color.FromArgb(210, 219, 227);
            lblJulho.ForeColor = Color.Black;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbAgosto_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO - SELECIONADO
            pbAgosto.Image = imagem_mouse;
            lblAgosto.BackColor = Color.FromArgb(210, 219, 227);
            lblAgosto.ForeColor = Color.Black;
            //SETEMBRO 
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbSetembro_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO - SELECIONADO
            pbSetembro.Image = imagem_mouse;
            lblSetembro.BackColor = Color.FromArgb(210, 219, 227);
            lblSetembro.ForeColor = Color.Black;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbOutubro_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO - SELECIONADO
            pbOutubro.Image = imagem_mouse;
            lblOutubro.BackColor = Color.FromArgb(210, 219, 227);
            lblOutubro.ForeColor = Color.Black;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbNovembro_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO - SELECIONADO
            pbNovembro.Image = imagem_mouse;
            lblNovembro.BackColor = Color.FromArgb(210, 219, 227);
            lblNovembro.ForeColor = Color.Black;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbDezembro_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO - SELECIONADO
            pbDezembro.Image = imagem_mouse;
            lblDezembro.BackColor = Color.FromArgb(210, 219, 227);
            lblDezembro.ForeColor = Color.Black;
            //TODOS
            pbTodos.Image = imagem_normal;
            lblTodos.BackColor = Color.FromArgb(35, 177, 77);
            lblTodos.ForeColor = Color.White;
        }

        private void pbTodos_Click(object sender, EventArgs e)
        {
            //JANEIRO
            pbJaneiro.Image = imagem_normal;
            lblJaneiro.BackColor = Color.FromArgb(35, 177, 77);
            lblJaneiro.ForeColor = Color.White;
            //FEVEREIRO
            pbFevereiro.Image = imagem_normal;
            lblFevereiro.BackColor = Color.FromArgb(35, 177, 77);
            lblFevereiro.ForeColor = Color.White;
            //MARÇO
            pbMarco.Image = imagem_normal;
            lblMarco.BackColor = Color.FromArgb(35, 177, 77);
            lblMarco.ForeColor = Color.White;
            //ABRIL
            pbAbril.Image = imagem_normal;
            lblAbril.BackColor = Color.FromArgb(35, 177, 77);
            lblAbril.ForeColor = Color.White;
            //MAIO
            pbMaio.Image = imagem_normal;
            lblMaio.BackColor = Color.FromArgb(35, 177, 77);
            lblMaio.ForeColor = Color.White;
            //JUNHO
            pbJunho.Image = imagem_normal;
            lblJunho.BackColor = Color.FromArgb(35, 177, 77);
            lblJunho.ForeColor = Color.White;
            //JULHO
            pbJulho.Image = imagem_normal;
            lblJulho.BackColor = Color.FromArgb(35, 177, 77);
            lblJulho.ForeColor = Color.White;
            //AGOSTO
            pbAgosto.Image = imagem_normal;
            lblAgosto.BackColor = Color.FromArgb(35, 177, 77);
            lblAgosto.ForeColor = Color.White;
            //SETEMBRO
            pbSetembro.Image = imagem_normal;
            lblSetembro.BackColor = Color.FromArgb(35, 177, 77);
            lblSetembro.ForeColor = Color.White;
            //OUTUBRO
            pbOutubro.Image = imagem_normal;
            lblOutubro.BackColor = Color.FromArgb(35, 177, 77);
            lblOutubro.ForeColor = Color.White;
            //NOVEMBRO
            pbNovembro.Image = imagem_normal;
            lblNovembro.BackColor = Color.FromArgb(35, 177, 77);
            lblNovembro.ForeColor = Color.White;
            //DEZEMBRO
            pbDezembro.Image = imagem_normal;
            lblDezembro.BackColor = Color.FromArgb(35, 177, 77);
            lblDezembro.ForeColor = Color.White;
            //TODOS - SELECIONADO
            pbTodos.Image = imagem_mouse;
            lblTodos.BackColor = Color.FromArgb(210, 219, 227);
            lblTodos.ForeColor = Color.Black;

        }


        //ATIVACAO DOS FILTROS
        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbJaneiro.Enabled = true;
            lblJaneiro.Enabled = true;

            pbFevereiro.Enabled = true;
            lblFevereiro.Enabled = true;

            pbMarco.Enabled = true;
            lblMarco.Enabled = true;

            pbAbril.Enabled = true;
            lblAbril.Enabled = true;

            pbMaio.Enabled = true;
            lblMaio.Enabled = true;

            pbJunho.Enabled = true;
            lblJunho.Enabled = true;

            pbJulho.Enabled = true;
            lblJulho.Enabled = true;

            pbAgosto.Enabled = true;
            lblAgosto.Enabled = true;

            pbSetembro.Enabled = true;
            lblSetembro.Enabled = true;

            pbOutubro.Enabled = true;
            lblOutubro.Enabled = true;

            pbNovembro.Enabled = true;
            lblNovembro.Enabled = true;

            pbDezembro.Enabled = true;
            lblDezembro.Enabled = true;

            pbTodos.Enabled = true;
            lblTodos.Enabled = true;
        }
    }
}
