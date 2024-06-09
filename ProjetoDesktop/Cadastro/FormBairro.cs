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
    public partial class FormBairro : Form
    {
        public FormBairro()
        {
            InitializeComponent();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bairroBindingSource.EndEdit();
                bairroTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagando Dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bairroBindingSource.RemoveCurrent();

                bairroBindingSource.EndEdit();
                bairroTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bairroBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bairroBindingSource.AddNew();
            }
        }


        private void FormBairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.bairro);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            bairroTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.bairro, textBox1.Text + "%");
        }
    }
}
