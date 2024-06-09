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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.marca'. Você pode movê-la ou removê-la conforme necessário.
            this.marcaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.marca);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.EndEdit();
                marcaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.RemoveCurrent();

                marcaBindingSource.EndEdit();
                marcaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            marcaBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            marcaBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            marcaTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.marca, textBox1.Text + "%");
        }
    }
}
