namespace Projeto
{
    partial class FormAbono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbono));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtTipoAbono = new System.Windows.Forms.TextBox();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbIdEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btSalvar.FlatAppearance.BorderSize = 2;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(134, 122);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(114, 40);
            this.btSalvar.TabIndex = 29;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Honeydew;
            this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLocalizar.FlatAppearance.BorderSize = 2;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(495, 122);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(114, 40);
            this.btnLocalizar.TabIndex = 28;
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
            this.btnExcluir.Location = new System.Drawing.Point(374, 122);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 40);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Honeydew;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(254, 122);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 40);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "CANCELAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btNovo.Location = new System.Drawing.Point(15, 122);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(114, 40);
            this.btNovo.TabIndex = 25;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtTipoAbono
            // 
            this.txtTipoAbono.Location = new System.Drawing.Point(17, 86);
            this.txtTipoAbono.Name = "txtTipoAbono";
            this.txtTipoAbono.Size = new System.Drawing.Size(594, 20);
            this.txtTipoAbono.TabIndex = 24;
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.lbDepartamento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(13, 62);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(98, 19);
            this.lbDepartamento.TabIndex = 23;
            this.lbDepartamento.Text = "Tipo Abono ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 22;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // lbIdEmpresa
            // 
            this.lbIdEmpresa.AutoSize = true;
            this.lbIdEmpresa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmpresa.Location = new System.Drawing.Point(13, 13);
            this.lbIdEmpresa.Name = "lbIdEmpresa";
            this.lbIdEmpresa.Size = new System.Drawing.Size(26, 19);
            this.lbIdEmpresa.TabIndex = 21;
            this.lbIdEmpresa.Text = "ID";
            // 
            // FormAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(625, 175);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtTipoAbono);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbIdEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAbono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo Abono ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtTipoAbono;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbIdEmpresa;
    }
}