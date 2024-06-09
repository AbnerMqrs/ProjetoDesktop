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
    public partial class FormFuncao : Form
    {
        public FormFuncao()
        {
            InitializeComponent();
        }


        private void FormFuncao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcao);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcaoBindingSource.RemoveCurrent();

                funcaoBindingSource.EndEdit();
                funcaoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcaoBindingSource.EndEdit();
                funcaoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcaoBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            funcaoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.funcao, textBox1.Text + "%");
        }
    }
}
