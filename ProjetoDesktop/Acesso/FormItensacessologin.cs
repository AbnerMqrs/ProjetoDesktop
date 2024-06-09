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
    public partial class FormItensacessologin : Form
    {
        public FormItensacessologin()
        {
            InitializeComponent();
        }

        private void FormItensacessologin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.logins);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.itensacessologin'. Você pode movê-la ou removê-la conforme necessário.
            this.itensacessologinTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.itensacessologin);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.acessoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.acesso);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_ITENSACESSOLOGINTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAcesso formAcesso = new FormAcesso();
            formAcesso.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogins formLogins = new FormLogins();
            formLogins.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_ITENSACESSOLOGINTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN, textBox1.Text + "%");
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveFirst();
            dADOS_ITENSACESSOLOGINBindingSource.MoveFirst();

        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MovePrevious();
            dADOS_ITENSACESSOLOGINBindingSource.MovePrevious();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveLast();
            dADOS_ITENSACESSOLOGINBindingSource.MoveLast();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.MoveNext();
            dADOS_ITENSACESSOLOGINBindingSource.MoveNext();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.RemoveCurrent();

                itensacessologinBindingSource.EndEdit();
                itensacessologinTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_ITENSACESSOLOGINTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);

                itensacessologinBindingSource.MoveLast();
                dADOS_ITENSACESSOLOGINBindingSource.MoveLast();

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.EndEdit();
                itensacessologinTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_ITENSACESSOLOGINTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_ITENSACESSOLOGIN);

                itensacessologinBindingSource.MoveLast();
                dADOS_ITENSACESSOLOGINBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            itensacessologinBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itensacessologinBindingSource.AddNew();
            }

        }
    }
}
