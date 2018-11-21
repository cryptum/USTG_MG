namespace USTG_MG.AppWin32.Cadastros.Servicos
{
    partial class Grid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataBuscar = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridEscala = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDeGuerraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punicoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contingenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovoItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contingenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).BeginInit();
            this.SuspendLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.dataBuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 313);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 259);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // dataBuscar
            // 
            this.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBuscar.Location = new System.Drawing.Point(98, 31);
            this.dataBuscar.Name = "dataBuscar";
            this.dataBuscar.Size = new System.Drawing.Size(102, 20);
            this.dataBuscar.TabIndex = 4;
            this.dataBuscar.ValueChanged += new System.EventHandler(this.dataBuscar_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridEscala);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 259);
            this.panel2.TabIndex = 3;
            // 
            // gridEscala
            // 
            this.gridEscala.AllowUserToAddRows = false;
            this.gridEscala.AllowUserToDeleteRows = false;
            this.gridEscala.AutoGenerateColumns = false;
            this.gridEscala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEscala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDeGuerraDataGridViewTextBoxColumn,
            this.rADataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn,
            this.Punicoes});
            this.gridEscala.DataSource = this.contingenteBindingSource1;
            this.gridEscala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEscala.Location = new System.Drawing.Point(0, 0);
            this.gridEscala.Name = "gridEscala";
            this.gridEscala.ReadOnly = true;
            this.gridEscala.Size = new System.Drawing.Size(627, 259);
            this.gridEscala.TabIndex = 0;
            this.gridEscala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEscala_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDeGuerraDataGridViewTextBoxColumn
            // 
            this.nomeDeGuerraDataGridViewTextBoxColumn.DataPropertyName = "NomeDeGuerra";
            this.nomeDeGuerraDataGridViewTextBoxColumn.HeaderText = "NomeDeGuerra";
            this.nomeDeGuerraDataGridViewTextBoxColumn.Name = "nomeDeGuerraDataGridViewTextBoxColumn";
            this.nomeDeGuerraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rADataGridViewTextBoxColumn
            // 
            this.rADataGridViewTextBoxColumn.DataPropertyName = "RA";
            this.rADataGridViewTextBoxColumn.HeaderText = "RA";
            this.rADataGridViewTextBoxColumn.Name = "rADataGridViewTextBoxColumn";
            this.rADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            this.patenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Punicoes
            // 
            this.Punicoes.DataPropertyName = "Punicoes";
            this.Punicoes.HeaderText = "Punicoes";
            this.Punicoes.Name = "Punicoes";
            this.Punicoes.ReadOnly = true;
            // 
            // contingenteBindingSource1
            // 
            this.contingenteBindingSource1.DataSource = typeof(USTG_MG.Model.Contingente);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoItem,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(627, 54);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Image = global::USTG_MG.AppWin32.Properties.Resources.file_32x32;
            this.btnNovoItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovoItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(40, 51);
            this.btnNovoItem.Text = "Novo";
            this.btnNovoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_clipboard_12_32;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 51);
            this.toolStripButton1.Text = "Editar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contingenteBindingSource
            // 
            this.contingenteBindingSource.DataSource = typeof(USTG_MG.Model.Contingente);
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 313);
            this.Controls.Add(this.panel1);
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Escala";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEscala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource contingenteBindingSource;
        private System.Windows.Forms.DataGridView gridEscala;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDeGuerraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punicoes;
        private System.Windows.Forms.BindingSource contingenteBindingSource1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnNovoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DateTimePicker dataBuscar;
    }
}