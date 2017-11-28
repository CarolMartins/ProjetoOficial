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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartamento departamento = new FormDepartamento();
            departamento.ShowDialog();

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpresa empresa = new FormEmpresa();
            empresa.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionario = new FormFuncionario();
            funcionario.ShowDialog();
        }

        private void jornadaDeTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJornada jornada = new FormJornada();
            jornada.ShowDialog();
        }

        private void funçãoCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncao funcao = new FormFuncao();
            funcao.ShowDialog();
        }

        private void abonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbono abono = new FormAbono();
            abono.ShowDialog();
        }

        private void escolaridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEscolaridade escolaridade = new FormEscolaridade();
            escolaridade.ShowDialog();
        }

        private void importaçãoAFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportacao formImportacao = new FormImportacao();
            formImportacao.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOcorrencia form = new FormOcorrencia();
            form.ShowDialog();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanco formBanco = new FormBanco();
            formBanco.ShowDialog();
        }
    }   
}

