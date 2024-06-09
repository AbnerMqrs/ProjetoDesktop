namespace ProjetoDesktop
{
    partial class FormTelefone
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
            this.dADOS_TELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dADOS_TELEFONETableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_TELEFONETableAdapter();
            this.dADOS_TELEFONEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcodfk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnteiror = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.telefoneTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.telefoneTableAdapter();
            this.operadoraTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.operadoraTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_TELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_TELEFONEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOJAUNIFUNEC2024DataSet
            // 
            this.lOJAUNIFUNEC2024DataSet.DataSetName = "LOJAUNIFUNEC2024DataSet";
            this.lOJAUNIFUNEC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dADOS_TELEFONEBindingSource
            // 
            this.dADOS_TELEFONEBindingSource.DataMember = "DADOS_TELEFONE";
            this.dADOS_TELEFONEBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // dADOS_TELEFONETableAdapter
            // 
            this.dADOS_TELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // dADOS_TELEFONEDataGridView
            // 
            this.dADOS_TELEFONEDataGridView.AutoGenerateColumns = false;
            this.dADOS_TELEFONEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dADOS_TELEFONEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dADOS_TELEFONEDataGridView.DataSource = this.dADOS_TELEFONEBindingSource;
            this.dADOS_TELEFONEDataGridView.Location = new System.Drawing.Point(20, 212);
            this.dADOS_TELEFONEDataGridView.Name = "dADOS_TELEFONEDataGridView";
            this.dADOS_TELEFONEDataGridView.Size = new System.Drawing.Size(347, 220);
            this.dADOS_TELEFONEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codtelefone";
            this.dataGridViewTextBoxColumn1.HeaderText = "codtelefone";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numerotelefone";
            this.dataGridViewTextBoxColumn2.HeaderText = "numerotelefone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeopera";
            this.dataGridViewTextBoxColumn3.HeaderText = "nomeopera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Operadora:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.telefoneBindingSource, "codoperafk", true));
            this.comboBox1.DataSource = this.operadoraBindingSource;
            this.comboBox1.DisplayMember = "nomeopera";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.ValueMember = "codopera";
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataMember = "telefone";
            this.telefoneBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // operadoraBindingSource
            // 
            this.operadoraBindingSource.DataMember = "operadora";
            this.operadoraBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 58;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefoneBindingSource, "numerotelefone", true));
            this.txtNome.Location = new System.Drawing.Point(68, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(114, 20);
            this.txtNome.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Numero:";
            // 
            // lblcodfk
            // 
            this.lblcodfk.AutoSize = true;
            this.lblcodfk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefoneBindingSource, "codtelefone", true));
            this.lblcodfk.Location = new System.Drawing.Point(17, 56);
            this.lblcodfk.Name = "lblcodfk";
            this.lblcodfk.Size = new System.Drawing.Size(11, 13);
            this.lblcodfk.TabIndex = 55;
            this.lblcodfk.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Código";
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
            this.groupBox1.Location = new System.Drawing.Point(20, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 100);
            this.groupBox1.TabIndex = 53;
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
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // operadoraTableAdapter
            // 
            this.operadoraTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 437);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcodfk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dADOS_TELEFONEDataGridView);
            this.Name = "FormTelefone";
            this.Text = "FormTelefone";
            this.Load += new System.EventHandler(this.FormTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_TELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_TELEFONEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LOJAUNIFUNEC2024DataSet lOJAUNIFUNEC2024DataSet;
        private System.Windows.Forms.BindingSource dADOS_TELEFONEBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_TELEFONETableAdapter dADOS_TELEFONETableAdapter;
        private System.Windows.Forms.DataGridView dADOS_TELEFONEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcodfk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnteiror;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.telefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.BindingSource operadoraBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.operadoraTableAdapter operadoraTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}