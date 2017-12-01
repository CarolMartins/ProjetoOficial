namespace Projeto
{
    partial class LocFuncaoCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocFuncaoCargo));
            this.dgvFuncao = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscarAbono = new System.Windows.Forms.Button();
            this.btnSelecionarFuncao = new System.Windows.Forms.Button();
            this.btnCancelarFuncao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncao
            // 
            this.dgvFuncao.AllowUserToAddRows = false;
            this.dgvFuncao.AllowUserToDeleteRows = false;
            this.dgvFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricao});
            this.dgvFuncao.Location = new System.Drawing.Point(15, 56);
            this.dgvFuncao.Name = "dgvFuncao";
            this.dgvFuncao.ReadOnly = true;
            this.dgvFuncao.Size = new System.Drawing.Size(401, 150);
            this.dgvFuncao.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 260;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar ";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(52, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(313, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // btnBuscarAbono
            // 
            this.btnBuscarAbono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAbono.BackgroundImage")));
            this.btnBuscarAbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarAbono.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBuscarAbono.FlatAppearance.BorderSize = 2;
            this.btnBuscarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAbono.Location = new System.Drawing.Point(386, 12);
            this.btnBuscarAbono.Name = "btnBuscarAbono";
            this.btnBuscarAbono.Size = new System.Drawing.Size(30, 27);
            this.btnBuscarAbono.TabIndex = 1;
            this.btnBuscarAbono.UseVisualStyleBackColor = true;
            this.btnBuscarAbono.Click += new System.EventHandler(this.btnBuscarAbono_Click);
            // 
            // btnSelecionarFuncao
            // 
            this.btnSelecionarFuncao.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelecionarFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecionarFuncao.FlatAppearance.BorderSize = 2;
            this.btnSelecionarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarFuncao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarFuncao.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarFuncao.Image")));
            this.btnSelecionarFuncao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarFuncao.Location = new System.Drawing.Point(15, 222);
            this.btnSelecionarFuncao.Name = "btnSelecionarFuncao";
            this.btnSelecionarFuncao.Size = new System.Drawing.Size(114, 40);
            this.btnSelecionarFuncao.TabIndex = 3;
            this.btnSelecionarFuncao.Text = "        SELECIONAR";
            this.btnSelecionarFuncao.UseVisualStyleBackColor = false;
            this.btnSelecionarFuncao.Click += new System.EventHandler(this.btnSelecionarFuncao_Click);
            // 
            // btnCancelarFuncao
            // 
            this.btnCancelarFuncao.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelarFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelarFuncao.FlatAppearance.BorderSize = 2;
            this.btnCancelarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFuncao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFuncao.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFuncao.Image")));
            this.btnCancelarFuncao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFuncao.Location = new System.Drawing.Point(302, 222);
            this.btnCancelarFuncao.Name = "btnCancelarFuncao";
            this.btnCancelarFuncao.Size = new System.Drawing.Size(114, 40);
            this.btnCancelarFuncao.TabIndex = 4;
            this.btnCancelarFuncao.Text = "CANCELAR";
            this.btnCancelarFuncao.UseVisualStyleBackColor = false;
            this.btnCancelarFuncao.Click += new System.EventHandler(this.btnCancelarAbono_Click);
            // 
            // LocFuncaoCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.btnSelecionarFuncao);
            this.Controls.Add(this.btnCancelarFuncao);
            this.Controls.Add(this.btnBuscarAbono);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocFuncaoCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Função Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBuscarAbono;
        private System.Windows.Forms.Button btnSelecionarFuncao;
        private System.Windows.Forms.Button btnCancelarFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}