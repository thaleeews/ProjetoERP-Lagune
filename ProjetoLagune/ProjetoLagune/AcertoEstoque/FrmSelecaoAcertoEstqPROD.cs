using ProjetoLagune.AcertoEstoque;
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
    public partial class FrmSelecaoAcertoEstqPROD : Form
    {
        public FrmSelecaoAcertoEstqPROD()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            FrmAcertoEstMateriaP frmmateriaprima = new FrmAcertoEstMateriaP();
            FrmAcertoEstEmbal frmembalagem = new FrmAcertoEstEmbal();
            FrmAcertoEstProdutoAcabado frmproduto = new FrmAcertoEstProdutoAcabado();
            FrmSelecaoAcertoEstqPROD frmselecao = new FrmSelecaoAcertoEstqPROD();
            if(rdbMateriaPrima.Checked)
            {
                this.Hide();
                frmmateriaprima.ShowDialog();
                Close();
            }
            if(rdbEmbalagem.Checked)
            {
                this.Hide();
                frmembalagem.ShowDialog();
                Close();
            }
            if(rdbProdutoAcabado.Checked)
            {
                this.Hide();
                frmproduto.ShowDialog();
                Close();
            }
            
        }
    }
}
