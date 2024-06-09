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
    public partial class FormRua : Form
    {
        public FormRua()
        {
            InitializeComponent();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveFirst();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ruaBindingSource.RemoveCurrent();

                ruaBindingSource.EndEdit();
                ruaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void FormRua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.rua);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ruaBindingSource.EndEdit();
                ruaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ruaBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ruaBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ruaTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.rua, textBox1.Text + "%");
        }
    }
}
