namespace USTG_MG.AppWin32.Cadastros.Contingentes
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
            this.lblTotalItens = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtraso = new System.Windows.Forms.ToolStripButton();
            this.btnFalta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnElogio = new System.Windows.Forms.ToolStripButton();
            this.btnPunicao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHoraExtra = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDeGuerra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atrasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elogios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punicoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTotalItens});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Tot.Itens:";
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(20, 17);
            this.lblTotalItens.Text = "lbl";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnAtraso,
            this.btnFalta,
            this.toolStripSeparator2,
            this.btnElogio,
            this.btnPunicao,
            this.toolStripSeparator3,
            this.btnHoraExtra,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.txtBusca,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(849, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::USTG_MG.AppWin32.Properties.Resources.file_32x32;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 51);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnAtraso
            // 
            this.btnAtraso.Image = global::USTG_MG.AppWin32.Properties.Resources.shield_standby_32x32;
            this.btnAtraso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtraso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtraso.Name = "btnAtraso";
            this.btnAtraso.Size = new System.Drawing.Size(45, 51);
            this.btnAtraso.Text = "Atraso";
            this.btnAtraso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtraso.Click += new System.EventHandler(this.btnAtraso_Click);
            // 
            // btnFalta
            // 
            this.btnFalta.Image = global::USTG_MG.AppWin32.Properties.Resources.shield_caution_32x32;
            this.btnFalta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFalta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(36, 51);
            this.btnFalta.Text = "Falta";
            this.btnFalta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnElogio
            // 
            this.btnElogio.Image = global::USTG_MG.AppWin32.Properties.Resources.blue_flag_32x32;
            this.btnElogio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnElogio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElogio.Name = "btnElogio";
            this.btnElogio.Size = new System.Drawing.Size(47, 51);
            this.btnElogio.Text = "Eliogio";
            this.btnElogio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnElogio.Click += new System.EventHandler(this.btnElogio_Click);
            // 
            // btnPunicao
            // 
            this.btnPunicao.Image = global::USTG_MG.AppWin32.Properties.Resources.red_flag_32x32;
            this.btnPunicao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPunicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPunicao.Name = "btnPunicao";
            this.btnPunicao.Size = new System.Drawing.Size(54, 51);
            this.btnPunicao.Text = "Punição";
            this.btnPunicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPunicao.Click += new System.EventHandler(this.btnPunicao_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnHoraExtra
            // 
            this.btnHoraExtra.Image = global::USTG_MG.AppWin32.Properties.Resources.list_add_002;
            this.btnHoraExtra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoraExtra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHoraExtra.Name = "btnHoraExtra";
            this.btnHoraExtra.Size = new System.Drawing.Size(51, 51);
            this.btnHoraExtra.Text = "H. Extra";
            this.btnHoraExtra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoraExtra.Click += new System.EventHandler(this.btnHoraExtra_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 51);
            this.toolStripLabel2.Text = "Busca:";
            // 
            // txtBusca
            // 
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(180, 54);
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(110, 51);
            this.toolStripLabel1.Text = "(digite Nome ou RA)";
            // 
            // gridList
            // 
            this.gridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Turma,
            this.RA,
            this.NomeDeGuerra,
            this.Patente,
            this.Status,
            this.Faltas,
            this.Atrasos,
            this.Elogios,
            this.Punicoes,
            this.HorasExtras});
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.Location = new System.Drawing.Point(0, 54);
            this.gridList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridList.Name = "gridList";
            this.gridList.RowTemplate.Height = 24;
            this.gridList.Size = new System.Drawing.Size(849, 455);
            this.gridList.TabIndex = 2;
            this.gridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridList_CellDoubleClick);
            this.gridList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridList_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Turma
            // 
            this.Turma.DataPropertyName = "Turma";
            this.Turma.FillWeight = 82.08121F;
            this.Turma.HeaderText = "Turma";
            this.Turma.Name = "Turma";
            // 
            // RA
            // 
            this.RA.DataPropertyName = "RA";
            this.RA.FillWeight = 82.08121F;
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            // 
            // NomeDeGuerra
            // 
            this.NomeDeGuerra.DataPropertyName = "NomeDeGuerra";
            this.NomeDeGuerra.FillWeight = 82.08121F;
            this.NomeDeGuerra.HeaderText = "Nome";
            this.NomeDeGuerra.Name = "NomeDeGuerra";
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "Patente";
            this.Patente.FillWeight = 82.08121F;
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 82.08121F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Faltas
            // 
            this.Faltas.DataPropertyName = "Faltas";
            this.Faltas.FillWeight = 82.08121F;
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            // 
            // Atrasos
            // 
            this.Atrasos.DataPropertyName = "Atrasos";
            this.Atrasos.FillWeight = 82.08121F;
            this.Atrasos.HeaderText = "Atrasos";
            this.Atrasos.Name = "Atrasos";
            // 
            // Elogios
            // 
            this.Elogios.DataPropertyName = "Elogios";
            this.Elogios.FillWeight = 82.08121F;
            this.Elogios.HeaderText = "Elogios";
            this.Elogios.Name = "Elogios";
            // 
            // Punicoes
            // 
            this.Punicoes.DataPropertyName = "Punicoes";
            this.Punicoes.FillWeight = 82.08121F;
            this.Punicoes.HeaderText = "Punições";
            this.Punicoes.Name = "Punicoes";
            // 
            // HorasExtras
            // 
            this.HorasExtras.DataPropertyName = "HorasExtras";
            this.HorasExtras.FillWeight = 82.08121F;
            this.HorasExtras.HeaderText = "H Extras";
            this.HorasExtras.Name = "HorasExtras";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 531);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contingente - List";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView gridList;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnPunicao;
        private System.Windows.Forms.ToolStripButton btnElogio;
        private System.Windows.Forms.ToolStripButton btnAtraso;
        private System.Windows.Forms.ToolStripButton btnFalta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHoraExtra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDeGuerra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atrasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elogios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punicoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalItens;
    }
}