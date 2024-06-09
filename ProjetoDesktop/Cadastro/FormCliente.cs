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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.cidade);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.cep);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.bairro);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.rua);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet1.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet1.sexo);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CLIENTESTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CLIENTESTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CLIENTESTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cliente);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveFirst();
            dADOS_CLIENTESBindingSource.MoveFirst();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
            dADOS_CLIENTESBindingSource.MoveLast();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MovePrevious();
            dADOS_CLIENTESBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveNext();
            dADOS_CLIENTESBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.RemoveCurrent();

                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_CLIENTESTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES);

                clienteBindingSource.MoveLast();
                dADOS_CLIENTESBindingSource.MoveLast();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.AddNew();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_CLIENTESTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES);

                clienteBindingSource.MoveLast();
                dADOS_CLIENTESBindingSource.MoveLast();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSexo formSexo = new FormSexo();
            formSexo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRua formRua = new FormRua();
            formRua.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBairro formBairro = new FormBairro();
            formBairro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCep formCep = new FormCep();
            formCep.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCidade formCidade = new FormCidade();
            formCidade.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormTrabalho formTrabalho = new FormTrabalho();
            formTrabalho.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Image Imagem = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Imagem = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Imagem;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_CLIENTESTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_CLIENTES, textBox1.Text + "%");
        }
    }
}
