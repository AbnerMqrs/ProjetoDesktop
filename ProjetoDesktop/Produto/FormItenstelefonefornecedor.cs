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
    public partial class FormItenstelefonefornecedor : Form
    {
        public FormItenstelefonefornecedor()
        {
            InitializeComponent();
        }

        private void FormItenstelefonefornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.ITENSTELEFONEFORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELEFONEFORNECEDORTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.ITENSTELEFONEFORNECEDOR);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.telefone'. Você pode movê-la ou removê-la conforme necessário.
            this.telefoneTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.telefone);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONEFORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSTELEFONEFORNECEDORTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONEFORNECEDOR);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            iTENSTELEFONEFORNECEDORBindingSource.MoveFirst();
            dADOS_ITENSTELEFONEFORNECEDORBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            iTENSTELEFONEFORNECEDORBindingSource.MovePrevious();
            dADOS_ITENSTELEFONEFORNECEDORBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            iTENSTELEFONEFORNECEDORBindingSource.MoveLast();
            dADOS_ITENSTELEFONEFORNECEDORBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            iTENSTELEFONEFORNECEDORBindingSource.MoveNext();
            dADOS_ITENSTELEFONEFORNECEDORBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSTELEFONEFORNECEDORBindingSource.RemoveCurrent();

                iTENSTELEFONEFORNECEDORBindingSource.EndEdit();
                iTENSTELEFONEFORNECEDORTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_ITENSTELEFONEFORNECEDORTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONEFORNECEDOR);

                iTENSTELEFONEFORNECEDORBindingSource.MoveLast();
                dADOS_ITENSTELEFONEFORNECEDORBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSTELEFONEFORNECEDORBindingSource.EndEdit();
                iTENSTELEFONEFORNECEDORTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_ITENSTELEFONEFORNECEDORTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONEFORNECEDOR);

                iTENSTELEFONEFORNECEDORBindingSource.MoveLast();
                dADOS_ITENSTELEFONEFORNECEDORBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iTENSTELEFONEFORNECEDORBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iTENSTELEFONEFORNECEDORBindingSource.AddNew();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTelefone formTelefone = new FormTelefone();
            formTelefone.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_ITENSTELEFONEFORNECEDORTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_ITENSTELEFONEFORNECEDOR, textBox1.Text + "%");

        }
    }
}
