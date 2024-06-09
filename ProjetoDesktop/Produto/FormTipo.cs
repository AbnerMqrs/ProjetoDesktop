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
    public partial class FormTipo : Form
    {
        public FormTipo()
        {
            InitializeComponent();
        }

        private void FormTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.tipo);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            tipoBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipoBindingSource.EndEdit();
                tipoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipoBindingSource.RemoveCurrent();

                tipoBindingSource.EndEdit();
                tipoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tipoBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            tipoBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            tipoBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipoBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            tipoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.tipo, textBox1.Text + "%");

        }
    }
}
