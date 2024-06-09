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
    public partial class FormImagens : Form
    {
        public FormImagens()
        {
            InitializeComponent();
        }

        private void FormImagens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.DADOS_IMAGENS'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_IMAGENSTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.DADOS_IMAGENS);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.IMAGENS'. Você pode movê-la ou removê-la conforme necessário.
            this.iMAGENSTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.IMAGENS);
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image Imagem = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Imagem = Image.FromFile(openFileDialog1.FileName);
                fotoPictureBox.Image = Imagem;
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            iMAGENSBindingSource.MoveFirst();
            dADOSIMAGENSBindingSource.MoveFirst();

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar novos Dados?", "Salvar dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iMAGENSBindingSource.EndEdit();
                iMAGENSTableAdapter.Update(lOJAUNIFUNEC2024DataSet);


                dADOS_IMAGENSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_IMAGENS);

                iMAGENSBindingSource.MoveLast();
                dADOSIMAGENSBindingSource.MoveLast();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar os Dados?", "Apagar os dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iMAGENSBindingSource.RemoveCurrent();

                iMAGENSBindingSource.EndEdit();
                iMAGENSTableAdapter.Update(lOJAUNIFUNEC2024DataSet);

                dADOS_IMAGENSTableAdapter.Fill(lOJAUNIFUNEC2024DataSet.DADOS_IMAGENS);

                iMAGENSBindingSource.MoveLast();
                dADOSIMAGENSBindingSource.MoveLast();

            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            dADOSIMAGENSBindingSource.MoveNext();
            iMAGENSBindingSource.MoveNext();
            
        }

        private void btnAnteiror_Click(object sender, EventArgs e)
        {
            dADOSIMAGENSBindingSource.MovePrevious();
            iMAGENSBindingSource.MovePrevious();
            
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            iMAGENSBindingSource.MoveLast();
            dADOSIMAGENSBindingSource.MoveLast();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iMAGENSBindingSource.CancelEdit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "Inserir novos dados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                iMAGENSBindingSource.AddNew();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            dADOS_IMAGENSTableAdapter.FillByNome(lOJAUNIFUNEC2024DataSet.DADOS_IMAGENS, textBox2.Text + "%");
        }
    }
}
