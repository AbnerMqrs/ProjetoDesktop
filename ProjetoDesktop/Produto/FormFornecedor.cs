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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_FORNECEDORTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_FORNECEDOR);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveFirst();
            dADOS_FORNECEDORBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MovePrevious();
            dADOS_FORNECEDORBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveLast();
            dADOS_FORNECEDORBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.MoveNext();
            dADOS_FORNECEDORBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.RemoveCurrent();

                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_FORNECEDORTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_FORNECEDOR);

                fornecedorBindingSource.MoveLast();
                dADOS_FORNECEDORBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_FORNECEDORTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_FORNECEDOR);

                fornecedorBindingSource.MoveLast();
                dADOS_FORNECEDORBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorBindingSource.AddNew();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRua formRua = new FormRua();
            formRua.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBairro formBairro = new FormBairro();
            formBairro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCep formCep = new FormCep();
            formCep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCidade formCidade = new FormCidade();
            formCidade.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_FORNECEDORTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_FORNECEDOR, textBox1.Text + "%");

        }
    }
}
