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
    public partial class FormSituacao : Form
    {
        public FormSituacao()
        {
            InitializeComponent();
        }

        private void FormSituacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.situacao);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                situacaoBindingSource.EndEdit();
                situacaoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                situacaoBindingSource.RemoveCurrent();

                situacaoBindingSource.EndEdit();
                situacaoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveNext();

        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MovePrevious();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.MoveLast();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            situacaoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               situacaoBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            situacaoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.situacao, textBox1.Text + "%");

        }
    }
}
