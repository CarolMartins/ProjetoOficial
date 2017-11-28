using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormEscolaridade : Form
    {
        public FormEscolaridade()
        {
            InitializeComponent();
            Desabilitar();
        }

        public void Desabilitar()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLocalizar.Enabled = true;
            btnExcluir.Enabled = false;
            txtIdEscolaridade.Enabled = true;
            txtEscolaridade.Enabled = false;
        }

        public void Habilitar()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtIdEscolaridade.Enabled = false;
            txtEscolaridade.Enabled = true;
        }

        public void limpar()
        {
            txtIdEscolaridade.Clear();
            txtEscolaridade.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            txtEscolaridade.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEscolaridade.Text == "")
            {
                MessageBox.Show("Informe a Escolaridade!", "Atenção!");
                txtEscolaridade.Focus();
            }
            else
            {
                registro_pontoEntities context = new registro_pontoEntities();
                if (txtIdEscolaridade.Text == string.Empty)
                {
                    Escolaridade escolaridade = new Escolaridade();
                    escolaridade.escolaridade1 = txtEscolaridade.Text;
                    context.Escolaridade.Add(escolaridade);
                    context.SaveChanges();
                    limpar();
                    Desabilitar();
                    MessageBox.Show("Registro salvo com sucesso!", "Atenção!");

                }
                else
                {
                    Escolaridade escolaridade = context.Escolaridade.Find(Convert.ToInt32(txtIdEscolaridade.Text));
                    escolaridade.escolaridade1 = txtEscolaridade.Text;
                    context.Entry(escolaridade);
                    context.SaveChanges();
                    limpar();
                    Desabilitar();
                    MessageBox.Show("Registro alterado com sucesso!", "Atenção!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            Escolaridade escolaridade = context.Escolaridade.Find(Convert.ToInt32(txtIdEscolaridade.Text));
            context.Escolaridade.Remove(escolaridade);
            context.SaveChanges();
            limpar();
            Desabilitar();
            MessageBox.Show("Registro removido", "Atenção");
        }

        private void txtIdEscolaridade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities factory = new registro_pontoEntities();
                Escolaridade escolaridade = factory.Escolaridade.Find(Convert.ToInt32(txtIdEscolaridade.Text));
                if (escolaridade == null)
                {
                    MessageBox.Show("Registro não encontrado", "Atenção");
                }
                else
                {
                    txtIdEscolaridade.Text = escolaridade.Id.ToString();
                    txtEscolaridade.Text = escolaridade.escolaridade1;
                    Habilitar();
                    txtEscolaridade.Focus();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocEscolaridade locEscolaridade = new LocEscolaridade();
            locEscolaridade.ShowDialog();
            if (locEscolaridade.codSelecionado >= 0)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Escolaridade escolaridade = context.Escolaridade.Find(locEscolaridade.codSelecionado);
                txtIdEscolaridade.Text = escolaridade.Id.ToString();
                txtEscolaridade.Text = escolaridade.escolaridade1;
                Habilitar();
            }
        }
    }
}
