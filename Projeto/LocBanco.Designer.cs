namespace Projeto
{
    partial class LocBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocBanco));
            this.btnSelecionarBanco = new System.Windows.Forms.Button();
            this.btnCancelarCancelar = new System.Windows.Forms.Button();
            this.btnBuscarBanco = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvbanco = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarBanco
            // 
            this.btnSelecionarBanco.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelecionarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecionarBanco.FlatAppearance.BorderSize = 2;
            this.btnSelecionarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarBanco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarBanco.Image")));
            this.btnSelecionarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarBanco.Location = new System.Drawing.Point(9, 228);
            this.btnSelecionarBanco.Name = "btnSelecionarBanco";
            this.btnSelecionarBanco.Size = new System.Drawing.Size(114, 40);
            this.btnSelecionarBanco.TabIndex = 3;
            this.btnSelecionarBanco.Text = "        SELECIONAR";
            this.btnSelecionarBanco.UseVisualStyleBackColor = false;
            this.btnSelecionarBanco.Click += new System.EventHandler(this.btnSelecionarBanco_Click);
            // 
            // btnCancelarCancelar
            // 
            this.btnCancelarCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelarCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelarCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCancelar.Image")));
            this.btnCancelarCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCancelar.Location = new System.Drawing.Point(308, 228);
            this.btnCancelarCancelar.Name = "btnCancelarCancelar";
            this.btnCancelarCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelarCancelar.TabIndex = 4;
            this.btnCancelarCancelar.Text = "CANCELAR";
            this.btnCancelarCancelar.UseVisualStyleBackColor = false;
            this.btnCancelarCancelar.Click += new System.EventHandler(this.btnCancelarCancelar_Click);
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarBanco.BackgroundImage")));
            this.btnBuscarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBuscarBanco.FlatAppearance.BorderSize = 2;
            this.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBanco.Location = new System.Drawing.Point(391, 10);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(30, 27);
            this.btnBuscarBanco.TabIndex = 1;
            this.btnBuscarBanco.UseVisualStyleBackColor = true;
            this.btnBuscarBanco.Click += new System.EventHandler(this.btnBuscarBanco_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(59, 14);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(326, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar";
            // 
            // dgvbanco
            // 
            this.dgvbanco.AllowUserToAddRows = false;
            this.dgvbanco.AllowUserToDeleteRows = false;
            this.dgvbanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Banco1,
            this.CodigoBanco});
            this.dgvbanco.Location = new System.Drawing.Point(9, 43);
            this.dgvbanco.Name = "dgvbanco";
            this.dgvbanco.ReadOnly = true;
            this.dgvbanco.Size = new System.Drawing.Size(413, 176);
            this.dgvbanco.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Banco1
            // 
            this.Banco1.DataPropertyName = "Banco1";
            this.Banco1.HeaderText = "Banco";
            this.Banco1.Name = "Banco1";
            this.Banco1.ReadOnly = true;
            this.Banco1.Width = 200;
            // 
            // CodigoBanco
            // 
            this.CodigoBanco.DataPropertyName = "CodigoBanco";
            this.CodigoBanco.HeaderText = "Código Banco";
            this.CodigoBanco.Name = "CodigoBanco";
            this.CodigoBanco.ReadOnly = true;
            // 
            // LocBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(433, 278);
            this.Controls.Add(this.btnSelecionarBanco);
            this.Controls.Add(this.btnCancelarCancelar);
            this.Controls.Add(this.btnBuscarBanco);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbanco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Banco";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarBanco;
        private System.Windows.Forms.Button btnCancelarCancelar;
        private System.Windows.Forms.Button btnBuscarBanco;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvbanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBanco;
    }
}