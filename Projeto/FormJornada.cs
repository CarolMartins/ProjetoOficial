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
    public partial class FormJornada : Form
    {
        public FormJornada()
        {
            InitializeComponent();
            desabilitar();
            carregaGrid();
        }

        private void limpar()
        {
            txtIDJornada.Clear();
            txtDescricaoJornada.Clear();
            mtbEntrada1.Clear();
            mtbEntrada2.Clear();
            mtbSaida1.Clear();
            mtbSaida2.Clear();
            ckbSegunda.Checked = false;
            ckbTerca.Checked = false;
            ckbQuarta.Checked = false;
            ckbQuinta.Checked = false;
            ckbSexta.Checked = false;
            ckbSabado.Checked = false;
            ckbDomingo.Checked = false;
            ckbIndeterminado.Checked = false;
            txtJornadaTotal.Clear();
        }

        private void habilitar()
        {
            txtIDJornada.Enabled = false;
            txtDescricaoJornada.Enabled = true;
            mtbEntrada1.Enabled = true;
            mtbEntrada2.Enabled = true;
            mtbSaida1.Enabled = true;
            mtbSaida2.Enabled = true;
            ckbSegunda.Enabled = true;
            ckbTerca.Enabled = true;
            ckbQuarta.Enabled = true;
            ckbQuinta.Enabled = true;
            ckbSexta.Enabled = true;
            ckbSabado.Enabled = true;
            ckbDomingo.Enabled = true;
            ckbIndeterminado.Enabled = true;
            txtJornadaTotal.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void desabilitar()
        {
            txtIDJornada.Enabled = true;
            txtDescricaoJornada.Enabled = false;
            mtbEntrada1.Enabled = false;
            mtbEntrada2.Enabled = false;
            mtbSaida1.Enabled = false;
            mtbSaida2.Enabled = false;
            ckbSegunda.Enabled = false;
            ckbTerca.Enabled = false;
            ckbQuarta.Enabled = false;
            ckbQuinta.Enabled = false;
            ckbSexta.Enabled = false;
            ckbSabado.Enabled = false;
            ckbDomingo.Enabled = false;
            ckbIndeterminado.Enabled = false;
            txtJornadaTotal.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            registro_pontoEntities context = new registro_pontoEntities();
            if (txtDescricaoJornada.Text == "")
            {
                MessageBox.Show("Informe o tipo de jornada!", "Atenção!");
                txtDescricaoJornada.Focus();
            }
            else if (mtbEntrada1.Text == "  :")
            {
                MessageBox.Show("Informe a hora de entrada!", "Atenção!");
                mtbEntrada1.Focus();
            }
            else if (mtbSaida1.Text == "  :")
            {
                MessageBox.Show("Informe a hora de saída!", "Atenção!");
                mtbSaida1.Focus();
            }
            else if (!ckbSegunda.Checked)
            {
                MessageBox.Show("Escolha o dia da semana!", "Atenção!");
                ckbSegunda.Focus();
            }
            else
            {
                
                if (txtIDJornada.Text == string.Empty)
                {
                    //Novo
                    Jornada jornada = new Jornada();
                    jornada.descricao = txtDescricaoJornada.Text;
                    jornada.entrada1 = mtbEntrada1.Text;
                    jornada.saida1 = mtbSaida1.Text;
                    if (mtbEntrada2.Text != string.Empty)
                        jornada.entrada2 = mtbEntrada2.Text;
                    if (mtbSaida2.Text != string.Empty)
                        jornada.saida2 = mtbSaida2.Text;

                    if (ckbSegunda.Checked)
                        jornada.segundaFeira = 1;
                    else
                        jornada.segundaFeira = 0;

                    if (ckbTerca.Checked)
                        jornada.tercaFeira = 1;
                    else
                        jornada.tercaFeira = 0;

                    if (ckbQuarta.Checked)
                        jornada.quartaFeira = 1;
                    else
                        jornada.quartaFeira = 0;

                    if (ckbQuinta.Checked)
                        jornada.quintaFeira = 1;
                    else
                        jornada.quintaFeira = 0;

                    if (ckbSexta.Checked)
                        jornada.sextaFeira = 1;
                    else
                        jornada.sextaFeira = 0;

                    if (ckbSabado.Checked)
                        jornada.sabado = 1;
                    else
                        jornada.sabado = 0;

                    if (ckbDomingo.Checked)
                        jornada.domingo = 1;
                    else
                        jornada.domingo = 0;

                    if (ckbIndeterminado.Checked)
                        jornada.indeterminado = 1;
                    else
                        jornada.indeterminado = 0;

                    context.Jornada.Add(jornada);
                    context.SaveChanges();
                    limpar();
                    desabilitar();
                    carregaGrid();
                    MessageBox.Show("Registro salvo!", "Atenção!");
                }
                else
                {
                    //Editar
                    Jornada jornada = context.Jornada.Find(Convert.ToInt32(txtIDJornada.Text));
                    jornada.descricao = txtDescricaoJornada.Text;
                    jornada.entrada1 = mtbEntrada1.Text;
                    jornada.saida1 = mtbSaida1.Text;
                    if (mtbEntrada2.Text != string.Empty)
                        jornada.entrada2 = mtbEntrada2.Text;
                    if (mtbSaida2.Text != string.Empty)
                        jornada.saida2 = mtbSaida2.Text;

                    if (ckbSegunda.Checked)
                        jornada.segundaFeira = 1;
                    else
                        jornada.segundaFeira = 0;

                    if (ckbTerca.Checked)
                        jornada.tercaFeira = 1;
                    else
                        jornada.tercaFeira = 0;

                    if (ckbQuarta.Checked)
                        jornada.quartaFeira = 1;
                    else
                        jornada.quartaFeira = 0;

                    if (ckbQuinta.Checked)
                        jornada.quintaFeira = 1;
                    else
                        jornada.quintaFeira = 0;

                    if (ckbSexta.Checked)
                        jornada.sextaFeira = 1;
                    else
                        jornada.sextaFeira = 0;

                    if (ckbSabado.Checked)
                        jornada.sabado = 1;
                    else
                        jornada.sabado = 0;

                    if (ckbDomingo.Checked)
                        jornada.domingo = 1;
                    else
                        jornada.domingo = 0;

                    if (ckbIndeterminado.Checked)
                        jornada.indeterminado = 1;
                    else
                        jornada.indeterminado = 0;

                    context.Entry(jornada);
                    context.SaveChanges();
                    limpar();
                    desabilitar();
                    carregaGrid();
                    MessageBox.Show("Registro alterado!", "Atenção!");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            habilitar();
            txtDescricaoJornada.Focus();
        }

        private void carregaGrid()
        {
            dgvJornada.AutoGenerateColumns = false;
            registro_pontoEntities context = new registro_pontoEntities();
            dgvJornada.DataSource = context.Jornada.ToList();
        }

        private void dgvJornada_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ( (txtIDJornada.Text!=string.Empty) &&
                (MessageBox.Show("Sim ou não?", "Deseja excluir?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Jornada jornada = context.Jornada.Find(Convert.ToInt32(txtIDJornada.Text));
                context.Jornada.Remove(jornada);
                context.SaveChanges();
                limpar();
                desabilitar();
                carregaGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            desabilitar();
        }

        private void preenchertela(Jornada jornada)
        {
            txtIDJornada.Text = jornada.Id.ToString();
            txtDescricaoJornada.Text = jornada.descricao.ToString();
            mtbEntrada1.Text = jornada.entrada1;
            mtbSaida1.Text = jornada.saida1;
            mtbEntrada2.Text = jornada.entrada2;
            mtbSaida2.Text = jornada.saida2;
            if (jornada.segundaFeira == 1)
                ckbSegunda.Checked = true;
        }

        private void dgvJornada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJornada.Rows.Count > 0)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                int id = Convert.ToInt32(dgvJornada.Rows[dgvJornada.CurrentRow.Index].Cells[0].Value.ToString());
                Jornada jornada = context.Jornada.Find(id);
                preenchertela(jornada);
                habilitar();
                txtDescricaoJornada.Focus();
            }
        }
    }
}
