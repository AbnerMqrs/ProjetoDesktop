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
    public partial class FormItenstelefonetrabalho : Form
    {
        public FormItenstelefonetrabalho()
        {
            InitializeComponent();
        }

        private void FormItenstelefonetrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itenstelefonetrabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.itenstelefonetrabalhoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itenstelefonetrabalho);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_TELEFONETRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_TELEFONETRABALHOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_TELEFONETRABALHO);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveFirst();
            dADOS_TELEFONETRABALHOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MovePrevious();
            dADOS_TELEFONETRABALHOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveLast();
            dADOS_TELEFONETRABALHOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.MoveNext();
            dADOS_TELEFONETRABALHOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.RemoveCurrent();

                itenstelefonetrabalhoBindingSource.EndEdit();
                itenstelefonetrabalhoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_TELEFONETRABALHOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONETRABALHO);

                itenstelefonetrabalhoBindingSource.MoveLast();
                dADOS_TELEFONETRABALHOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.EndEdit();
                itenstelefonetrabalhoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_TELEFONETRABALHOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONETRABALHO);

                itenstelefonetrabalhoBindingSource.MoveLast();
                dADOS_TELEFONETRABALHOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itenstelefonetrabalhoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itenstelefonetrabalhoBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTelefone formTelefone = new FormTelefone();
            formTelefone.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTrabalho formTrabalho = new FormTrabalho();
            formTrabalho.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_TELEFONETRABALHOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_TELEFONETRABALHO, textBox1.Text + "%");
        }
    }
}
