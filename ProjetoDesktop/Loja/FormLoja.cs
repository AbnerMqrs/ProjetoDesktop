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
    public partial class FormLoja : Form
    {
        public FormLoja()
        {
            InitializeComponent();
        }

        private void FormLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.loja);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            lojaBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.RemoveCurrent();

                lojaBindingSource.EndEdit();
                lojaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.EndEdit();
                lojaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lojaBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaBindingSource.AddNew();
            }


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lojaTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.loja, textBox1.Text + "%");
        }
    }
}
