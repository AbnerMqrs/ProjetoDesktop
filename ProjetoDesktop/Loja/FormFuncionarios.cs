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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.loja'. Você pode movê-la ou removê-la conforme necessário.
            this.lojaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.loja);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcao);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_FUNCIONARIOSTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_FUNCIONARIOS);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveFirst();
            dADOS_FUNCIONARIOSBindingSource.MoveFirst();

        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MovePrevious();
            dADOS_FUNCIONARIOSBindingSource.MovePrevious();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveLast();
            dADOS_FUNCIONARIOSBindingSource.MoveLast();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.MoveNext();
            dADOS_FUNCIONARIOSBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionariosBindingSource.RemoveCurrent();

                funcionariosBindingSource.EndEdit();
                funcionariosTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_FUNCIONARIOSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_FUNCIONARIOS);

                funcionariosBindingSource.MoveLast();
                dADOS_FUNCIONARIOSBindingSource.MoveLast();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionariosBindingSource.AddNew();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionariosBindingSource.EndEdit();
                funcionariosTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_FUNCIONARIOSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_FUNCIONARIOS);

                funcionariosBindingSource.MoveLast();
                dADOS_FUNCIONARIOSBindingSource.MoveLast();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_FUNCIONARIOSTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_FUNCIONARIOS, textBox1.Text + "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRua formrua = new FormRua();
            formrua.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuncao formFuncao = new FormFuncao();
            formFuncao.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLoja formLoja = new FormLoja();
            formLoja.ShowDialog();
        }
    }
}
