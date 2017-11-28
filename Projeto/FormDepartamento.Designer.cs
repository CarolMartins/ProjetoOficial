namespace Projeto
{
    partial class FormDepartamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartamento));
            this.lbIdEmpresa = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdEmpresa
            // 
            this.lbIdEmpresa.AutoSize = true;
            this.lbIdEmpresa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmpresa.Location = new System.Drawing.Point(14, 11);
            this.lbIdEmpresa.Name = "lbIdEmpresa";
            this.lbIdEmpresa.Size = new System.Drawing.Size(26, 19);
            this.lbIdEmpresa.TabIndex = 0;
            this.lbIdEmpresa.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.lbDepartamento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(14, 56);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(109, 19);
            this.lbDepartamento.TabIndex = 2;
            this.lbDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(18, 83);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(594, 20);
            this.txtDepartamento.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(137, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 40);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Honeydew;
            this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLocalizar.FlatAppearance.BorderSize = 2;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(498, 120);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(114, 40);
            this.btnLocalizar.TabIndex = 24;
            this.btnLocalizar.Text = "LOCALIZAR";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Honeydew;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(377, 120);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 40);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(257, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Honeydew;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btNovo.FlatAppearance.BorderSize = 2;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(18, 120);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(114, 40);
            this.btNovo.TabIndex = 21;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 181);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbIdEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdEmpresa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btNovo;
    }
}