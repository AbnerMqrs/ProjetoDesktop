namespace ProjetoDesktop
{
    partial class FormCompraproduto
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
            this.lOJAUNIFUNEC2024DataSet = new ProjetoDesktop.LOJAUNIFUNEC2024DataSet();
            this.dADOS_COMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dADOS_COMPRAPRODUTOTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_COMPRAPRODUTOTableAdapter();
            this.dADOS_COMPRAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcodfk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnteiror = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cOMPRAPRODUTOTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.fornecedorTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.fornecedorTableAdapter();
            this.funcionariosTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.funcionariosTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_COMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_COMPRAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOJAUNIFUNEC2024DataSet
            // 
            this.lOJAUNIFUNEC2024DataSet.DataSetName = "LOJAUNIFUNEC2024DataSet";
            this.lOJAUNIFUNEC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dADOS_COMPRAPRODUTOBindingSource
            // 
            this.dADOS_COMPRAPRODUTOBindingSource.DataMember = "DADOS_COMPRAPRODUTO";
            this.dADOS_COMPRAPRODUTOBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // dADOS_COMPRAPRODUTOTableAdapter
            // 
            this.dADOS_COMPRAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // dADOS_COMPRAPRODUTODataGridView
            // 
            this.dADOS_COMPRAPRODUTODataGridView.AutoGenerateColumns = false;
            this.dADOS_COMPRAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dADOS_COMPRAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dADOS_COMPRAPRODUTODataGridView.DataSource = this.dADOS_COMPRAPRODUTOBindingSource;
            this.dADOS_COMPRAPRODUTODataGridView.Location = new System.Drawing.Point(12, 233);
            this.dADOS_COMPRAPRODUTODataGridView.Name = "dADOS_COMPRAPRODUTODataGridView";
            this.dADOS_COMPRAPRODUTODataGridView.Size = new System.Drawing.Size(567, 220);
            this.dADOS_COMPRAPRODUTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "codcompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datacompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "datacompra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomefornecedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "nomefornecedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nomefuncionarios";
            this.dataGridViewTextBoxColumn4.HeaderText = "nomefuncionarios";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Fornecedor:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "codfornecedorfk", true));
            this.comboBox2.DataSource = this.fornecedorBindingSource;
            this.comboBox2.DisplayMember = "nomefornecedor";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.ValueMember = "codfornecedor";
            // 
            // cOMPRAPRODUTOBindingSource
            // 
            this.cOMPRAPRODUTOBindingSource.DataMember = "COMPRAPRODUTO";
            this.cOMPRAPRODUTOBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Funcionario:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "codfuncionariosfk", true));
            this.comboBox1.DataSource = this.funcionariosBindingSource;
            this.comboBox1.DisplayMember = "nomefuncionarios";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.ValueMember = "codfuncionarios";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 84;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPRAPRODUTOBindingSource, "datacompra", true));
            this.txtNome.Location = new System.Drawing.Point(92, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 20);
            this.txtNome.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Data:";
            // 
            // lblcodfk
            // 
            this.lblcodfk.AutoSize = true;
            this.lblcodfk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPRAPRODUTOBindingSource, "codcompra", true));
            this.lblcodfk.Location = new System.Drawing.Point(34, 66);
            this.lblcodfk.Name = "lblcodfk";
            this.lblcodfk.Size = new System.Drawing.Size(11, 13);
            this.lblcodfk.TabIndex = 81;
            this.lblcodfk.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Código";
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
            this.groupBox1.Location = new System.Drawing.Point(32, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 100);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Navegação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(299, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(299, 59);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(218, 30);
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
            this.btnNovo.Location = new System.Drawing.Point(218, 59);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cOMPRAPRODUTOTableAdapter
            // 
            this.cOMPRAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCompraproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcodfk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dADOS_COMPRAPRODUTODataGridView);
            this.Name = "FormCompraproduto";
            this.Text = "FormCompraproduto";
            this.Load += new System.EventHandler(this.FormCompraproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_COMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_COMPRAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LOJAUNIFUNEC2024DataSet lOJAUNIFUNEC2024DataSet;
        private System.Windows.Forms.BindingSource dADOS_COMPRAPRODUTOBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_COMPRAPRODUTOTableAdapter dADOS_COMPRAPRODUTOTableAdapter;
        private System.Windows.Forms.DataGridView dADOS_COMPRAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcodfk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnteiror;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}