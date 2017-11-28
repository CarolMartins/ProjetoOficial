namespace Projeto
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.lbIdEmpresa = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdEmpresa
            // 
            this.lbIdEmpresa.AutoSize = true;
            this.lbIdEmpresa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmpresa.Location = new System.Drawing.Point(12, 18);
            this.lbIdEmpresa.Name = "lbIdEmpresa";
            this.lbIdEmpresa.Size = new System.Drawing.Size(26, 19);
            this.lbIdEmpresa.TabIndex = 0;
            this.lbIdEmpresa.Text = "ID";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(16, 40);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(53, 20);
            this.txtIdEmpresa.TabIndex = 1;
            this.txtIdEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdEmpresa_KeyDown);
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoSocial.Location = new System.Drawing.Point(75, 18);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(102, 19);
            this.lbRazaoSocial.TabIndex = 2;
            this.lbRazaoSocial.Text = "Razão Social ";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(79, 41);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(532, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFantasia.Location = new System.Drawing.Point(12, 75);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(118, 19);
            this.lbNomeFantasia.TabIndex = 4;
            this.lbNomeFantasia.Text = "Nome Fantasia ";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(16, 97);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(379, 20);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.Location = new System.Drawing.Point(397, 75);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(46, 19);
            this.lbCnpj.TabIndex = 6;
            this.lbCnpj.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(401, 97);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(210, 20);
            this.txtCnpj.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(135, 135);
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
            this.btnLocalizar.Location = new System.Drawing.Point(497, 135);
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
            this.btnExcluir.Location = new System.Drawing.Point(376, 135);
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
            this.btnCancelar.Location = new System.Drawing.Point(255, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Honeydew;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatAppearance.BorderSize = 2;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(16, 135);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 40);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(624, 192);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lbNomeFantasia);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lbRazaoSocial);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.lbIdEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdEmpresa;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Label lbRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
    }
}