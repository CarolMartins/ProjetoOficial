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
    public partial class LocTipoAbono : Form
    {
        public int selecionado { set; get; } = -1;


        public LocTipoAbono()
        {
            InitializeComponent();
            registro_pontoEntities context = new registro_pontoEntities();
            dgvAbono.AutoGenerateColumns = false;
            dgvAbono.DataSource = context.TipoAbono.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.selecionado = Convert.ToInt32(dgvAbono.Rows[dgvAbono.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void LocTipoAbono_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarAbono_Click(object sender, EventArgs e)
        {
            
            Dispose();
        }

        private void btnBuscarAbono_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            dgvAbono.DataSource =
                context.TipoAbono.
                   Where(b=>b.tipoAbono1.StartsWith(txtPesquisa.Text)).ToList();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAbono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
