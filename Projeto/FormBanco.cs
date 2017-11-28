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
    public partial class FormBanco : Form
    {
        public FormBanco()
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
            txtId.Enabled = true;
            txtBanco.Enabled = false;
            txtCodBanco.Enabled = false;
        }

        public void Habilitar()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtId.Enabled = false;
            txtBanco.Enabled = true;
            txtCodBanco.Enabled = true;
        }

        public void limpar()
        {
            txtId.Clear();
            txtBanco.Clear();
            txtCodBanco.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            Habilitar();
            txtBanco.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            Desabilitar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            if (txtId.Text == string.Empty)
            {
                //Novo
                Banco banco = new Banco();
                banco.Banco1 = txtBanco.Text;
                banco.CodigoBanco = Convert.ToInt32(txtCodBanco.Text);
                context.Banco.Add(banco);
                context.SaveChanges();
                limpar();
                Desabilitar();
                MessageBox.Show("Registro salvo com sucesso!", "Atenção");
            }
            else
            {
                //Editar
                Banco banco = context.Banco.Find(Convert.ToInt32(txtId.Text));
                banco.Banco1 = txtBanco.Text;
                banco.CodigoBanco = Convert.ToInt32(txtCodBanco.Text);
                context.Entry(banco);
                context.SaveChanges();
                limpar();
                Desabilitar();
                MessageBox.Show("Registro alterado com sucesso!", "Atenção");
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Banco banco = context.Banco.Find(Convert.ToInt32(txtId.Text));
                if (banco != null)
                {
                    Habilitar();
                    txtId.Text = banco.Id.ToString();
                    txtBanco.Text = banco.Banco1;
                    txtCodBanco.Text = banco.CodigoBanco.ToString();
                    txtBanco.Focus();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado", "Atenção");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            Banco banco = context.Banco.Find(Convert.ToInt32(txtId.Text));
            context.Banco.Remove(banco);
            context.SaveChanges();
            Desabilitar();
            limpar();
            MessageBox.Show("Registro excluído", "Atenção");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            LocBanco locBanco = new LocBanco();
            locBanco.ShowDialog();
            if (locBanco.codSelecionado >= 0)
            {
                Banco banco = context.Banco.Find(locBanco.codSelecionado);
                txtId.Text = banco.Id.ToString();
                txtBanco.Text = banco.Banco1;
                txtCodBanco.Text = banco.CodigoBanco.ToString();
                Habilitar();
            }
        }
    }
}
