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
    public partial class FormVendaproduto : Form
    {
        public FormVendaproduto()
        {
            InitializeComponent();
        }

        private void FormVendaproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_VENDAPRODUTOTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_VENDAPRODUTO);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            vENDAPRODUTOBindingSource.MoveFirst();
            dADOS_VENDAPRODUTOBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            vENDAPRODUTOBindingSource.MovePrevious();
            dADOS_VENDAPRODUTOBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            vENDAPRODUTOBindingSource.MoveLast();
            dADOS_VENDAPRODUTOBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            vENDAPRODUTOBindingSource.MoveNext();
            dADOS_VENDAPRODUTOBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vENDAPRODUTOBindingSource.RemoveCurrent();

                vENDAPRODUTOBindingSource.EndEdit();
                vENDAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_VENDAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_VENDAPRODUTO);

                vENDAPRODUTOBindingSource.MoveLast();
                dADOS_VENDAPRODUTOBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vENDAPRODUTOBindingSource.EndEdit();
                vENDAPRODUTOTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_VENDAPRODUTOTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_VENDAPRODUTO);

                vENDAPRODUTOBindingSource.MoveLast();
                dADOS_VENDAPRODUTOBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            vENDAPRODUTOBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vENDAPRODUTOBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_VENDAPRODUTOTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_VENDAPRODUTO, textBox1.Text + "%");

        }
    }
}
