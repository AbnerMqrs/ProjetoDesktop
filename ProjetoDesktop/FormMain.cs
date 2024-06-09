using ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    public partial class FormMain : Form
    {
        DataTableReader dtr;
        public FormMain(DataTableReader dtr)
        {
            InitializeComponent();
            this.dtr = dtr;

            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    //label5.Text = dtLogins.Rows.Count.ToString() + " Registros";
                    label1.Text = dtr["nomeusuario"].ToString();

                    DataTable dt = dADOS_ITENSACESSOLOGINTableAdapter.GetDataByItensAcessoLogin(label1.Text);
                    DataTableReader dtrAcessoLogin = dt.CreateDataReader();
                    if (dtrAcessoLogin.Read())
                    {
                        label3.Text = dtrAcessoLogin["nomeacesso"].ToString();
                    }

                    if (label3.Text == "CLIENTE")
                    {
                        cadastroToolStripMenuItem.Enabled = false;
                        lojaToolStripMenuItem.Enabled = false;
                        acessoToolStripMenuItem.Enabled = false;
                        produtoToolStripMenuItem.Enabled = false;

                    }
                    if (label3.Text == "FUNCIONARIO")
                    {
                        lojaToolStripMenuItem.Enabled = false;
                        acessoToolStripMenuItem.Enabled = false;
                        produtoToolStripMenuItem.Enabled = false;
                    }
                    if (label3.Text == "ADMINISTRADOR")
                    {
                        acessoToolStripMenuItem.Enabled = false;

                    }
                    if (label3.Text == "VENDEDOR")
                    {
                        cadastroToolStripMenuItem.Enabled = false;
                        acessoToolStripMenuItem.Enabled = false;
                    }
                    //label4.Text = dtr["senha"].ToString();
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Aplicação?",
                   "LojaUnifunec",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Application.Exit();
                System.Environment.Exit(1);


            }
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSexo formSexo = new FormSexo();
            formSexo.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSACESSOLOGINTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSACESSOLOGINTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSACESSOLOGINTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmlogin = new FormLogin();
            frmlogin.ShowDialog();
        }

        private void imagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImagens frmimagens = new FormImagens();
            frmimagens.ShowDialog();
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRua frmimagens = new FormRua();
            frmimagens.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBairro frmbairro = new FormBairro();
            frmbairro.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCep fcep = new FormCep();
            fcep.ShowDialog();
        }

        private void ufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUf uf = new FormUf();
            uf.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidade fcidade = new FormCidade();
            fcidade.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrabalho ftr = new FormTrabalho();
            ftr.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fcliente = new FormCliente();
            fcliente.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTelefone ftr = new FormTelefone();
            ftr.ShowDialog();
        }

        private void operadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOperadora ftr = new FormOperadora();
            ftr.ShowDialog();
        }

        private void itensTelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenstelefonecliente formItenstelefonecliente = new FormItenstelefonecliente();
            formItenstelefonecliente.ShowDialog();
        }

        private void itensTelTrabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenstelefonetrabalho formItenstelefonetrabalho = new FormItenstelefonetrabalho();
            formItenstelefonetrabalho.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void funcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncao formFuncao = new FormFuncao();
            formFuncao.ShowDialog();
        }

        private void itensTelFunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenstelefonefuncionario formItenstelefonefuncionario = new FormItenstelefonefuncionario();
            formItenstelefonefuncionario.ShowDialog();
        }

        private void lojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLoja formLoja = new FormLoja();
            formLoja.ShowDialog();
        }

        private void itensTelLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenstelefoneloja formItenstelefoneloja = new FormItenstelefoneloja();
            formItenstelefoneloja.ShowDialog();
        }

        private void loginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogins formLogins = new FormLogins();
            formLogins.ShowDialog();
        }

        private void controleLogSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControlelogsistema formControlelogsistema = new FormControlelogsistema();
            formControlelogsistema.ShowDialog();
        }

        private void acessoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAcesso formAcesso = new FormAcesso();
            formAcesso.ShowDialog();
        }

        private void itensAcessoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItensacessologin formItensacessologin = new FormItensacessologin();
            formItensacessologin.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipo formTipo = new FormTipo();
            formTipo.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
        }

        private void itensTelFornToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenstelefonefornecedor formItenstelefonefornecedor = new FormItenstelefonefornecedor();
            formItenstelefonefornecedor.ShowDialog();
        }

        private void compraProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompraproduto formCompraproduto = new FormCompraproduto();
            formCompraproduto.ShowDialog();
        }

        private void itensCompraProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItenscompraproduto formItenscompraproduto = new FormItenscompraproduto();
            formItenscompraproduto.ShowDialog();
        }

        private void situacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSituacao formSituacao = new FormSituacao();
            formSituacao.ShowDialog();
        }

        private void parcelaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParcelacompra formParcelacompra = new FormParcelacompra();
            formParcelacompra.ShowDialog();
        }

        private void vendaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendaproduto formVendaproduto = new FormVendaproduto();
            formVendaproduto.ShowDialog();
        }

        private void itensVendProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItensvendaproduto formItensvendaproduto = new FormItensvendaproduto();
            formItensvendaproduto.ShowDialog();
        }

        private void parcelaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParcelavenda formParcelavenda = new FormParcelavenda();
            formParcelavenda.ShowDialog();
        }
    }
}
