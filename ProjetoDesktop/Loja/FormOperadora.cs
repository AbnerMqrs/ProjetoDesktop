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
    public partial class FormOperadora : Form
    {
        public FormOperadora()
        {
            InitializeComponent();
        }

        private void FormOperadora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.operadora);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.operadora);

        }


        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveNext();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.RemoveCurrent();

                operadoraBindingSource.EndEdit();
                operadoraTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.EndEdit();
                operadoraTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operadoraBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            operadoraTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.operadora, textBox1.Text + "%");

        }
    }
}
