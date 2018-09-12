namespace USTG_MG.AppWin32.Atividades.FaltasEAtrasos
{
    partial class List
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalFaltasOuAtrasos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtrasos = new System.Windows.Forms.ToolStripButton();
            this.btnFaltas = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridContingente = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisaContingente = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.gridFaltasOuAtrasos = new System.Windows.Forms.DataGridView();
            this.faId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisaFaltasOuAtrasos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atrasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elogios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punicoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGuerra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContingente)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaltasOuAtrasos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTotalFaltasOuAtrasos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Tot. de Faltas ou Atrasos:";
            // 
            // lblTotalFaltasOuAtrasos
            // 
            this.lblTotalFaltasOuAtrasos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalFaltasOuAtrasos.Name = "lblTotalFaltasOuAtrasos";
            this.lblTotalFaltasOuAtrasos.Size = new System.Drawing.Size(20, 17);
            this.lblTotalFaltasOuAtrasos.Text = "lbl";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtrasos,
            this.btnFaltas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(962, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtrasos
            // 
            this.btnAtrasos.Image = global::USTG_MG.AppWin32.Properties.Resources.shield_standby_32x32;
            this.btnAtrasos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtrasos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtrasos.Name = "btnAtrasos";
            this.btnAtrasos.Size = new System.Drawing.Size(45, 51);
            this.btnAtrasos.Text = "Atraso";
            this.btnAtrasos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtrasos.Click += new System.EventHandler(this.btnAtrasos_Click);
            // 
            // btnFaltas
            // 
            this.btnFaltas.Image = global::USTG_MG.AppWin32.Properties.Resources.shield_caution_32x32;
            this.btnFaltas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFaltas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFaltas.Name = "btnFaltas";
            this.btnFaltas.Size = new System.Drawing.Size(36, 51);
            this.btnFaltas.Text = "Falta";
            this.btnFaltas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFaltas.Click += new System.EventHandler(this.btnFaltas_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridContingente);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridFaltasOuAtrasos);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(962, 495);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridContingente
            // 
            this.gridContingente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridContingente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContingente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Turma,
            this.Status,
            this.Faltas,
            this.Atrasos,
            this.Elogios,
            this.Punicoes,
            this.HorasExtras,
            this.RA,
            this.NomeGuerra,
            this.Patente});
            this.gridContingente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContingente.Location = new System.Drawing.Point(0, 25);
            this.gridContingente.Margin = new System.Windows.Forms.Padding(2);
            this.gridContingente.Name = "gridContingente";
            this.gridContingente.RowTemplate.Height = 24;
            this.gridContingente.Size = new System.Drawing.Size(261, 470);
            this.gridContingente.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPesquisaContingente,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(261, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "Pesquisa:";
            // 
            // txtPesquisaContingente
            // 
            this.txtPesquisaContingente.Name = "txtPesquisaContingente";
            this.txtPesquisaContingente.Size = new System.Drawing.Size(76, 25);
            this.txtPesquisaContingente.TextChanged += new System.EventHandler(this.txtPesquisaContingente_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Gray;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel2.Text = "(por RA ou Nome)";
            // 
            // gridFaltasOuAtrasos
            // 
            this.gridFaltasOuAtrasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridFaltasOuAtrasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFaltasOuAtrasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faId});
            this.gridFaltasOuAtrasos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFaltasOuAtrasos.Location = new System.Drawing.Point(0, 25);
            this.gridFaltasOuAtrasos.Margin = new System.Windows.Forms.Padding(2);
            this.gridFaltasOuAtrasos.Name = "gridFaltasOuAtrasos";
            this.gridFaltasOuAtrasos.RowTemplate.Height = 24;
            this.gridFaltasOuAtrasos.Size = new System.Drawing.Size(698, 470);
            this.gridFaltasOuAtrasos.TabIndex = 2;
            // 
            // faId
            // 
            this.faId.DataPropertyName = "Id";
            this.faId.HeaderText = "Id";
            this.faId.Name = "faId";
            this.faId.Visible = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.txtPesquisaFaltasOuAtrasos,
            this.toolStripLabel4});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(698, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "Pesquisa:";
            // 
            // txtPesquisaFaltasOuAtrasos
            // 
            this.txtPesquisaFaltasOuAtrasos.Name = "txtPesquisaFaltasOuAtrasos";
            this.txtPesquisaFaltasOuAtrasos.Size = new System.Drawing.Size(76, 25);
            this.txtPesquisaFaltasOuAtrasos.TextChanged += new System.EventHandler(this.txtPesquisaFaltasOuAtrasos_TextChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Gray;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel4.Text = "(por RA ou Nome)";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // Turma
            // 
            this.Turma.DataPropertyName = "Turma";
            this.Turma.HeaderText = "Turma";
            this.Turma.Name = "Turma";
            this.Turma.Visible = false;
            this.Turma.Width = 62;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // Faltas
            // 
            this.Faltas.DataPropertyName = "Faltas";
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            this.Faltas.Visible = false;
            this.Faltas.Width = 60;
            // 
            // Atrasos
            // 
            this.Atrasos.DataPropertyName = "Atrasos";
            this.Atrasos.HeaderText = "Atrasos";
            this.Atrasos.Name = "Atrasos";
            this.Atrasos.Visible = false;
            this.Atrasos.Width = 67;
            // 
            // Elogios
            // 
            this.Elogios.DataPropertyName = "Elogios";
            this.Elogios.HeaderText = "Elogios";
            this.Elogios.Name = "Elogios";
            this.Elogios.Visible = false;
            this.Elogios.Width = 66;
            // 
            // Punicoes
            // 
            this.Punicoes.DataPropertyName = "Punicoes";
            this.Punicoes.HeaderText = "Punicoes";
            this.Punicoes.Name = "Punicoes";
            this.Punicoes.Visible = false;
            this.Punicoes.Width = 76;
            // 
            // HorasExtras
            // 
            this.HorasExtras.DataPropertyName = "HorasExtras";
            this.HorasExtras.HeaderText = "HorasExtras";
            this.HorasExtras.Name = "HorasExtras";
            this.HorasExtras.Visible = false;
            this.HorasExtras.Width = 89;
            // 
            // RA
            // 
            this.RA.DataPropertyName = "RA";
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.Width = 47;
            // 
            // NomeGuerra
            // 
            this.NomeGuerra.DataPropertyName = "NomeDeGuerra";
            this.NomeGuerra.HeaderText = "Nome";
            this.NomeGuerra.MinimumWidth = 100;
            this.NomeGuerra.Name = "NomeGuerra";
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "Patente";
            this.Patente.HeaderText = "Patente";
            this.Patente.MinimumWidth = 71;
            this.Patente.Name = "Patente";
            this.Patente.Width = 71;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faltas e Atrasos - List";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContingente)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaltasOuAtrasos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisaContingente;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtPesquisaFaltasOuAtrasos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnAtrasos;
        private System.Windows.Forms.ToolStripButton btnFaltas;
        private System.Windows.Forms.DataGridView gridContingente;
        private System.Windows.Forms.DataGridView gridFaltasOuAtrasos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalFaltasOuAtrasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn faId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atrasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elogios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punicoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGuerra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
    }
}