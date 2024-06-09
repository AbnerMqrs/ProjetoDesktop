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
    public partial class FormCep : Form
    {
        public FormCep()
        {
            InitializeComponent();
        }

        private void FormCep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cep);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cepBindingSource.EndEdit();
                cepTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir um novo Sexo?", "Inserir Sexo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cepBindingSource.RemoveCurrent();

                cepBindingSource.EndEdit();
                cepTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            cepBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cepBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cepBindingSource.AddNew();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cepTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.cep, textBox1.Text + "%");
        }
    }
}
