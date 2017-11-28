namespace Projeto
{
    partial class LocEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocEmpresa));
            this.btnSelecionarAbono = new System.Windows.Forms.Button();
            this.btnCancelarAbono = new System.Windows.Forms.Button();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
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
            this.btnSelecionarAbono.Location = new System.Drawing.Point(12, 228);
            this.btnSelecionarAbono.Name = "btnSelecionarAbono";
            this.btnSelecionarAbono.Size = new System.Drawing.Size(138, 40);
            this.btnSelecionarAbono.TabIndex = 31;
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
            this.btnCancelarAbono.Location = new System.Drawing.Point(416, 228);
            this.btnCancelarAbono.Name = "btnCancelarAbono";
            this.btnCancelarAbono.Size = new System.Drawing.Size(138, 40);
            this.btnCancelarAbono.TabIndex = 30;
            this.btnCancelarAbono.Text = "CANCELAR";
            this.btnCancelarAbono.UseVisualStyleBackColor = false;
            this.btnCancelarAbono.Click += new System.EventHandler(this.btnCancelarAbono_Click);
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpresa.BackgroundImage")));
            this.btnBuscarEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBuscarEmpresa.FlatAppearance.BorderSize = 2;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(521, 10);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(30, 27);
            this.btnBuscarEmpresa.TabIndex = 29;
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(62, 14);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(453, 20);
            this.txtPesquisa.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.razaoSocial,
            this.nomeFantasia,
            this.cnpj});
            this.dgvEmpresa.Location = new System.Drawing.Point(12, 43);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.Size = new System.Drawing.Size(542, 176);
            this.dgvEmpresa.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // razaoSocial
            // 
            this.razaoSocial.DataPropertyName = "razaoSocial";
            this.razaoSocial.HeaderText = "Razão Social";
            this.razaoSocial.Name = "razaoSocial";
            this.razaoSocial.ReadOnly = true;
            this.razaoSocial.Width = 150;
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.DataPropertyName = "nomeFantasia";
            this.nomeFantasia.HeaderText = "Nome Fantasia";
            this.nomeFantasia.Name = "nomeFantasia";
            this.nomeFantasia.ReadOnly = true;
            this.nomeFantasia.Width = 150;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 150;
            // 
            // LocEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(563, 278);
            this.Controls.Add(this.btnSelecionarAbono);
            this.Controls.Add(this.btnCancelarAbono);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpresa);
            this.Name = "LocEmpresa";
            this.Text = "LocEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarAbono;
        private System.Windows.Forms.Button btnCancelarAbono;
        private System.Windows.Forms.Button btnBuscarEmpresa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
    }
}