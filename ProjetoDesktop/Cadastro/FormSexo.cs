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
    public partial class FormSexo : Form
    {
        public FormSexo()
        {
            InitializeComponent();
        }

        private void FormSexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.sexo);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            sexoBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sexoBindingSource.EndEdit();
                sexoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sexoBindingSource.RemoveCurrent();

                sexoBindingSource.EndEdit();
                sexoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            sexoBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            sexoBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            sexoBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sexoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sexoBindingSource.AddNew();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            sexoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.sexo, textBox1.Text + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }
    }
}
