using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLagune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeMatériaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProdutos frmprodutos = new FrmCadastroProdutos();
            frmprodutos.ShowDialog();


        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedores frmfornecedores = new FrmCadastroFornecedores();
            frmfornecedores.ShowDialog();

        }
    }
}
