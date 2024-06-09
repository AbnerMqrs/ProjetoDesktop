namespace ProjetoDesktop
{
    partial class FormImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iMAGENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOJAUNIFUNEC2024DataSet = new ProjetoDesktop.LOJAUNIFUNEC2024DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iMAGENSTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.IMAGENSTableAdapter();
            this.produtoTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.produtoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnteiror = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.TableAdapterManager();
            this.dADOS_IMAGENSDataGridView = new System.Windows.Forms.DataGridView();
            this.codimagensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dADOSIMAGENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dADOS_IMAGENSTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_IMAGENSTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_IMAGENSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOSIMAGENSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 33;
            this.label.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "CodProduto";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "descricao", true));
            this.textBox1.Location = new System.Drawing.Point(68, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // iMAGENSBindingSource
            // 
            this.iMAGENSBindingSource.DataMember = "IMAGENS";
            this.iMAGENSBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // lOJAUNIFUNEC2024DataSet
            // 
            this.lOJAUNIFUNEC2024DataSet.DataSetName = "LOJAUNIFUNEC2024DataSet";
            this.lOJAUNIFUNEC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iMAGENSBindingSource, "codprodutofk", true));
            this.comboBox1.DataSource = this.produtoBindingSource;
            this.comboBox1.DisplayMember = "nomeproduto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "codproduto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "codimagens", true));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iMAGENSBindingSource, "imagem", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(355, 9);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(142, 150);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 34;
            this.fotoPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iMAGENSTableAdapter
            // 
            this.iMAGENSTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnteiror);
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnPrimeiro);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 94);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Navegação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(249, 59);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(168, 30);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(87, 59);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnteiror
            // 
            this.btnAnteiror.Location = new System.Drawing.Point(6, 59);
            this.btnAnteiror.Name = "btnAnteiror";
            this.btnAnteiror.Size = new System.Drawing.Size(75, 23);
            this.btnAnteiror.TabIndex = 4;
            this.btnAnteiror.Text = "Anterior";
            this.btnAnteiror.UseVisualStyleBackColor = true;
            this.btnAnteiror.Click += new System.EventHandler(this.btnAnteiror_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(87, 30);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(6, 30);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 2;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(168, 59);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.COMPRAPRODUTOTableAdapter = null;
            this.tableAdapterManager.controlelogsistemaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.IMAGENSTableAdapter = this.iMAGENSTableAdapter;
            this.tableAdapterManager.itensacessologinTableAdapter = null;
            this.tableAdapterManager.itenscompraprodutoTableAdapter = null;
            this.tableAdapterManager.itenstelefoneclienteTableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONEFORNECEDORTableAdapter = null;
            this.tableAdapterManager.itenstelefonefuncionarioTableAdapter = null;
            this.tableAdapterManager.itenstelefonelojaTableAdapter = null;
            this.tableAdapterManager.itenstelefonetrabalhoTableAdapter = null;
            this.tableAdapterManager.ITENSVENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.lojaTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.operadoraTableAdapter = null;
            this.tableAdapterManager.PARCELACOMPRATableAdapter = null;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // dADOS_IMAGENSDataGridView
            // 
            this.dADOS_IMAGENSDataGridView.AllowUserToAddRows = false;
            this.dADOS_IMAGENSDataGridView.AllowUserToDeleteRows = false;
            this.dADOS_IMAGENSDataGridView.AutoGenerateColumns = false;
            this.dADOS_IMAGENSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dADOS_IMAGENSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codimagensDataGridViewTextBoxColumn,
            this.imagemDataGridViewImageColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn});
            this.dADOS_IMAGENSDataGridView.DataSource = this.dADOSIMAGENSBindingSource;
            this.dADOS_IMAGENSDataGridView.Location = new System.Drawing.Point(18, 209);
            this.dADOS_IMAGENSDataGridView.Name = "dADOS_IMAGENSDataGridView";
            this.dADOS_IMAGENSDataGridView.ReadOnly = true;
            this.dADOS_IMAGENSDataGridView.Size = new System.Drawing.Size(479, 220);
            this.dADOS_IMAGENSDataGridView.TabIndex = 39;
            // 
            // codimagensDataGridViewTextBoxColumn
            // 
            this.codimagensDataGridViewTextBoxColumn.DataPropertyName = "codimagens";
            this.codimagensDataGridViewTextBoxColumn.HeaderText = "codimagens";
            this.codimagensDataGridViewTextBoxColumn.Name = "codimagensDataGridViewTextBoxColumn";
            this.codimagensDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagemDataGridViewImageColumn
            // 
            this.imagemDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imagemDataGridViewImageColumn.DataPropertyName = "imagem";
            this.imagemDataGridViewImageColumn.FillWeight = 50F;
            this.imagemDataGridViewImageColumn.HeaderText = "imagem";
            this.imagemDataGridViewImageColumn.Name = "imagemDataGridViewImageColumn";
            this.imagemDataGridViewImageColumn.ReadOnly = true;
            this.imagemDataGridViewImageColumn.Width = 49;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dADOSIMAGENSBindingSource
            // 
            this.dADOSIMAGENSBindingSource.DataMember = "DADOS_IMAGENS";
            this.dADOSIMAGENSBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // dADOS_IMAGENSTableAdapter
            // 
            this.dADOS_IMAGENSTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Buscar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 108;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // FormImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dADOS_IMAGENSDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormImagens";
            this.Text = "FormImagens";
            this.Load += new System.EventHandler(this.FormImagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_IMAGENSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOSIMAGENSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private LOJAUNIFUNEC2024DataSet lOJAUNIFUNEC2024DataSet;
        private System.Windows.Forms.BindingSource iMAGENSBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.IMAGENSTableAdapter iMAGENSTableAdapter;
        private LOJAUNIFUNEC2024DataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnteiror;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnNovo;
        private LOJAUNIFUNEC2024DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dADOS_IMAGENSDataGridView;
        private System.Windows.Forms.BindingSource dADOSIMAGENSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codimagensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_IMAGENSTableAdapter dADOS_IMAGENSTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}