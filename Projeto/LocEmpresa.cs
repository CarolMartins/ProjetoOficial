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
    public partial class LocEmpresa : Form
    {
        public int codSelecionado { get; set; } = -1;
        public LocEmpresa()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvEmpresa.AutoGenerateColumns = false;
            dgvEmpresa.DataSource = context.Empresa.ToList();
        }

        private void btnCancelarAbono_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSelecionarAbono_Click(object sender, EventArgs e)
        {
            this.codSelecionado = Convert.ToInt32(dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvEmpresa.DataSource = context.Empresa.Where(b => b.razaoSocial.StartsWith(txtPesquisa.Text)).ToList();
        }
    }
}
