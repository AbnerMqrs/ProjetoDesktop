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
    public partial class FormItenscompraproduto : Form
    {
        public FormItenscompraproduto()
        {
            InitializeComponent();
        }

        private void FormItenscompraproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itenscompraproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.itenscompraprodutoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itenscompraproduto);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSCOMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSCOMPRAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSCOMPRAPRODUTO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveFirst();
            dADOS_ITENSCOMPRAPRODUTOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MovePrevious();
            dADOS_ITENSCOMPRAPRODUTOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveLast();
            dADOS_ITENSCOMPRAPRODUTOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.MoveNext();
            dADOS_ITENSCOMPRAPRODUTOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenscompraprodutoBindingSource.RemoveCurrent();

                itenscompraprodutoBindingSource.EndEdit();
                itenscompraprodutoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_ITENSCOMPRAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSCOMPRAPRODUTO);

                itenscompraprodutoBindingSource.MoveLast();
                dADOS_ITENSCOMPRAPRODUTOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenscompraprodutoBindingSource.EndEdit();
                itenscompraprodutoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_ITENSCOMPRAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSCOMPRAPRODUTO);

                itenscompraprodutoBindingSource.MoveLast();
                dADOS_ITENSCOMPRAPRODUTOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itenscompraprodutoBindingSource.CancelEdit();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenscompraprodutoBindingSource.AddNew();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCompraproduto formCompraproduto = new FormCompraproduto();
            formCompraproduto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_ITENSCOMPRAPRODUTOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_ITENSCOMPRAPRODUTO, textBox1.Text + "%");

        }
    }
}
