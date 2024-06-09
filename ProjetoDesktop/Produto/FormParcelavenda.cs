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
    public partial class FormParcelavenda : Form
    {
        public FormParcelavenda()
        {
            InitializeComponent();
        }

        private void FormParcelavenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.situacao);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.PARCELAVENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.pARCELAVENDATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.PARCELAVENDA);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_PARCELAVENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_PARCELAVENDATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_PARCELAVENDA);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            pARCELAVENDABindingSource.MoveFirst();
            dADOS_PARCELAVENDABindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            pARCELAVENDABindingSource.MovePrevious();
            dADOS_PARCELAVENDABindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pARCELAVENDABindingSource.MoveLast();
            dADOS_PARCELAVENDABindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            pARCELAVENDABindingSource.MoveNext();
            dADOS_PARCELAVENDABindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELAVENDABindingSource.RemoveCurrent();

                pARCELAVENDABindingSource.EndEdit();
                pARCELAVENDATableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_PARCELAVENDATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PARCELAVENDA);

                pARCELAVENDABindingSource.MoveLast();
                dADOS_PARCELAVENDABindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELAVENDABindingSource.EndEdit();
                pARCELAVENDATableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_PARCELAVENDATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PARCELAVENDA);

                pARCELAVENDABindingSource.MoveLast();
                dADOS_PARCELAVENDABindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pARCELAVENDABindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pARCELAVENDABindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSituacao formSituacao = new FormSituacao();
            formSituacao.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendaproduto formVendaproduto = new FormVendaproduto();
            formVendaproduto.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_PARCELAVENDATableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_PARCELAVENDA, textBox1.Text + "%");

        }
    }
}
