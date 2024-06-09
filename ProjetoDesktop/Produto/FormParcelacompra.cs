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
    public partial class FormParcelacompra : Form
    {
        public FormParcelacompra()
        {
            InitializeComponent();
        }

        private void FormParcelacompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.situacao);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.PARCELACOMPRA'. Você pode movê-la ou removê-la conforme necessário.
            this.pARCELACOMPRATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.PARCELACOMPRA);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_PARCELACOMPRA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_PARCELACOMPRATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_PARCELACOMPRA);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            pARCELACOMPRABindingSource.MoveFirst();
            dADOS_PARCELACOMPRABindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            pARCELACOMPRABindingSource.MovePrevious();
            dADOS_PARCELACOMPRABindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pARCELACOMPRABindingSource.MoveLast();
            dADOS_PARCELACOMPRABindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            pARCELACOMPRABindingSource.MoveNext();
            dADOS_PARCELACOMPRABindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELACOMPRABindingSource.RemoveCurrent();

                pARCELACOMPRABindingSource.EndEdit();
                pARCELACOMPRATableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_PARCELACOMPRATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PARCELACOMPRA);

                pARCELACOMPRABindingSource.MoveLast();
                dADOS_PARCELACOMPRABindingSource.MoveLast();

            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELACOMPRABindingSource.EndEdit();
                pARCELACOMPRATableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_PARCELACOMPRATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PARCELACOMPRA);

                pARCELACOMPRABindingSource.MoveLast();
                dADOS_PARCELACOMPRABindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pARCELACOMPRABindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELACOMPRABindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSituacao formSituacao = new FormSituacao();
            formSituacao.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCompraproduto formCompra = new FormCompraproduto();
            formCompra.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_PARCELACOMPRATableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_PARCELACOMPRA, textBox1.Text + "%");

        }
    }
}
