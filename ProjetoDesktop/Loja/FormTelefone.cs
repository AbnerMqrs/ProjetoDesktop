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
    public partial class FormTelefone : Form
    {
        public FormTelefone()
        {
            InitializeComponent();
        }

        private void FormTelefone_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.operadora);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_TELEFONETableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_TELEFONE);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveFirst();
            dADOS_TELEFONEBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MovePrevious();
            dADOS_TELEFONEBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveLast();
            dADOS_TELEFONEBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.MoveNext();
            dADOS_TELEFONEBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                telefoneBindingSource.RemoveCurrent();

                telefoneBindingSource.EndEdit();
                telefoneTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_TELEFONETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONE);

                telefoneBindingSource.MoveLast();
                dADOS_TELEFONEBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                telefoneBindingSource.EndEdit();
                telefoneTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_TELEFONETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONE);

                telefoneBindingSource.MoveLast();
                dADOS_TELEFONEBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telefoneBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                telefoneBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOperadora formOperadora = new FormOperadora();
            formOperadora.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_TELEFONETableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONE, textBox1.Text + "%");

        }
    }
}
