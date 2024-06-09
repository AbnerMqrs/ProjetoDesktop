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
    public partial class FormCompraproduto : Form
    {
        public FormCompraproduto()
        {
            InitializeComponent();
        }

        private void FormCompraproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_COMPRAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_COMPRAPRODUTO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            cOMPRAPRODUTOBindingSource.MoveFirst();
            dADOS_COMPRAPRODUTOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            cOMPRAPRODUTOBindingSource.MovePrevious();
            dADOS_COMPRAPRODUTOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cOMPRAPRODUTOBindingSource.MoveLast();
            dADOS_COMPRAPRODUTOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            cOMPRAPRODUTOBindingSource.MoveNext();
            dADOS_COMPRAPRODUTOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cOMPRAPRODUTOBindingSource.RemoveCurrent();

                cOMPRAPRODUTOBindingSource.EndEdit();
                cOMPRAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_COMPRAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_COMPRAPRODUTO);

                cOMPRAPRODUTOBindingSource.MoveLast();
                dADOS_COMPRAPRODUTOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cOMPRAPRODUTOBindingSource.EndEdit();
                cOMPRAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_COMPRAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_COMPRAPRODUTO);

                cOMPRAPRODUTOBindingSource.MoveLast();
                dADOS_COMPRAPRODUTOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cOMPRAPRODUTOBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cOMPRAPRODUTOBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_COMPRAPRODUTOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_COMPRAPRODUTO, textBox1.Text + "%");
        }
    }
}
