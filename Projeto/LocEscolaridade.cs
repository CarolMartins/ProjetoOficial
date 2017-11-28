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
    public partial class LocEscolaridade : Form
    {
        public int codSelecionado { get; set; } = -1;

        public LocEscolaridade()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvEscolaridade.AutoGenerateColumns = false;
            dgvEscolaridade.DataSource = context.Escolaridade.ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.codSelecionado = Convert.ToInt32(dgvEscolaridade.Rows[dgvEscolaridade.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvEscolaridade.DataSource = context.Escolaridade.Where(b => b.escolaridade1.StartsWith(txtPesquisa.Text)).ToList();
        }
    }
}
