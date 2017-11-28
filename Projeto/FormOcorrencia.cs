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
    public partial class FormOcorrencia : Form
    {
        registro_pontoEntities context = new registro_pontoEntities();

        public FormOcorrencia()
        {
            InitializeComponent();
            carregarFuncionario();
        }

        private void carregarFuncionario()
        {
            comboFuncionario.DisplayMember = "nome";
            comboFuncionario.ValueMember = "id";
            comboFuncionario.DataSource = context.Funcionario.OrderBy(b=>b.nome).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvOcorrencias.AutoGenerateColumns = false;
            Funcionario func = ((Funcionario)comboFuncionario.SelectedItem);
            Importacao im = new Importacao();
            /*dgvOcorrencias.DataSource =
                context.Importacao.Where(b => b.Funcionario.Id == func.Id &&
                                            (b.data >= dtpInicial.Value && b.data <= dtpFinal.Value))
                                            .OrderBy(b=>b.nsr)
                                            .ToList();*/
            var query = from b in context.Importacao
                        where b.Funcionario.Id == func.Id &&
                                            (b.data >= dtpInicial.Value && b.data <= dtpFinal.Value)
                        select new {b.IDEntrada, b.nsr, b.Funcionario.nome, b.Funcionario.numeroPis, b.data, b.hora};
            dgvOcorrencias.DataSource = query.ToList();
        }
    }
}
