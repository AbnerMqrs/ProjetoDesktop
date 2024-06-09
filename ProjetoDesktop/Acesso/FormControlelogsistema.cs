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
    public partial class FormControlelogsistema : Form
    {
        public FormControlelogsistema()
        {
            InitializeComponent();
        }

        private void FormControlelogsistema_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.controlelogsistema'. Você pode movê-la ou removê-la conforme necessário.
            this.controlelogsistemaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.controlelogsistema);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.logins);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CONTROLELOGSISTEMATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.logins);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.controlelogsistema'. Você pode movê-la ou removê-la conforme necessário.
            this.controlelogsistemaTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.controlelogsistema);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_CONTROLELOGSISTEMATableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveFirst();
            dADOS_CONTROLELOGSISTEMABindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MovePrevious();
            dADOS_CONTROLELOGSISTEMABindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveLast();
            dADOS_CONTROLELOGSISTEMABindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.MoveNext();
            dADOS_CONTROLELOGSISTEMABindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.RemoveCurrent();

                controlelogsistemaBindingSource.EndEdit();
                controlelogsistemaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_CONTROLELOGSISTEMATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA);

                controlelogsistemaBindingSource.MoveLast();
                dADOS_CONTROLELOGSISTEMABindingSource.MoveLast();

            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.EndEdit();
                controlelogsistemaTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_CONTROLELOGSISTEMATableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA);

                controlelogsistemaBindingSource.MoveLast();
                dADOS_CONTROLELOGSISTEMABindingSource.MoveLast();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlelogsistemaBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlelogsistemaBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_CONTROLELOGSISTEMATableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_CONTROLELOGSISTEMA, textBox1.Text + "%");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogins formLogins = new FormLogins();
            formLogins.ShowDialog();
        }
    }
}
