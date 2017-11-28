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
    public partial class FormAbono : Form
    {
        public FormAbono()
        {
            InitializeComponent();
            Desabilitar();
        }

        public void Desabilitar()
        {
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnLocalizar.Enabled = true;
            btnExcluir.Enabled = false;
            txtId.Enabled = true;
            txtTipoAbono.Enabled = false;
        }

        public void Habilitar()
        {
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btnEditar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtId.Enabled = false;
            txtTipoAbono.Enabled = true;
        }

        public void limpar()
        {
            txtId.Clear();
            txtTipoAbono.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            limpar();
            txtTipoAbono.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            TipoAbono tipoAbono = context.TipoAbono.Find(Convert.ToInt32(txtId.Text));
            context.TipoAbono.Remove(tipoAbono);
            context.SaveChanges();
            limpar();
            Desabilitar();
            MessageBox.Show("Registro removido", "Atenção");
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtTipoAbono.Text == "")
            {
                MessageBox.Show("Informe a descrição do tipo de Abono!","Atenção!");
                txtTipoAbono.Focus();
            }
            else
            {
                registro_pontoEntities context = new registro_pontoEntities();
                if (txtId.Text == string.Empty)
                {
                    //Novo
                    TipoAbono tipoAbono = new TipoAbono();
                    tipoAbono.tipoAbono1 = txtTipoAbono.Text;
                    context.TipoAbono.Add(tipoAbono);
                    MessageBox.Show("Registro salvo com sucesso", "Atenção");
                }
                else
                {
                    TipoAbono tipoabono = context.TipoAbono.Find(Convert.ToInt32(txtId.Text));
                    tipoabono.tipoAbono1 = txtTipoAbono.Text;
                    context.Entry(tipoabono);
                    MessageBox.Show("Registro alterado com sucesso", "Atenção");
                }

                context.SaveChanges();

                limpar();
                Desabilitar();
                
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities factory = new registro_pontoEntities();
                TipoAbono tipoabono = factory.TipoAbono.Find(Convert.ToInt32(txtId.Text));
                if (tipoabono == null)
                {
                    MessageBox.Show("Registro não encontrado", "Atenção");
                }
                else
                {
                    txtId.Text = tipoabono.Id.ToString();
                    txtTipoAbono.Text = tipoabono.tipoAbono1;
                    Habilitar();
                    txtTipoAbono.Focus();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocTipoAbono locTipoAbono = new LocTipoAbono();
            locTipoAbono.ShowDialog();
            if (locTipoAbono.selecionado >= 0)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                TipoAbono tipoAbono = context.TipoAbono.Find(locTipoAbono.selecionado);
                txtId.Text = tipoAbono.Id.ToString();
                txtTipoAbono.Text = tipoAbono.tipoAbono1;
                Habilitar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            limpar();
        }
    }
}

