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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
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
            txtIdEmpresa.Enabled = true;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtCnpj.Enabled = false;
        }

        public void Habilitar()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtIdEmpresa.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtCnpj.Enabled = true;
        }

        public void limpar()
        {
            txtIdEmpresa.Clear();
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCnpj.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            limpar();
            txtRazaoSocial.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Informe a Razão Social!", "Atenção!");
                txtRazaoSocial.Focus();
            }
            else if (txtCnpj.Text == "")
            {
                MessageBox.Show("Informe o CNPJ", "Atenção!");
                txtCnpj.Focus();
            }
            else
            {
                registro_pontoEntities context = new registro_pontoEntities();
                if(txtIdEmpresa.Text == string.Empty)
                {
                    Empresa empresa = new Empresa();
                    empresa.razaoSocial = txtRazaoSocial.Text;
                    empresa.nomeFantasia = txtNomeFantasia.Text;
                    empresa.cnpj = txtCnpj.Text;
                    context.Empresa.Add(empresa);
                    context.SaveChanges();
                    limpar();
                    Desabilitar();
                    MessageBox.Show("Registro salvo com sucesso!", "Atenção!");
                    
                }
                else
                {
                    Empresa empresa = context.Empresa.Find(Convert.ToInt32(txtIdEmpresa.Text));
                    empresa.razaoSocial = txtRazaoSocial.Text;
                    empresa.nomeFantasia = txtNomeFantasia.Text;
                    empresa.cnpj = txtCnpj.Text;
                    context.Entry(empresa);
                    context.SaveChanges();
                    limpar();
                    Desabilitar();
                    MessageBox.Show("Registro alterado com sucesso!", "Atenção!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            Empresa empresa = context.Empresa.Find(Convert.ToInt32(txtIdEmpresa.Text));
            context.Empresa.Remove(empresa);
            context.SaveChanges();
            limpar();
            Desabilitar();
            MessageBox.Show("Registro removido", "Atenção");
        }

        private void txtIdEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities factory = new registro_pontoEntities();
                Empresa empresa = factory.Empresa.Find(Convert.ToInt32(txtIdEmpresa.Text));
                if (empresa == null)
                {
                    MessageBox.Show("Registro não encontrado", "Atenção");
                }
                else
                {
                    txtIdEmpresa.Text = empresa.Id.ToString();
                    txtRazaoSocial.Text = empresa.razaoSocial;
                    txtNomeFantasia.Text = empresa.nomeFantasia;
                    txtCnpj.Text = empresa.cnpj;
                    Habilitar();
                    txtRazaoSocial.Focus();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocEmpresa locEmpresa = new LocEmpresa();
            locEmpresa.ShowDialog();
            if (locEmpresa.codSelecionado >= 0)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Empresa empresa = context.Empresa.Find(locEmpresa.codSelecionado);
                txtIdEmpresa.Text = empresa.Id.ToString();
                txtRazaoSocial.Text = empresa.razaoSocial;
                txtNomeFantasia.Text = empresa.nomeFantasia;
                txtCnpj.Text = empresa.cnpj;
                Habilitar();
            }
        }
    }
}
