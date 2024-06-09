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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.tipo);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.marca);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_PRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_PRODUTO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveFirst();
            dADOS_PRODUTOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MovePrevious();
            dADOS_PRODUTOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveLast();
            dADOS_PRODUTOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            produtoBindingSource.MoveNext();
            dADOS_PRODUTOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBindingSource.RemoveCurrent();

                produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_PRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PRODUTO);

                produtoBindingSource.MoveLast();
                dADOS_PRODUTOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_PRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_PRODUTO);

                produtoBindingSource.MoveLast();
                dADOS_PRODUTOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTipo formTipo = new FormTipo();
            formTipo.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_PRODUTOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_PRODUTO, textBox1.Text + "%");
        }
    }
}
