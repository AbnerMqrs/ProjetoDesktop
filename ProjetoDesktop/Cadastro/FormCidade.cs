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
    public partial class FormCidade : Form
    {
        public FormCidade()
        {
            InitializeComponent();
        }

        private void FormCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CIDADETableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CIDADETableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.uf'. Você pode movê-la ou removê-la conforme necessário.
            this.ufTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.uf);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cidade);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_CIDADETableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_CIDADE, textBox1.Text + "%");
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            cidadeBindingSource.MoveFirst();
            dADOS_CIDADEBindingSource.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_CIDADETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CIDADE);

                cidadeBindingSource.MoveLast();
                dADOS_CIDADEBindingSource.MoveLast();
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cidadeBindingSource.RemoveCurrent();

                cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_CIDADETableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CIDADE);

                cidadeBindingSource.MoveLast();
                dADOS_CIDADEBindingSource.MoveLast();

            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            cidadeBindingSource.MoveNext();
            dADOS_CIDADEBindingSource.MoveNext();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            cidadeBindingSource.MovePrevious();
            dADOS_CIDADEBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cidadeBindingSource.MoveLast();
            dADOS_CIDADEBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cidadeBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cidadeBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUf formUf = new FormUf();
            formUf.ShowDialog();
        }
    }
}
