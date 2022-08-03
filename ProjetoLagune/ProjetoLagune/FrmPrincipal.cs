using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLagune.Pedidos;
using ProjetoLagune.EntradaNotaFiscal;
using ProjetoLagune.CadastroClientes;
using ProjetoLagune.Vendas;
using ProjetoLagune.Cadastros.CadastroProdutos;
using ProjetoLagune.Producao.OrdemProducao;
using ProjetoLagune.Financas;
using ProjetoLagune.EntradasSaidas.SaidaNotaFiscal;
using ProjetoLagune.EntradasSaidas.AcompanhamentoCarga;
using ProjetoLagune.Estoque;
using ProjetoLagune.Estoque.Transferencia;
using ProjetoLagune.Vendas.Orcamento;
using ProjetoLagune.Cadastros.CadastroUsuario;
using ProjetoLagune.Producao.OrdemEnvase;
using ProjetoLagune.Financas.ContasPagas;
using ProjetoLagune.Financas.Estimativas;
using ProjetoLagune.Financas.ControleCheques;
using ProjetoLagune.Financas.ControleBancario;
using ProjetoLagune.Producao.PosProducao;
using ProjetoLagune.Cadastros.CadastroTransp;
using ProjetoLagune.Registros;
using ProjetoLagune.Producao.PosEnvase;
using ProjetoLagune.Vendas.CancelarOuAlterar;

using System.Runtime.InteropServices;

namespace ProjetoLagune
{
    public partial class FrmPrincipal : Form
    {
        string pasta_botoes = "";
        Image imagem_normalsair;
        Image imagem_mousesair;
        Image imagem_normalcancelar;
        Image imagem_mousecancelar;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pasta_botoes = Application.StartupPath + @"\Botoes\Botoes Planos\";
            imagem_normalsair = Image.FromFile(pasta_botoes + "botaoplanosairsim.png");
            imagem_mousesair = Image.FromFile(pasta_botoes + "botaoplanosairsimmouse.png");
            imagem_normalcancelar = Image.FromFile(pasta_botoes + "botaoplanosaircancelar.png");
            imagem_mousecancelar = Image.FromFile(pasta_botoes + "botaoplanosaircancelarmouse.png");
            
        }
        




