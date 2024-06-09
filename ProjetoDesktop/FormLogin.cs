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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lOJAUNIFUNEC2024DataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.lOJAUNIFUNEC2024DataSet.logins);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtLogins = null;

            //DataTable recebe a consulta de um TableAdapter
            dtLogins = loginsTableAdapter.GetDataByUsuarioSenha(txtusuario.Text, Convert.ToInt32(txtsenha.Text));

            DataTableReader dtr = dtLogins.CreateDataReader();
            /*
                        if (dtr.HasRows)
                        {
                            while (dtr.Read())
                            {
                                label5.Text = dtLogins.Rows.Count.ToString() + " Registros";
                                label3.Text = dtr["nomeusuario"].ToString();
                                label4.Text = dtr["senha"].ToString();
                            }
                        }
                        else
                        {
                            label5.Text = dtLogins.Rows.Count.ToString() + " Registros";
                            MessageBox.Show("Não há dados");
                        }
            */


            if (dtLogins.Rows.Count > 0)
            {
                FormMain form = new FormMain(dtr);
                this.Hide();
                form.ShowDialog(this);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorreto!", "Erro");
            }
        }
    }
}
