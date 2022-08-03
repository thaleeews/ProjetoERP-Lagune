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
    public partial class FrmCadastroFornecedores : Form
    {
        public FrmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void txtCEPForn_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mtxtCEPForn_Click(object sender, EventArgs e)
        {
            mtxtCEPForn.SelectionStart = 0;
        }

        private void mtxtCNPJForn_Click(object sender, EventArgs e)
        {
            mtxtCNPJForn.SelectionStart = 0;
        }

        private void mtxtTelForn_Click(object sender, EventArgs e)
        {
            mtxtTelForn.SelectionStart = 0;
        }

        private void mtxtCelForn_Click(object sender, EventArgs e)
        {
            mtxtCelForn.SelectionStart = 0;
        }
    }
}