        //TOOL STRIPS
        private void cadastroDeMatériaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroProdutos frmprod = new FrmCadastroProdutos();
            frmprod.ShowDialog();
            Show();
        }
        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroFornecedores frmfornecedores = new FrmCadastroFornecedores();
            frmfornecedores.ShowDialog();
            Show();

        }
        private void acertoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAcertoEst acerto = new FrmAcertoEst();
            acerto.ShowDialog();
            Show();

        }
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPedidos frmped = new FrmPedidos();
            frmped.ShowDialog();
            Show();
        }
        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmEntradaNota frmentra = new FrmEntradaNota();
            frmentra.ShowDialog();
            Show();
        }
        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroClientes frmclientes = new FrmCadastroClientes();
            frmclientes.ShowDialog();
            Show();
            
        }
        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNovoPedido frmvenda = new FrmNovoPedido();
            frmvenda.ShowDialog();
            Show();
        }
        private void ordemDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmOrdemProducao frmproduz = new FrmOrdemProducao();
            frmproduz.ShowDialog();
            Show();
        }
        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDespesas frmdesp = new FrmDespesas();
            frmdesp.ShowDialog();
            Show();
        }
        private void saídaDeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSaidaNota f = new FrmSaidaNota();
            f.ShowDialog();
            Show();
        }
        private void acompanhamentoDeCargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAcompanha a = new FrmAcompanha();
            a.ShowDialog();
            Show();
        }
        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAprovar t = new FrmAprovar();
            t.ShowDialog();
            Show();
        }
        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmOrcamento o = new FrmOrcamento();
            o.ShowDialog();
            Show();
        }
        private void ordemDeEnvaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmOrdemEnvase env = new FrmOrdemEnvase();
            env.ShowDialog();
            Show();
        }
        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroUsuario usu = new FrmCadastroUsuario();
            usu.ShowDialog();
            Show();
        }
        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmContasAReceber rece = new FrmContasAReceber();
            rece.ShowDialog();
            Show();
        }
        private void contasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmContasPagas pagas = new FrmContasPagas();
            pagas.ShowDialog();
            Show();
        }
        private void estimativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmEstimativas est = new FrmEstimativas();
            est.ShowDialog();
            Show();
        }
        private void controleDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmControleCheques cheq = new FrmControleCheques();
            cheq.ShowDialog();
            Show();
        }
        private void controleBancárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmControleBancario banco = new FrmControleBancario();
            banco.ShowDialog();
            Show();
        }
        private void pósProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPosProducao produ = new FrmPosProducao();
            produ.ShowDialog();
            Show();
        }
        private void cadastroDeTransportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTransp t = new FrmTransp();
            t.ShowDialog();
            Show();
        }
        private void transportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRegTransp reg = new FrmRegTransp();
            reg.ShowDialog();
            Show();
        }
        private void pósEnvaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPosEnvase env = new FrmPosEnvase();
            env.ShowDialog();
            Show();
        }
        private void cancelarOuAlterarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCancelarOuAlterar can = new FrmCancelarOuAlterar();
            can.ShowDialog();
            Show();
        }

        //BOTOES MINIMIZAR E FECHAR
        private void btX_Click(object sender, EventArgs e)
        {
            if (pbSair.Visible == false)
            {
                btX.BackColor = Color.FromArgb(210, 219, 227);
                btMin.BackColor = Color.FromArgb(210, 219, 227);
                this.BackColor = Color.FromArgb(210, 219, 227);
                lblConfig.BackColor = Color.FromArgb(210, 219, 227);
                lblConfig1.BackColor = Color.FromArgb(210, 219, 227);
                lblConfig2.BackColor = Color.FromArgb(210, 219, 227);
                lblConfig3.BackColor = Color.FromArgb(210, 219, 227);
                lblConfig4.BackColor = Color.FromArgb(210, 219, 227);
                lblAtalhosRapidos.BackColor = Color.FromArgb(210, 219, 227);


                menuStrip1.Enabled = false;
                lblConfig.Enabled = false;
                lblConfig1.Enabled = false;
                lblConfig2.Enabled = false;
                lblConfig3.Enabled = false;
                lblConfig4.Enabled = false;

                pSair.Location = new Point(494, 164);
                pSair.Size = new Size(0, 186);
                pSair.Visible = true;


                int loc = 492;
                int size = 4;
                int i = 0;

                while (i < 247)
                {
                    pSair.Location = new Point(loc, 164);
                    pSair.Size = new Size(size, 186);
                    loc -= 2;
                    size += 4;
                    i++;
                }
                lblsaindo.Visible = true;
                lblCancelar.Visible = true;
                lblSair.Visible = true;
                pbCancelar.Visible = true;
                pbSair.Visible = true;
            }
            




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


        //BOTOES SAIR E CANCELAR
        private void btSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal pri = new FrmPrincipal();
            int loc = 2;
            int size = 984;
            int i = 0;

            lblsaindo.Visible = false;
            lblCancelar.Visible = false;
            lblSair.Visible = false;
            pbCancelar.Visible = false;
            pbSair.Visible = false;

            

            btX.BackColor = Color.FromArgb(235, 239, 243);
            btMin.BackColor = Color.FromArgb(235, 239, 243);
            this.BackColor = Color.FromArgb(235, 239, 243);
            lblConfig.BackColor = Color.FromArgb(235, 239, 243);
            lblConfig1.BackColor = Color.FromArgb(235, 239, 243);
            lblConfig2.BackColor = Color.FromArgb(235, 239, 243);
            lblConfig3.BackColor = Color.FromArgb(235, 239, 243);
            lblConfig4.BackColor = Color.FromArgb(235, 239, 243);
            lblAtalhosRapidos.BackColor = Color.FromArgb(235, 239, 243);
            

            while (i < 247)
            {
                pSair.Location = new Point(loc, 164);
                pSair.Size = new Size(size, 186);
                loc += 2;
                size -= 4;
                i++;
            }
            
            pSair.Visible = false;
            menuStrip1.Enabled = true;
            lblConfig.Enabled = true;
            lblConfig1.Enabled = true;
            lblConfig2.Enabled = true;
            lblConfig3.Enabled = true;
            lblConfig4.Enabled = true;
        }


        //PASSAGEM DE TEXT PARA OS LABELS
        private void lblConfig_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConfig config = new FrmConfig();
            config.ShowDialog();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            labelbemvindo.Text = "> Bem Vindo(a), " + FrmValidar.SetValueForText1;
            lblConfig1.Text = FrmConfig.Config1;
            lblConfig2.Text = FrmConfig.Config2;
            lblConfig3.Text = FrmConfig.Config3;
            lblConfig4.Text = FrmConfig.Config4;
            if(FrmValidar.SetValueForText1 == "Rafael")
            {
                finançasToolStripMenuItem.Visible = false;
            }
            

        }


        //APARENCIA DOS LABELS
        private void lblConfig1_MouseEnter(object sender, EventArgs e)
        {
            lblConfig1.Font = new Font(lblConfig1.Font, FontStyle.Underline | FontStyle.Regular);
        }
        private void lblConfig1_MouseLeave(object sender, EventArgs e)
        {
            lblConfig1.Font = new Font(lblConfig1.Font, FontStyle.Regular);
        }
        private void lblConfig2_MouseEnter(object sender, EventArgs e)
        {
            lblConfig2.Font = new Font(lblConfig2.Font, FontStyle.Underline | FontStyle.Regular);
        }
        private void lblConfig2_MouseLeave(object sender, EventArgs e)
        {
            lblConfig2.Font = new Font(lblConfig1.Font, FontStyle.Regular);
        }
        private void lblConfig3_MouseEnter(object sender, EventArgs e)
        {
            lblConfig3.Font = new Font(lblConfig3.Font, FontStyle.Underline | FontStyle.Regular);
        }
        private void lblConfig3_MouseLeave(object sender, EventArgs e)
        {
            lblConfig3.Font = new Font(lblConfig1.Font, FontStyle.Regular);
        }
        private void lblConfig4_MouseEnter(object sender, EventArgs e)
        {
            lblConfig4.Font = new Font(lblConfig4.Font, FontStyle.Underline | FontStyle.Regular);
        }
        private void lblConfig4_MouseLeave(object sender, EventArgs e)
        {
            lblConfig4.Font = new Font(lblConfig1.Font, FontStyle.Regular);
        }
        private void lblConfig_MouseEnter(object sender, EventArgs e)
        {
            
            lblConfig.Font = new Font("BigNoodleTitling", 20, FontStyle.Italic);
        }
        private void lblConfig_MouseLeave(object sender, EventArgs e)
        {
            lblConfig.Font = new Font("BigNoodleTitling", 15, FontStyle.Italic);
        }


        //CONFIGURACAO DOS CLIQUES DOS ATALHOS 
        private void lblConfig1_Click(object sender, EventArgs e)
        {
            if(lblConfig1.Text == "Cadastro de Produtos")
            {
                Hide();
                FrmCadastroProdutos prod = new FrmCadastroProdutos();
                prod.ShowDialog();
                Show();
            }
            if(lblConfig1.Text == "Cadastro de Fornecedores")
            {
                Hide();
                FrmCadastroFornecedores fornecedor = new FrmCadastroFornecedores();
                fornecedor.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Cadastro de Clientes")
            {
                Hide();
                FrmCadastroClientes cliente = new FrmCadastroClientes();
                cliente.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Cadastro de Usuários")
            {
                Hide();
                FrmCadastroUsuario usuario = new FrmCadastroUsuario();
                usuario.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Entrada de Nota Fiscal")
            {
                Hide();
                FrmEntradaNota notae = new FrmEntradaNota();
                notae.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Saída de Nota Fiscal")
            {
                Hide();
                FrmSaidaNota notas = new FrmSaidaNota();
                notas.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Acompanhamento de Carga")
            {
                Hide();
                FrmAcompanha carga = new FrmAcompanha();
                carga.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Acerto de Estoque")
            {
                Hide();
                FrmAcertoEst estoque = new FrmAcertoEst();
                estoque.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Transferência")
            {
                Hide();
                FrmAprovar transf = new FrmAprovar();
                transf.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Ordem de Produção")
            {
                Hide();
                FrmOrdemProducao prod = new FrmOrdemProducao();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Ordem de Envase")
            {
                MessageBox.Show("Boa");
            }
            if (lblConfig1.Text == "Novo Pedido de Compra")
            {
                Hide();
                FrmPedidos ped = new FrmPedidos();
                ped.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Orçamento")
            {
                Hide();
                FrmOrcamento orca = new FrmOrcamento();
                orca.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Novo Pedido")
            {
                Hide();
                FrmNovoPedido novo = new FrmNovoPedido();
                novo.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "Despesas")
            {
                Hide();
                FrmDespesas desp = new FrmDespesas();
                desp.ShowDialog();
                Show();
            }
            if (lblConfig1.Text == "")
            {
                
            }
        }
        private void lblConfig2_Click(object sender, EventArgs e)
        {
            if (lblConfig2.Text == "Cadastro de Produtos")
            {
                Hide();
                FrmCadastroProdutos prod = new FrmCadastroProdutos();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Cadastro de Fornecedores")
            {
                Hide();
                FrmCadastroFornecedores fornecedor = new FrmCadastroFornecedores();
                fornecedor.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Cadastro de Clientes")
            {
                Hide();
                FrmCadastroClientes cliente = new FrmCadastroClientes();
                cliente.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Cadastro de Usuários")
            {
                Hide();
                FrmCadastroUsuario usuario = new FrmCadastroUsuario();
                usuario.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Entrada de Nota Fiscal")
            {
                Hide();
                FrmEntradaNota notae = new FrmEntradaNota();
                notae.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Saída de Nota Fiscal")
            {
                Hide();
                FrmSaidaNota notas = new FrmSaidaNota();
                notas.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Acompanhamento de Carga")
            {
                Hide();
                FrmAcompanha carga = new FrmAcompanha();
                carga.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Acerto de Estoque")
            {
                Hide();
                FrmAcertoEst estoque = new FrmAcertoEst();
                estoque.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Transferência")
            {
                Hide();
                FrmAprovar transf = new FrmAprovar();
                transf.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Ordem de Produção")
            {
                Hide();
                FrmOrdemProducao prod = new FrmOrdemProducao();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Ordem de Envase")
            {
                MessageBox.Show("Boa");
            }
            if (lblConfig2.Text == "Novo Pedido de Compra")
            {
                Hide();
                FrmPedidos ped = new FrmPedidos();
                ped.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Orçamento")
            {
                Hide();
                FrmOrcamento orca = new FrmOrcamento();
                orca.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Novo Pedido")
            {
                Hide();
                FrmNovoPedido novo = new FrmNovoPedido();
                novo.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "Despesas")
            {
                Hide();
                FrmDespesas desp = new FrmDespesas();
                desp.ShowDialog();
                Show();
            }
            if (lblConfig2.Text == "")
            {

            }
        }
        private void lblConfig3_Click(object sender, EventArgs e)
        {
            if (lblConfig3.Text == "Cadastro de Produtos")
            {
                Hide();
                FrmCadastroProdutos prod = new FrmCadastroProdutos();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Cadastro de Fornecedores")
            {
                Hide();
                FrmCadastroFornecedores fornecedor = new FrmCadastroFornecedores();
                fornecedor.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Cadastro de Clientes")
            {
                Hide();
                FrmCadastroClientes cliente = new FrmCadastroClientes();
                cliente.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Cadastro de Usuários")
            {
                Hide();
                FrmCadastroUsuario usuario = new FrmCadastroUsuario();
                usuario.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Entrada de Nota Fiscal")
            {
                Hide();
                FrmEntradaNota notae = new FrmEntradaNota();
                notae.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Saída de Nota Fiscal")
            {
                Hide();
                FrmSaidaNota notas = new FrmSaidaNota();
                notas.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Acompanhamento de Carga")
            {
                Hide();
                FrmAcompanha carga = new FrmAcompanha();
                carga.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Acerto de Estoque")
            {
                Hide();
                FrmAcertoEst estoque = new FrmAcertoEst();
                estoque.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Transferência")
            {
                Hide();
                FrmAprovar transf = new FrmAprovar();
                transf.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Ordem de Produção")
            {
                Hide();
                FrmOrdemProducao prod = new FrmOrdemProducao();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Ordem de Envase")
            {
                MessageBox.Show("Boa");
            }
            if (lblConfig3.Text == "Novo Pedido de Compra")
            {
                Hide();
                FrmPedidos ped = new FrmPedidos();
                ped.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Orçamento")
            {
                Hide();
                FrmOrcamento orca = new FrmOrcamento();
                orca.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Novo Pedido")
            {
                Hide();
                FrmNovoPedido novo = new FrmNovoPedido();
                novo.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "Despesas")
            {
                Hide();
                FrmDespesas desp = new FrmDespesas();
                desp.ShowDialog();
                Show();
            }
            if (lblConfig3.Text == "")
            {

            }
        }
        private void lblConfig4_Click(object sender, EventArgs e)
        {
            if (lblConfig4.Text == "Cadastro de Produtos")
            {
                Hide();
                FrmCadastroProdutos prod = new FrmCadastroProdutos();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Cadastro de Fornecedores")
            {
                Hide();
                FrmCadastroFornecedores fornecedor = new FrmCadastroFornecedores();
                fornecedor.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Cadastro de Clientes")
            {
                Hide();
                FrmCadastroClientes cliente = new FrmCadastroClientes();
                cliente.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Cadastro de Usuários")
            {
                Hide();
                FrmCadastroUsuario usuario = new FrmCadastroUsuario();
                usuario.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Entrada de Nota Fiscal")
            {
                Hide();
                FrmEntradaNota notae = new FrmEntradaNota();
                notae.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Saída de Nota Fiscal")
            {
                Hide();
                FrmSaidaNota notas = new FrmSaidaNota();
                notas.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Acompanhamento de Carga")
            {
                Hide();
                FrmAcompanha carga = new FrmAcompanha();
                carga.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Acerto de Estoque")
            {
                Hide();
                FrmAcertoEst estoque = new FrmAcertoEst();
                estoque.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Transferência")
            {
                Hide();
                FrmAprovar transf = new FrmAprovar();
                transf.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Ordem de Produção")
            {
                Hide();
                FrmOrdemProducao prod = new FrmOrdemProducao();
                prod.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Ordem de Envase")
            {
                MessageBox.Show("Boa");
            }
            if (lblConfig4.Text == "Novo Pedido de Compra")
            {
                Hide();
                FrmPedidos ped = new FrmPedidos();
                ped.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Orçamento")
            {
                Hide();
                FrmOrcamento orca = new FrmOrcamento();
                orca.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Novo Pedido")
            {
                Hide();
                FrmNovoPedido novo = new FrmNovoPedido();
                novo.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "Despesas")
            {
                Hide();
                FrmDespesas desp = new FrmDespesas();
                desp.ShowDialog();
                Show();
            }
            if (lblConfig4.Text == "")
            {

            }
        }


        //APARENCIA DOS BOTOES
        private void pbSair_MouseEnter(object sender, EventArgs e)
        {
            pbSair.Image = imagem_mousesair;
            lblSair.BackColor = Color.FromArgb(112, 80, 42);
        }
        private void pbSair_MouseLeave(object sender, EventArgs e)
        {
            pbSair.Image = imagem_normalsair;
            lblSair.BackColor = Color.FromArgb(187, 130, 52);
        }

        private void pbCancelar_MouseEnter(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_mousecancelar;
            lblCancelar.BackColor = Color.FromArgb(31, 87, 131);
        }
        private void pbCancelar_MouseLeave(object sender, EventArgs e)
        {
            pbCancelar.Image = imagem_normalcancelar;
            lblCancelar.BackColor = Color.FromArgb(45, 140, 204);
        }

        
    }
}
