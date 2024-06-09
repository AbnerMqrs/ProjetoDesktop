namespace ProjetoDesktop
{
    partial class FormItenstelefoneloja
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
            this.dADOS_ITENSTELEFONELOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dADOS_ITENSTELEFONELOJATableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_ITENSTELEFONELOJATableAdapter();
            this.dADOS_ITENSTELEFONELOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnteiror = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.itenstelefonelojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.telefoneTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.telefoneTableAdapter();
            this.itenstelefonelojaTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.itenstelefonelojaTableAdapter();
            this.lojaTableAdapter = new ProjetoDesktop.LOJAUNIFUNEC2024DataSetTableAdapters.lojaTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_ITENSTELEFONELOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_ITENSTELEFONELOJADataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonelojaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lOJAUNIFUNEC2024DataSet
            // 
            this.lOJAUNIFUNEC2024DataSet.DataSetName = "LOJAUNIFUNEC2024DataSet";
            this.lOJAUNIFUNEC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dADOS_ITENSTELEFONELOJABindingSource
            // 
            this.dADOS_ITENSTELEFONELOJABindingSource.DataMember = "DADOS_ITENSTELEFONELOJA";
            this.dADOS_ITENSTELEFONELOJABindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // dADOS_ITENSTELEFONELOJATableAdapter
            // 
            this.dADOS_ITENSTELEFONELOJATableAdapter.ClearBeforeFill = true;
            // 
            // dADOS_ITENSTELEFONELOJADataGridView
            // 
            this.dADOS_ITENSTELEFONELOJADataGridView.AutoGenerateColumns = false;
            this.dADOS_ITENSTELEFONELOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dADOS_ITENSTELEFONELOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dADOS_ITENSTELEFONELOJADataGridView.DataSource = this.dADOS_ITENSTELEFONELOJABindingSource;
            this.dADOS_ITENSTELEFONELOJADataGridView.Location = new System.Drawing.Point(15, 228);
            this.dADOS_ITENSTELEFONELOJADataGridView.Name = "dADOS_ITENSTELEFONELOJADataGridView";
            this.dADOS_ITENSTELEFONELOJADataGridView.Size = new System.Drawing.Size(354, 220);
            this.dADOS_ITENSTELEFONELOJADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numerotelefone";
            this.dataGridViewTextBoxColumn1.HeaderText = "numerotelefone";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeloja";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeloja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            this.groupBox1.Location = new System.Drawing.Point(6, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 100);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Navegação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(258, 59);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(177, 30);
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
            this.btnNovo.Location = new System.Drawing.Point(177, 59);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Telefone:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itenstelefonelojaBindingSource, "codtelefonefk", true));
            this.comboBox2.DataSource = this.telefoneBindingSource;
            this.comboBox2.DisplayMember = "numerotelefone";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 73;
            this.comboBox2.ValueMember = "codtelefone";
            // 
            // itenstelefonelojaBindingSource
            // 
            this.itenstelefonelojaBindingSource.DataMember = "itenstelefoneloja";
            this.itenstelefonelojaBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataMember = "telefone";
            this.telefoneBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Loja:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itenstelefonelojaBindingSource, "codlojafk", true));
            this.comboBox1.DataSource = this.lojaBindingSource;
            this.comboBox1.DisplayMember = "nomeloja";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.ValueMember = "codloja";
            // 
            // lojaBindingSource
            // 
            this.lojaBindingSource.DataMember = "loja";
            this.lojaBindingSource.DataSource = this.lOJAUNIFUNEC2024DataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // itenstelefonelojaTableAdapter
            // 
            this.itenstelefonelojaTableAdapter.ClearBeforeFill = true;
            // 
            // lojaTableAdapter
            // 
            this.lojaTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormItenstelefoneloja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dADOS_ITENSTELEFONELOJADataGridView);
            this.Name = "FormItenstelefoneloja";
            this.Text = "FormItenstelefoneloja";
            this.Load += new System.EventHandler(this.FormItenstelefoneloja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOJAUNIFUNEC2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_ITENSTELEFONELOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dADOS_ITENSTELEFONELOJADataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itenstelefonelojaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LOJAUNIFUNEC2024DataSet lOJAUNIFUNEC2024DataSet;
        private System.Windows.Forms.BindingSource dADOS_ITENSTELEFONELOJABindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.DADOS_ITENSTELEFONELOJATableAdapter dADOS_ITENSTELEFONELOJATableAdapter;
        private System.Windows.Forms.DataGridView dADOS_ITENSTELEFONELOJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnteiror;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.telefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.BindingSource itenstelefonelojaBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.itenstelefonelojaTableAdapter itenstelefonelojaTableAdapter;
        private System.Windows.Forms.BindingSource lojaBindingSource;
        private LOJAUNIFUNEC2024DataSetTableAdapters.lojaTableAdapter lojaTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}