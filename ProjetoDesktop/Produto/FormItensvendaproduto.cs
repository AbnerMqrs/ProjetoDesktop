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
    public partial class FormItensvendaproduto : Form
    {
        public FormItensvendaproduto()
        {
            InitializeComponent();
        }

        private void FormItensvendaproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.ITENSVENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSVENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.ITENSVENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSVENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSVENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSVENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            iTENSVENDAPRODUTOBindingSource.MoveFirst();
            dADOS_ITENSVENDAPRODUTOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            iTENSVENDAPRODUTOBindingSource.MovePrevious();
            dADOS_ITENSVENDAPRODUTOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            iTENSVENDAPRODUTOBindingSource.MoveLast();
            dADOS_ITENSVENDAPRODUTOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            iTENSVENDAPRODUTOBindingSource.MoveNext();
            dADOS_ITENSVENDAPRODUTOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSVENDAPRODUTOBindingSource.RemoveCurrent();

                iTENSVENDAPRODUTOBindingSource.EndEdit();
                iTENSVENDAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_ITENSVENDAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO);

                iTENSVENDAPRODUTOBindingSource.MoveLast();
                dADOS_ITENSVENDAPRODUTOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSVENDAPRODUTOBindingSource.EndEdit();
                iTENSVENDAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_ITENSVENDAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO);

                iTENSVENDAPRODUTOBindingSource.MoveLast();
                dADOS_ITENSVENDAPRODUTOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iTENSVENDAPRODUTOBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSVENDAPRODUTOBindingSource.AddNew();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendaproduto formVendaproduto = new FormVendaproduto();
            formVendaproduto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_ITENSVENDAPRODUTOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_ITENSVENDAPRODUTO, textBox1.Text + "%");

        }
    }
}
