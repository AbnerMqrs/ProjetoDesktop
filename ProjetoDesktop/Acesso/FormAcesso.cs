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
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
        }

        private void FormAcesso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.acessoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.acesso);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveFirst();
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MovePrevious();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveLast();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            acessoBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar Dados",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.RemoveCurrent();

                acessoBindingSource.EndEdit();
                acessoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.EndEdit();
                acessoTableAdapter.Update(lOJAUNIFUNEC2024DataSet);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            acessoBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acessoBindingSource.AddNew();
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            acessoTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.acesso, textBox1.Text + "%");
        }
    }
}
