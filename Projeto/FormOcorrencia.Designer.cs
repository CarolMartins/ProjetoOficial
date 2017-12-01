namespace Projeto
{
    partial class FormOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOcorrencia));
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.IDEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(12, 29);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(295, 21);
            this.comboFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionário";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(325, 30);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(99, 20);
            this.dtpInicial.TabIndex = 2;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(441, 30);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(101, 20);
            this.dtpFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Período Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Período Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AllowUserToAddRows = false;
            this.dgvOcorrencias.AllowUserToDeleteRows = false;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEntrada,
            this.nsr,
            this.Funcionário,
            this.PIS,
            this.Data,
            this.hora,
            this.Status});
            this.dgvOcorrencias.Location = new System.Drawing.Point(12, 56);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.ReadOnly = true;
            this.dgvOcorrencias.Size = new System.Drawing.Size(747, 231);
            this.dgvOcorrencias.TabIndex = 7;
            // 
            // IDEntrada
            // 
            this.IDEntrada.DataPropertyName = "IDEntrada";
            this.IDEntrada.HeaderText = "IDEntrada";
            this.IDEntrada.Name = "IDEntrada";
            this.IDEntrada.ReadOnly = true;
            this.IDEntrada.Visible = false;
            // 
            // nsr
            // 
            this.nsr.DataPropertyName = "nsr";
            this.nsr.HeaderText = "NSR";
            this.nsr.Name = "nsr";
            this.nsr.ReadOnly = true;
            // 
            // Funcionário
            // 
            this.Funcionário.DataPropertyName = "nome";
            this.Funcionário.HeaderText = "Funcionário";
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.ReadOnly = true;
            this.Funcionário.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PIS
            // 
            this.PIS.DataPropertyName = "numeroPis";
            this.PIS.HeaderText = "pis";
            this.PIS.Name = "PIS";
            this.PIS.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 300;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "INSERIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(135, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "ALTERAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(255, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "EXCLUIR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(771, 344);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvOcorrencias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrências";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}