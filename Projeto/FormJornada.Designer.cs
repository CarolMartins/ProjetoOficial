namespace Projeto
{
    partial class FormJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJornada));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDJornada = new System.Windows.Forms.TextBox();
            this.txtDescricaoJornada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDomingo = new System.Windows.Forms.CheckBox();
            this.ckbSabado = new System.Windows.Forms.CheckBox();
            this.ckbSexta = new System.Windows.Forms.CheckBox();
            this.ckbQuinta = new System.Windows.Forms.CheckBox();
            this.ckbQuarta = new System.Windows.Forms.CheckBox();
            this.ckbTerca = new System.Windows.Forms.CheckBox();
            this.ckbSegunda = new System.Windows.Forms.CheckBox();
            this.ckbIndeterminado = new System.Windows.Forms.CheckBox();
            this.mtbEntrada1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbSaida1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbEntrada2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbSaida2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvJornada = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtJornadaTotal = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quintaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sextaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indeterminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtIDJornada
            // 
            this.txtIDJornada.Location = new System.Drawing.Point(16, 30);
            this.txtIDJornada.Name = "txtIDJornada";
            this.txtIDJornada.Size = new System.Drawing.Size(54, 20);
            this.txtIDJornada.TabIndex = 1;
            // 
            // txtDescricaoJornada
            // 
            this.txtDescricaoJornada.Location = new System.Drawing.Point(75, 30);
            this.txtDescricaoJornada.Name = "txtDescricaoJornada";
            this.txtDescricaoJornada.Size = new System.Drawing.Size(296, 20);
            this.txtDescricaoJornada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saída";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDomingo);
            this.groupBox1.Controls.Add(this.ckbSabado);
            this.groupBox1.Controls.Add(this.ckbSexta);
            this.groupBox1.Controls.Add(this.ckbQuinta);
            this.groupBox1.Controls.Add(this.ckbQuarta);
            this.groupBox1.Controls.Add(this.ckbTerca);
            this.groupBox1.Controls.Add(this.ckbSegunda);
            this.groupBox1.Controls.Add(this.ckbIndeterminado);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 111);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias Trabalhado";
            // 
            // ckbDomingo
            // 
            this.ckbDomingo.AutoSize = true;
            this.ckbDomingo.Location = new System.Drawing.Point(355, 25);
            this.ckbDomingo.Name = "ckbDomingo";
            this.ckbDomingo.Size = new System.Drawing.Size(77, 20);
            this.ckbDomingo.TabIndex = 7;
            this.ckbDomingo.Text = "Domingo";
            this.ckbDomingo.UseVisualStyleBackColor = true;
            // 
            // ckbSabado
            // 
            this.ckbSabado.AutoSize = true;
            this.ckbSabado.Location = new System.Drawing.Point(244, 68);
            this.ckbSabado.Name = "ckbSabado";
            this.ckbSabado.Size = new System.Drawing.Size(70, 20);
            this.ckbSabado.TabIndex = 6;
            this.ckbSabado.Text = "Sabádo";
            this.ckbSabado.UseVisualStyleBackColor = true;
            // 
            // ckbSexta
            // 
            this.ckbSexta.AutoSize = true;
            this.ckbSexta.Location = new System.Drawing.Point(244, 29);
            this.ckbSexta.Name = "ckbSexta";
            this.ckbSexta.Size = new System.Drawing.Size(93, 20);
            this.ckbSexta.TabIndex = 5;
            this.ckbSexta.Text = "Sexta-Feira";
            this.ckbSexta.UseVisualStyleBackColor = true;
            // 
            // ckbQuinta
            // 
            this.ckbQuinta.AutoSize = true;
            this.ckbQuinta.Location = new System.Drawing.Point(129, 68);
            this.ckbQuinta.Name = "ckbQuinta";
            this.ckbQuinta.Size = new System.Drawing.Size(98, 20);
            this.ckbQuinta.TabIndex = 4;
            this.ckbQuinta.Text = "Quinta-Feira";
            this.ckbQuinta.UseVisualStyleBackColor = true;
            // 
            // ckbQuarta
            // 
            this.ckbQuarta.AutoSize = true;
            this.ckbQuarta.Location = new System.Drawing.Point(129, 29);
            this.ckbQuarta.Name = "ckbQuarta";
            this.ckbQuarta.Size = new System.Drawing.Size(100, 20);
            this.ckbQuarta.TabIndex = 3;
            this.ckbQuarta.Text = "Quarta-Feira";
            this.ckbQuarta.UseVisualStyleBackColor = true;
            // 
            // ckbTerca
            // 
            this.ckbTerca.AutoSize = true;
            this.ckbTerca.Location = new System.Drawing.Point(8, 68);
            this.ckbTerca.Name = "ckbTerca";
            this.ckbTerca.Size = new System.Drawing.Size(91, 20);
            this.ckbTerca.TabIndex = 2;
            this.ckbTerca.Text = "Terça-feira";
            this.ckbTerca.UseVisualStyleBackColor = true;
            // 
            // ckbSegunda
            // 
            this.ckbSegunda.AutoSize = true;
            this.ckbSegunda.Location = new System.Drawing.Point(8, 29);
            this.ckbSegunda.Name = "ckbSegunda";
            this.ckbSegunda.Size = new System.Drawing.Size(111, 20);
            this.ckbSegunda.TabIndex = 1;
            this.ckbSegunda.Text = "Segunda-Feira";
            this.ckbSegunda.UseVisualStyleBackColor = true;
            // 
            // ckbIndeterminado
            // 
            this.ckbIndeterminado.AutoSize = true;
            this.ckbIndeterminado.Location = new System.Drawing.Point(355, 71);
            this.ckbIndeterminado.Name = "ckbIndeterminado";
            this.ckbIndeterminado.Size = new System.Drawing.Size(110, 20);
            this.ckbIndeterminado.TabIndex = 0;
            this.ckbIndeterminado.Text = "Indeterminado";
            this.ckbIndeterminado.UseVisualStyleBackColor = true;
            // 
            // mtbEntrada1
            // 
            this.mtbEntrada1.Location = new System.Drawing.Point(377, 30);
            this.mtbEntrada1.Mask = "00:00";
            this.mtbEntrada1.Name = "mtbEntrada1";
            this.mtbEntrada1.Size = new System.Drawing.Size(53, 20);
            this.mtbEntrada1.TabIndex = 13;
            this.mtbEntrada1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbEntrada1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbSaida1
            // 
            this.mtbSaida1.Location = new System.Drawing.Point(436, 30);
            this.mtbSaida1.Mask = "00:00";
            this.mtbSaida1.Name = "mtbSaida1";
            this.mtbSaida1.Size = new System.Drawing.Size(53, 20);
            this.mtbSaida1.TabIndex = 14;
            this.mtbSaida1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSaida1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbEntrada2
            // 
            this.mtbEntrada2.Location = new System.Drawing.Point(493, 30);
            this.mtbEntrada2.Mask = "00:00";
            this.mtbEntrada2.Name = "mtbEntrada2";
            this.mtbEntrada2.Size = new System.Drawing.Size(53, 20);
            this.mtbEntrada2.TabIndex = 15;
            this.mtbEntrada2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbEntrada2.ValidatingType = typeof(System.DateTime);
            // 
            // mtbSaida2
            // 
            this.mtbSaida2.Location = new System.Drawing.Point(550, 30);
            this.mtbSaida2.Mask = "00:00";
            this.mtbSaida2.Name = "mtbSaida2";
            this.mtbSaida2.Size = new System.Drawing.Size(53, 20);
            this.mtbSaida2.TabIndex = 16;
            this.mtbSaida2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSaida2.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jornada Total";
            // 
            // dgvJornada
            // 
            this.dgvJornada.AllowUserToAddRows = false;
            this.dgvJornada.AllowUserToDeleteRows = false;
            this.dgvJornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJornada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.entrada1,
            this.segundaFeira,
            this.tercaFeira,
            this.quartaFeira,
            this.quintaFeira,
            this.sextaFeira,
            this.sabado,
            this.domingo,
            this.indeterminado});
            this.dgvJornada.Location = new System.Drawing.Point(12, 209);
            this.dgvJornada.Name = "dgvJornada";
            this.dgvJornada.ReadOnly = true;
            this.dgvJornada.Size = new System.Drawing.Size(601, 150);
            this.dgvJornada.TabIndex = 19;
            this.dgvJornada.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJornada_CellContentDoubleClick);
            this.dgvJornada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJornada_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Semanal";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(131, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 40);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Honeydew;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(371, 377);
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
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(251, 377);
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
            this.btnNovo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(12, 377);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 40);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtJornadaTotal
            // 
            this.txtJornadaTotal.Location = new System.Drawing.Point(514, 149);
            this.txtJornadaTotal.Name = "txtJornadaTotal";
            this.txtJornadaTotal.Size = new System.Drawing.Size(80, 20);
            this.txtJornadaTotal.TabIndex = 26;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Id";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // entrada1
            // 
            this.entrada1.DataPropertyName = "totalJornada";
            this.entrada1.HeaderText = "Jornada Total";
            this.entrada1.Name = "entrada1";
            this.entrada1.ReadOnly = true;
            this.entrada1.Width = 60;
            // 
            // segundaFeira
            // 
            this.segundaFeira.HeaderText = "Segunda-Feira";
            this.segundaFeira.Name = "segundaFeira";
            this.segundaFeira.ReadOnly = true;
            this.segundaFeira.Width = 80;
            // 
            // tercaFeira
            // 
            this.tercaFeira.HeaderText = "Terça-Feira";
            this.tercaFeira.Name = "tercaFeira";
            this.tercaFeira.ReadOnly = true;
            this.tercaFeira.Width = 80;
            // 
            // quartaFeira
            // 
            this.quartaFeira.HeaderText = "Quarta-Feira";
            this.quartaFeira.Name = "quartaFeira";
            this.quartaFeira.ReadOnly = true;
            this.quartaFeira.Width = 80;
            // 
            // quintaFeira
            // 
            this.quintaFeira.HeaderText = "Quinta-Feira";
            this.quintaFeira.Name = "quintaFeira";
            this.quintaFeira.ReadOnly = true;
            this.quintaFeira.Width = 80;
            // 
            // sextaFeira
            // 
            this.sextaFeira.HeaderText = "Sexta-Feira";
            this.sextaFeira.Name = "sextaFeira";
            this.sextaFeira.ReadOnly = true;
            this.sextaFeira.Width = 80;
            // 
            // sabado
            // 
            this.sabado.HeaderText = "Sabádo";
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            this.sabado.Width = 80;
            // 
            // domingo
            // 
            this.domingo.HeaderText = "Domingo";
            this.domingo.Name = "domingo";
            this.domingo.ReadOnly = true;
            this.domingo.Width = 80;
            // 
            // indeterminado
            // 
            this.indeterminado.HeaderText = "Indeterminado";
            this.indeterminado.Name = "indeterminado";
            this.indeterminado.ReadOnly = true;
            this.indeterminado.Width = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // FormJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(625, 444);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtJornadaTotal);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvJornada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbSaida2);
            this.Controls.Add(this.mtbEntrada2);
            this.Controls.Add(this.mtbSaida1);
            this.Controls.Add(this.mtbEntrada1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricaoJornada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDJornada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJornada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDJornada;
        private System.Windows.Forms.TextBox txtDescricaoJornada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbDomingo;
        private System.Windows.Forms.CheckBox ckbSabado;
        private System.Windows.Forms.CheckBox ckbSexta;
        private System.Windows.Forms.CheckBox ckbQuinta;
        private System.Windows.Forms.CheckBox ckbQuarta;
        private System.Windows.Forms.CheckBox ckbTerca;
        private System.Windows.Forms.CheckBox ckbSegunda;
        private System.Windows.Forms.CheckBox ckbIndeterminado;
        private System.Windows.Forms.MaskedTextBox mtbEntrada1;
        private System.Windows.Forms.MaskedTextBox mtbSaida1;
        private System.Windows.Forms.MaskedTextBox mtbEntrada2;
        private System.Windows.Forms.MaskedTextBox mtbSaida2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvJornada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtJornadaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada1;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn quintaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn sextaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeterminado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}