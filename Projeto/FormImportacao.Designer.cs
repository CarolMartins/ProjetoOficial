namespace Projeto
{
    partial class FormImportacao
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.dgvImportacao = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.numfabrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 226);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dgvImportacao
            // 
            this.dgvImportacao.AllowUserToAddRows = false;
            this.dgvImportacao.AllowUserToDeleteRows = false;
            this.dgvImportacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numfabrep,
            this.nsr,
            this.data,
            this.Hora,
            this.pis,
            this.erro});
            this.dgvImportacao.Location = new System.Drawing.Point(13, 42);
            this.dgvImportacao.Name = "dgvImportacao";
            this.dgvImportacao.ReadOnly = true;
            this.dgvImportacao.Size = new System.Drawing.Size(541, 178);
            this.dgvImportacao.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivo AFD|*.txt";
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.Location = new System.Drawing.Point(13, 13);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(157, 23);
            this.btnBuscarArquivo.TabIndex = 2;
            this.btnBuscarArquivo.Text = "Selecionar Arquivo ...";
            this.btnBuscarArquivo.UseVisualStyleBackColor = true;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(177, 13);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(376, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(94, 226);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // numfabrep
            // 
            this.numfabrep.HeaderText = "Número REP";
            this.numfabrep.Name = "numfabrep";
            this.numfabrep.ReadOnly = true;
            // 
            // nsr
            // 
            this.nsr.HeaderText = "NSR";
            this.nsr.Name = "nsr";
            this.nsr.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // pis
            // 
            this.pis.HeaderText = "PIS";
            this.pis.Name = "pis";
            this.pis.ReadOnly = true;
            // 
            // erro
            // 
            this.erro.HeaderText = "Erro de Validação";
            this.erro.Name = "erro";
            this.erro.ReadOnly = true;
            this.erro.Width = 300;
            // 
            // FormImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 260);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnBuscarArquivo);
            this.Controls.Add(this.dgvImportacao);
            this.Controls.Add(this.btnImportar);
            this.Name = "FormImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImportacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dgvImportacao;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfabrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn pis;
        private System.Windows.Forms.DataGridViewTextBoxColumn erro;
    }
}