namespace USTG_MG.AppWin32.Cadastros.Servicos
{
    partial class BuscarContingente
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
            this.contigentesAtivosGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovoItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDeGuerraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contingenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contigentesAtivosGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contigentesAtivosGrid);
            this.panel1.Location = new System.Drawing.Point(1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 328);
            this.panel1.TabIndex = 0;
            // 
            // contigentesAtivosGrid
            // 
            this.contigentesAtivosGrid.AllowUserToAddRows = false;
            this.contigentesAtivosGrid.AllowUserToDeleteRows = false;
            this.contigentesAtivosGrid.AutoGenerateColumns = false;
            this.contigentesAtivosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contigentesAtivosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDeGuerraDataGridViewTextBoxColumn,
            this.rADataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn});
            this.contigentesAtivosGrid.DataSource = this.contingenteBindingSource;
            this.contigentesAtivosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contigentesAtivosGrid.Location = new System.Drawing.Point(0, 0);
            this.contigentesAtivosGrid.Name = "contigentesAtivosGrid";
            this.contigentesAtivosGrid.ReadOnly = true;
            this.contigentesAtivosGrid.Size = new System.Drawing.Size(357, 328);
            this.contigentesAtivosGrid.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(359, 46);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Image = global::USTG_MG.AppWin32.Properties.Resources.ok_24x24;
            this.btnNovoItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovoItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(28, 43);
            this.btnNovoItem.Text = "OK";
            this.btnNovoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::USTG_MG.AppWin32.Properties.Resources.if_Delete_1493279;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 43);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // contingenteBindingSource
            // 
            this.contingenteBindingSource.DataSource = typeof(USTG_MG.Model.Contingente);
            // 
            // BuscarContingente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 392);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuscarContingente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Contingente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contigentesAtivosGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contingenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView contigentesAtivosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDeGuerraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contingenteBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovoItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}