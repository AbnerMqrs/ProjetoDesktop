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
    public partial class FormItenstelefonefuncionario : Form
    {
        public FormItenstelefonefuncionario()
        {
            InitializeComponent();
        }

        private void FormItenstelefonefuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itenstelefonefuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonefuncionarioTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itenstelefonefuncionario);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_TELEFONEFUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_TELEFONEFUNCIONARIOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_TELEFONEFUNCIONARIO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveFirst();
            dADOS_TELEFONEFUNCIONARIOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MovePrevious();
            dADOS_TELEFONEFUNCIONARIOBindingSource.MovePrevious();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveLast();
            dADOS_TELEFONEFUNCIONARIOBindingSource.MoveLast();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.MoveNext();
            dADOS_TELEFONEFUNCIONARIOBindingSource.MoveNext();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.RemoveCurrent();

                itenstelefonefuncionarioBindingSource.EndEdit();
                itenstelefonefuncionarioTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_TELEFONEFUNCIONARIOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONEFUNCIONARIO);

                itenstelefonefuncionarioBindingSource.MoveLast();
                dADOS_TELEFONEFUNCIONARIOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.EndEdit();
                itenstelefonefuncionarioTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_TELEFONEFUNCIONARIOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONEFUNCIONARIO);

                itenstelefonefuncionarioBindingSource.MoveLast();
                dADOS_TELEFONEFUNCIONARIOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itenstelefonefuncionarioBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonefuncionarioBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTelefone formTelefone = new FormTelefone();
            formTelefone.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_TELEFONEFUNCIONARIOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONEFUNCIONARIO, textBox1.Text + "%");
        }
    }
}
