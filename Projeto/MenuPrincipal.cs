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
            Empresa empresa = new Empresa();
            empresa.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
        }
    }   
}

