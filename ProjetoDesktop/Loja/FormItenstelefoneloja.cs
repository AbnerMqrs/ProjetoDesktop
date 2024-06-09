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
    public partial class FormItenstelefoneloja : Form
    {
        public FormItenstelefoneloja()
        {
            InitializeComponent();
        }

        private void FormItenstelefoneloja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.loja);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itenstelefoneloja'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonelojaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itenstelefoneloja);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSTELEFONELOJATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSTELEFONELOJATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveFirst();
            dADOS_ITENSTELEFONELOJABindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MovePrevious();
            dADOS_ITENSTELEFONELOJABindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveLast();
            dADOS_ITENSTELEFONELOJABindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.MoveNext();
            dADOS_ITENSTELEFONELOJABindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.RemoveCurrent();

                itenstelefonelojaBindingSource.EndEdit();
                itenstelefonelojaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_ITENSTELEFONELOJATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA);

                itenstelefonelojaBindingSource.MoveLast();
                dADOS_ITENSTELEFONELOJABindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.EndEdit();
                itenstelefonelojaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_ITENSTELEFONELOJATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA);

                itenstelefonelojaBindingSource.MoveLast();
                dADOS_ITENSTELEFONELOJABindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itenstelefonelojaBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonelojaBindingSource.AddNew();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTelefone formTelefone = new FormTelefone();
            formTelefone.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoja formLoja = new FormLoja();
            formLoja.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_ITENSTELEFONELOJATableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONELOJA, textBox1.Text + "%");
        }
    }
}
