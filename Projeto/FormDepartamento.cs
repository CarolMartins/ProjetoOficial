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
    public partial class FormDepartamento : Form
    {
        public FormDepartamento()
        {
            InitializeComponent();
            Desabilitar();
        }

        public void Desabilitar()
        {
            btNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLocalizar.Enabled = true;
            btnExcluir.Enabled = false;
            txtId.Enabled = true;
            txtDepartamento.Enabled = false;
        }

        public void Habilitar()
        {
            btNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtId.Enabled = false;
            txtDepartamento.Enabled = true;
        }

        public void limpar()
        {
            txtId.Clear();
            txtDepartamento.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpar();
            Habilitar();
            txtDepartamento.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            if (txtId.Text == string.Empty)
            {
                //Novo
                Departamento departamento = new Departamento();
                departamento.departamento1 = txtDepartamento.Text;
                context.Departamento.Add(departamento);
                context.SaveChanges();
                limpar();
                Desabilitar();
                MessageBox.Show("Registro salvo com sucesso!", "Atenção");
            }
            else
            {
                //Editar
                Departamento departamento = context.Departamento.Find(Convert.ToInt32(txtId.Text));
                departamento.departamento1 = txtDepartamento.Text;
                context.Entry(departamento);
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
                Departamento departamento = context.Departamento.Find(Convert.ToInt32(txtId.Text));
                if (departamento != null)
                {
                    Habilitar();
                    txtId.Text = departamento.Id.ToString();
                    txtDepartamento.Text = departamento.departamento1;
                    txtDepartamento.Focus();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado", "Atenção");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            Desabilitar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            Departamento departamento = context.Departamento.Find(Convert.ToInt32(txtId.Text));
            context.Departamento.Remove(departamento);
            context.SaveChanges();
            Desabilitar();
            limpar();
            MessageBox.Show("Registro excluído", "Atenção");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            LocDepartamento locDepartamento = new LocDepartamento();
            locDepartamento.ShowDialog();
            if (locDepartamento.codSelecionado >= 0)
            {
                Departamento departamento = context.Departamento.Find(locDepartamento.codSelecionado);
                txtId.Text = departamento.Id.ToString();
                txtDepartamento.Text = departamento.departamento1;
                Habilitar();
            }
        }
    }
}
