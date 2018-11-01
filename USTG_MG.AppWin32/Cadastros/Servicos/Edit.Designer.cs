namespace USTG_MG.AppWin32.Cadastros.Servicos
{
    partial class Edit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.tipoServicoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataServicoCampo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridContingentes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDeGuerraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elogiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punicoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contingenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGerarLista = new System.Windows.Forms.Button();
            this.btnInserirManualmente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContingentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalvarServico);
            this.groupBox1.Controls.Add(this.tipoServicoCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataServicoCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.Image = global::USTG_MG.AppWin32.Properties.Resources.ok_24x24;
            this.btnSalvarServico.Location = new System.Drawing.Point(668, 10);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(75, 69);
            this.btnSalvarServico.TabIndex = 3;
            this.btnSalvarServico.Text = "Salvar";
            this.btnSalvarServico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarServico.UseVisualStyleBackColor = true;
            this.btnSalvarServico.Click += new System.EventHandler(this.btnSalvarServico_Click);
            // 
            // tipoServicoCombo
            // 
            this.tipoServicoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServicoCombo.FormattingEnabled = true;
            this.tipoServicoCombo.Location = new System.Drawing.Point(78, 53);
            this.tipoServicoCombo.Name = "tipoServicoCombo";
            this.tipoServicoCombo.Size = new System.Drawing.Size(256, 21);
            this.tipoServicoCombo.TabIndex = 3;
            this.tipoServicoCombo.SelectedIndexChanged += new System.EventHandler(this.tipoServicoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // dataServicoCampo
            // 
            this.dataServicoCampo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataServicoCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataServicoCampo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataServicoCampo.Location = new System.Drawing.Point(78, 14);
            this.dataServicoCampo.Name = "dataServicoCampo";
            this.dataServicoCampo.Size = new System.Drawing.Size(256, 20);
            this.dataServicoCampo.TabIndex = 1;
            this.dataServicoCampo.ValueChanged += new System.EventHandler(this.dataServicoCampo_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridContingentes);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridContingentes
            // 
            this.dataGridContingentes.AllowUserToAddRows = false;
            this.dataGridContingentes.AutoGenerateColumns = false;
            this.dataGridContingentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContingentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDeGuerraDataGridViewTextBoxColumn,
            this.rADataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn,
            this.elogiosDataGridViewTextBoxColumn,
            this.punicoesDataGridViewTextBoxColumn});
            this.dataGridContingentes.DataSource = this.contingenteBindingSource;
            this.dataGridContingentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridContingentes.Location = new System.Drawing.Point(3, 16);
            this.dataGridContingentes.Name = "dataGridContingentes";
            this.dataGridContingentes.ReadOnly = true;
            this.dataGridContingentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContingentes.Size = new System.Drawing.Size(743, 185);
            this.dataGridContingentes.TabIndex = 0;
            this.dataGridContingentes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridContingentes_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDeGuerraDataGridViewTextBoxColumn
            // 
            this.nomeDeGuerraDataGridViewTextBoxColumn.DataPropertyName = "NomeDeGuerra";
            this.nomeDeGuerraDataGridViewTextBoxColumn.HeaderText = "NomeDeGuerra";
            this.nomeDeGuerraDataGridViewTextBoxColumn.Name = "nomeDeGuerraDataGridViewTextBoxColumn";
            // 
            // rADataGridViewTextBoxColumn
            // 
            this.rADataGridViewTextBoxColumn.DataPropertyName = "RA";
            this.rADataGridViewTextBoxColumn.HeaderText = "RA";
            this.rADataGridViewTextBoxColumn.Name = "rADataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            // 
            // elogiosDataGridViewTextBoxColumn
            // 
            this.elogiosDataGridViewTextBoxColumn.DataPropertyName = "Elogios";
            this.elogiosDataGridViewTextBoxColumn.HeaderText = "Elogios";
            this.elogiosDataGridViewTextBoxColumn.Name = "elogiosDataGridViewTextBoxColumn";
            // 
            // punicoesDataGridViewTextBoxColumn
            // 
            this.punicoesDataGridViewTextBoxColumn.DataPropertyName = "Punicoes";
            this.punicoesDataGridViewTextBoxColumn.HeaderText = "Punicoes";
            this.punicoesDataGridViewTextBoxColumn.Name = "punicoesDataGridViewTextBoxColumn";
            // 
            // contingenteBindingSource
            // 
            this.contingenteBindingSource.DataSource = typeof(USTG_MG.Model.Contingente);
            // 
            // btnGerarLista
            // 
            this.btnGerarLista.Location = new System.Drawing.Point(670, 313);
            this.btnGerarLista.Name = "btnGerarLista";
            this.btnGerarLista.Size = new System.Drawing.Size(88, 23);
            this.btnGerarLista.TabIndex = 5;
            this.btnGerarLista.Text = "Gerar";
            this.btnGerarLista.UseVisualStyleBackColor = true;
            this.btnGerarLista.Click += new System.EventHandler(this.btnGerarLista_Click);
            // 
            // btnInserirManualmente
            // 
            this.btnInserirManualmente.Location = new System.Drawing.Point(531, 313);
            this.btnInserirManualmente.Name = "btnInserirManualmente";
            this.btnInserirManualmente.Size = new System.Drawing.Size(124, 23);
            this.btnInserirManualmente.TabIndex = 6;
            this.btnInserirManualmente.Text = "Inserir Manualmente";
            this.btnInserirManualmente.UseVisualStyleBackColor = true;
            this.btnInserirManualmente.Click += new System.EventHandler(this.btnInserirManualmente_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 366);
            this.Controls.Add(this.btnInserirManualmente);
            this.Controls.Add(this.btnGerarLista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Escala";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContingentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tipoServicoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataServicoCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridContingentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDeGuerraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elogiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punicoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contingenteBindingSource;
        private System.Windows.Forms.Button btnGerarLista;
        private System.Windows.Forms.Button btnInserirManualmente;
    }
}