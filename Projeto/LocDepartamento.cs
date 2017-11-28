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
    public partial class LocDepartamento : Form
    {
        public int codSelecionado { get; set; } = -1;
        public LocDepartamento()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvDepartamento.AutoGenerateColumns = false;
            dgvDepartamento.DataSource = context.Departamento.ToList();
        }

        private void btnSelecionarAbono_Click(object sender, EventArgs e)
        {
            this.codSelecionado = Convert.ToInt32(dgvDepartamento.Rows[dgvDepartamento.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnCancelarAbono_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscarAbono_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvDepartamento.DataSource = context.Departamento.Where(b => b.departamento1.StartsWith(txtPesquisa.Text)).ToList();
        }
    }
}
