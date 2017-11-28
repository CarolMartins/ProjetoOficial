namespace Projeto
{
    partial class LocDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocDepartamento));
            this.btnSelecionarAbono = new System.Windows.Forms.Button();
            this.btnCancelarAbono = new System.Windows.Forms.Button();
            this.btnBuscarAbono = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarAbono
            // 
            this.btnSelecionarAbono.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelecionarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecionarAbono.FlatAppearance.BorderSize = 2;
            this.btnSelecionarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarAbono.Image")));
            this.btnSelecionarAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarAbono.Location = new System.Drawing.Point(12, 226);
            this.btnSelecionarAbono.Name = "btnSelecionarAbono";
            this.btnSelecionarAbono.Size = new System.Drawing.Size(138, 40);
            this.btnSelecionarAbono.TabIndex = 25;
            this.btnSelecionarAbono.Text = "SELECIONAR";
            this.btnSelecionarAbono.UseVisualStyleBackColor = false;
            this.btnSelecionarAbono.Click += new System.EventHandler(this.btnSelecionarAbono_Click);
            // 
            // btnCancelarAbono
            // 
            this.btnCancelarAbono.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelarAbono.FlatAppearance.BorderSize = 2;
            this.btnCancelarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAbono.Image")));
            this.btnCancelarAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAbono.Location = new System.Drawing.Point(278, 226);
            this.btnCancelarAbono.Name = "btnCancelarAbono";
            this.btnCancelarAbono.Size = new System.Drawing.Size(138, 40);
            this.btnCancelarAbono.TabIndex = 24;
            this.btnCancelarAbono.Text = "CANCELAR";
            this.btnCancelarAbono.UseVisualStyleBackColor = false;
            this.btnCancelarAbono.Click += new System.EventHandler(this.btnCancelarAbono_Click);
            // 
            // btnBuscarAbono
            // 
            this.btnBuscarAbono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAbono.BackgroundImage")));
            this.btnBuscarAbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBuscarAbono.FlatAppearance.BorderSize = 2;
            this.btnBuscarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAbono.Location = new System.Drawing.Point(385, 8);
            this.btnBuscarAbono.Name = "btnBuscarAbono";
            this.btnBuscarAbono.Size = new System.Drawing.Size(30, 27);
            this.btnBuscarAbono.TabIndex = 23;
            this.btnBuscarAbono.UseVisualStyleBackColor = true;
            this.btnBuscarAbono.Click += new System.EventHandler(this.btnBuscarAbono_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(62, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(317, 20);
            this.txtPesquisa.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar";
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.AllowUserToAddRows = false;
            this.dgvDepartamento.AllowUserToDeleteRows = false;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.departamento1});
            this.dgvDepartamento.Location = new System.Drawing.Point(12, 41);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.ReadOnly = true;
            this.dgvDepartamento.Size = new System.Drawing.Size(404, 176);
            this.dgvDepartamento.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // departamento1
            // 
            this.departamento1.DataPropertyName = "departamento1";
            this.departamento1.HeaderText = "Departamento";
            this.departamento1.Name = "departamento1";
            this.departamento1.ReadOnly = true;
            this.departamento1.Width = 260;
            // 
            // LocDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(423, 278);
            this.Controls.Add(this.btnSelecionarAbono);
            this.Controls.Add(this.btnCancelarAbono);
            this.Controls.Add(this.btnBuscarAbono);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LocDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarAbono;
        private System.Windows.Forms.Button btnCancelarAbono;
        private System.Windows.Forms.Button btnBuscarAbono;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento1;
    }
}