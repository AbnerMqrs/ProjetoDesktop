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
    public partial class FormUf : Form
    {
        public FormUf()
        {
            InitializeComponent();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveFirst();
        }

        private void FormUf_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.uf'. Você pode movê-la ou removê-la conforme necessário.
            this.ufTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.uf);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ufTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.uf, textBox1.Text + "%");
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            ufBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ufBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.RemoveCurrent();

                ufBindingSource.EndEdit();
                ufTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.EndEdit();
                ufTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ufBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ufBindingSource.AddNew();
            }

        }
    }
}
