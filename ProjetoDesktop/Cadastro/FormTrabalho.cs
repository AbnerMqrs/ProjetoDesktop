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
    public partial class FormTrabalho : Form
    {
        public FormTrabalho()
        {
            InitializeComponent();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveFirst();

        }

        private void FormTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.trabalho);

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveLast();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MovePrevious();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveNext();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trabalhoBindingSource.RemoveCurrent();

                trabalhoBindingSource.EndEdit();
                trabalhoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trabalhoBindingSource.EndEdit();
                trabalhoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trabalhoBindingSource.AddNew();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            trabalhoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.trabalho, textBox1.Text + "%");
        }
    }
}
