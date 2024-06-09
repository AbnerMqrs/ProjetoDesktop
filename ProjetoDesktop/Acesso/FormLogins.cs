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
    public partial class FormLogins : Form
    {
        public FormLogins()
        {
            InitializeComponent();
        }

        private void FormLogins_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.logins);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_LOGINS'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_LOGINSTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_LOGINS);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            loginsBindingSource.MoveFirst();
            dADOS_LOGINSBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            loginsBindingSource.MovePrevious();
            dADOS_LOGINSBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            loginsBindingSource.MoveLast();
            dADOS_LOGINSBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            loginsBindingSource.MoveNext();
            dADOS_LOGINSBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginsBindingSource.RemoveCurrent();

                loginsBindingSource.EndEdit();
                loginsTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_LOGINSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_LOGINS);

                loginsBindingSource.MoveLast();
                dADOS_LOGINSBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginsBindingSource.EndEdit();
                loginsTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_LOGINSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_LOGINS);

                loginsBindingSource.MoveLast();
                dADOS_LOGINSBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            loginsBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginsBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_LOGINSTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_LOGINS, textBox1.Text + "%");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            form.ShowDialog();
        }
    }
}
