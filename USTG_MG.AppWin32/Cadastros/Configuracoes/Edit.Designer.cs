namespace USTG_MG.AppWin32.Cadastros.Configuracoes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIniciarComContingenteAberto = new System.Windows.Forms.CheckBox();
            this.dropTurma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIniciarComContingenteAberto);
            this.groupBox1.Controls.Add(this.dropTurma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkIniciarComContingenteAberto
            // 
            this.chkIniciarComContingenteAberto.AutoSize = true;
            this.chkIniciarComContingenteAberto.Location = new System.Drawing.Point(26, 83);
            this.chkIniciarComContingenteAberto.Name = "chkIniciarComContingenteAberto";
            this.chkIniciarComContingenteAberto.Size = new System.Drawing.Size(329, 21);
            this.chkIniciarComContingenteAberto.TabIndex = 2;
            this.chkIniciarComContingenteAberto.Text = "Iniciar sistema com lista do contingente aberto?";
            this.chkIniciarComContingenteAberto.UseVisualStyleBackColor = true;
            // 
            // dropTurma
            // 
            this.dropTurma.DisplayMember = "ANO";
            this.dropTurma.FormattingEnabled = true;
            this.dropTurma.Location = new System.Drawing.Point(83, 35);
            this.dropTurma.Name = "dropTurma";
            this.dropTurma.Size = new System.Drawing.Size(121, 24);
            this.dropTurma.TabIndex = 1;
            this.dropTurma.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turma:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(292, 146);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 38);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 196);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações - Edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIniciarComContingenteAberto;
        private System.Windows.Forms.ComboBox dropTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
    }
}