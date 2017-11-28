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
    public partial class LocBanco : Form
    {
        public int codSelecionado { get; set; } = -1;
        public LocBanco()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvbanco.AutoGenerateColumns = false;
            dgvbanco.DataSource = context.Banco.ToList();
            
        }

        private void btnSelecionarBanco_Click(object sender, EventArgs e)
        {
            this.codSelecionado = Convert.ToInt32(dgvbanco.Rows[dgvbanco.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnCancelarCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvbanco.DataSource = context.Banco.Where(b => b.Banco1.StartsWith(txtPesquisa.Text)).ToList();
        }
    }
}
