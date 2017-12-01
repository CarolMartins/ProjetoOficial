namespace Projeto
{
    partial class LocTipoAbono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocTipoAbono));
            this.dgvAbono = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAbono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscarAbono = new System.Windows.Forms.Button();
            this.btnCancelarAbono = new System.Windows.Forms.Button();
            this.btnSelecionarAbono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbono
            // 
            this.dgvAbono.AllowUserToAddRows = false;
            this.dgvAbono.AllowUserToDeleteRows = false;
            this.dgvAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tipoAbono1});
            this.dgvAbono.Location = new System.Drawing.Point(10, 55);
            this.dgvAbono.Name = "dgvAbono";
            this.dgvAbono.ReadOnly = true;
            this.dgvAbono.Size = new System.Drawing.Size(404, 176);
            this.dgvAbono.TabIndex = 2;
            this.dgvAbono.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbono_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // tipoAbono1
            // 
            this.tipoAbono1.DataPropertyName = "tipoAbono1";
            this.tipoAbono1.HeaderText = "Tipo Abono";
            this.tipoAbono1.Name = "tipoAbono1";
            this.tipoAbono1.ReadOnly = true;
            this.tipoAbono1.Width = 260;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(61, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(317, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnBuscarAbono
            // 
            this.btnBuscarAbono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAbono.BackgroundImage")));
            this.btnBuscarAbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBuscarAbono.FlatAppearance.BorderSize = 2;
            this.btnBuscarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAbono.Location = new System.Drawing.Point(384, 12);
            this.btnBuscarAbono.Name = "btnBuscarAbono";
            this.btnBuscarAbono.Size = new System.Drawing.Size(30, 27);
            this.btnBuscarAbono.TabIndex = 1;
            this.btnBuscarAbono.UseVisualStyleBackColor = true;
            this.btnBuscarAbono.Click += new System.EventHandler(this.btnBuscarAbono_Click);
            // 
            // btnCancelarAbono
            // 
            this.btnCancelarAbono.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelarAbono.FlatAppearance.BorderSize = 2;
            this.btnCancelarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAbono.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAbono.Image")));
            this.btnCancelarAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAbono.Location = new System.Drawing.Point(300, 240);
            this.btnCancelarAbono.Name = "btnCancelarAbono";
            this.btnCancelarAbono.Size = new System.Drawing.Size(114, 40);
            this.btnCancelarAbono.TabIndex = 4;
            this.btnCancelarAbono.Text = "CANCELAR";
            this.btnCancelarAbono.UseVisualStyleBackColor = false;
            this.btnCancelarAbono.Click += new System.EventHandler(this.btnCancelarAbono_Click);
            // 
            // btnSelecionarAbono
            // 
            this.btnSelecionarAbono.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelecionarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecionarAbono.FlatAppearance.BorderSize = 2;
            this.btnSelecionarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarAbono.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarAbono.Image")));
            this.btnSelecionarAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarAbono.Location = new System.Drawing.Point(10, 240);
            this.btnSelecionarAbono.Name = "btnSelecionarAbono";
            this.btnSelecionarAbono.Size = new System.Drawing.Size(114, 40);
            this.btnSelecionarAbono.TabIndex = 3;
            this.btnSelecionarAbono.Text = "       SELECIONAR";
            this.btnSelecionarAbono.UseVisualStyleBackColor = false;
            this.btnSelecionarAbono.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LocTipoAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.btnSelecionarAbono);
            this.Controls.Add(this.btnCancelarAbono);
            this.Controls.Add(this.btnBuscarAbono);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAbono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocTipoAbono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Tipo Abono";
            this.Load += new System.EventHandler(this.LocTipoAbono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBuscarAbono;
        private System.Windows.Forms.Button btnCancelarAbono;
        private System.Windows.Forms.Button btnSelecionarAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAbono1;
    }
}