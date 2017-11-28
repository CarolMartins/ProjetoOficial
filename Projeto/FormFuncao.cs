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
    public partial class FormFuncao : Form
    {
        public FormFuncao()
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
            txtFuncao.Enabled = false;
        }

        public void Habilitar()
        {
            btNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtId.Enabled = false;
            txtFuncao.Enabled = true;
        }

        public void limpar()
        {
            txtId.Clear();
            txtFuncao.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            limpar();
            txtFuncao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtFuncao.Text == "")
            {
                MessageBox.Show("Informe a descrição da Função!", "Atenção");
                txtFuncao.Focus();
            }
            else
            {
                registro_pontoEntities context = new registro_pontoEntities();
                if(txtId.Text == string.Empty)
                {
                    Funcao_Cargo funcao = new Funcao_Cargo();
                    funcao.descricao = txtFuncao.Text;
                    context.Funcao_Cargo.Add(funcao);
                    MessageBox.Show("Registro salvo com sucesso", "Atenção");
                }
                //editar
                else
                {
                    Funcao_Cargo funcao = context.Funcao_Cargo.Find(Convert.ToInt32(txtId.Text));
                    funcao.descricao = txtFuncao.Text;
                    context.Entry(funcao);
                    MessageBox.Show("Registro alterado com sucesso", "Atenção");
                }
                context.SaveChanges();
                limpar();
                Desabilitar();
                

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
            Funcao_Cargo funcao = context.Funcao_Cargo.Find(Convert.ToInt32(txtId.Text));
            context.Funcao_Cargo.Remove(funcao);
            context.SaveChanges();
            limpar();
            Desabilitar();
            MessageBox.Show("Registro Removido", "Atenção");
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Funcao_Cargo funcao = context.Funcao_Cargo.Find(Convert.ToInt32(txtId.Text));
                if(funcao == null)
                {
                    MessageBox.Show("Registro não encontrado!", "Atenção!");
                }
                else
                {
                    txtId.Text = funcao.Id.ToString();
                    txtFuncao.Text = funcao.descricao;
                    Habilitar();
                    txtFuncao.Focus();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocFuncaoCargo locFuncao_Cargo = new LocFuncaoCargo();
            locFuncao_Cargo.ShowDialog();
            if (locFuncao_Cargo.codSelecionado >= 0)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Funcao_Cargo funcao = context.Funcao_Cargo.Find(locFuncao_Cargo.codSelecionado);
                txtId.Text = funcao.Id.ToString();
                txtFuncao.Text = funcao.descricao;
                Habilitar();
            }
        }
    }
}
