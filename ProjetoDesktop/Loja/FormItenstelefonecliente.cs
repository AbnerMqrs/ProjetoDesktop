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
    public partial class FormItenstelefonecliente : Form
    {
        public FormItenstelefonecliente()
        {
            InitializeComponent();
        }

        private void FormItenstelefonecliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itenstelefonecliente'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefoneclienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itenstelefonecliente);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_TELEFONECLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_TELEFONECLIENTETableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_TELEFONECLIENTE);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveFirst();
            dADOS_TELEFONECLIENTEBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MovePrevious();
            dADOS_TELEFONECLIENTEBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveLast();
            dADOS_TELEFONECLIENTEBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.MoveNext();
            dADOS_TELEFONECLIENTEBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.RemoveCurrent();

                itenstelefoneclienteBindingSource.EndEdit();
                itenstelefoneclienteTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_TELEFONECLIENTETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONECLIENTE);

                itenstelefoneclienteBindingSource.MoveLast();
                dADOS_TELEFONECLIENTEBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.EndEdit();
               itenstelefoneclienteTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_TELEFONECLIENTETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONECLIENTE);

                itenstelefoneclienteBindingSource.MoveLast();
                dADOS_TELEFONECLIENTEBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itenstelefoneclienteBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefoneclienteBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTelefone formTelefone = new FormTelefone();
            formTelefone.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_TELEFONECLIENTETableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONECLIENTE, textBox1.Text + "%");

        }
    }
}
