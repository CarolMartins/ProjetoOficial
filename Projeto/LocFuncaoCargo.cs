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
    public partial class LocFuncaoCargo : Form
    {
        public int codSelecionado { set; get; } = -1;

        public LocFuncaoCargo()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvFuncao.DataSource = context.Funcao_Cargo.ToList();
        }

        private void btnCancelarAbono_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscarAbono_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvFuncao.DataSource = context.Funcao_Cargo.Where(b => b.descricao.StartsWith(txtPesquisa.Text)).ToList();
        }

        private void btnSelecionarFuncao_Click(object sender, EventArgs e)
        {
            this.codSelecionado = Convert.ToInt32(dgvFuncao.Rows[dgvFuncao.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }
    }
}
