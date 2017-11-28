using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Projeto
{
    public partial class FormImportacao : Form
    {

        registro_pontoEntities context = new registro_pontoEntities();

        public FormImportacao()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvImportacao.Rows.Clear();
            if (txtArquivo.Text != string.Empty)
            {
                string numfabrep = "";
                var lines = File.ReadAllLines(txtArquivo.Text);
                foreach (var line in lines)
                {
                    string pos1 = line.Substring(0, 9);
                    string pos2 = line.Substring(9, 1);

                    //Verifica se é linha de cabeçalho
                    if (pos1 == "000000000")
                    {
                        //Se for linha de cabeçalho pega número de fabricaçao do REP
                        numfabrep = line.Substring(187, 17);
                    }

                    //Verifica se é linha de marcação de ponto
                    //000000000 - Representa Cabeçalho
                    //999999999 - Representa linha de traler que fica ao final do arquivo
                    if (numfabrep!="" && pos1 != "000000000" && pos1 != "999999999" && pos2 == "3")
                    {
                        string data = line.Substring(10, 8);
                        string hora = line.Substring(18, 4);
                        string pis = line.Substring(22, 12);
                        string nsr = line.Substring(0, 9);
                        string erro = "";

                        //Valida numero de PIS
                        if (!validaPIS(pis))
                        {
                            erro += "PIS não encontrado no banco de dados";
                        }
                        if (!validaData(data))
                        {
                            erro += "|Data inválida";
                        }
                        if (!validaHora(hora))
                        {
                            erro += "|Hora inválida";
                        }

                        //Insere registro no Grid
                        dgvImportacao.Rows.Add(numfabrep, nsr, data.Substring(0, 2) + "/" + data.Substring(2, 2) + "/" + data.Substring(4, 4),
                                              hora.Substring(0, 2) + ":" + hora.Substring(2, 2), pis, erro);
                    }
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (dgvImportacao.Rows.Count > 0)
            {
                //Percorre os registros do gridview
                foreach (DataGridViewRow row in dgvImportacao.Rows)
                {
                    //Lê cada um dos registros
                    string numfabrep = row.Cells[0].Value.ToString();
                    string nsr  = row.Cells[1].Value.ToString();
                    string data = row.Cells[2].Value.ToString();
                    string hora = row.Cells[3].Value.ToString();
                    string pis  = row.Cells[4].Value.ToString();

                    //Busca importação no banco
                    Importacao imp = buscaImportacao(pis, nsr, numfabrep);
                    if (imp == null)
                    {
                        //Se não existe importação no banco insere uma nova marcação de ponto
                        imp = new Importacao();
                        imp.numfabrep = numfabrep;
                        imp.nsr = nsr;
                        imp.data = DateTime.Parse(data);
                        imp.hora = TimeSpan.Parse(hora);
                        imp.Funcionario = buscaFuncionaro(pis);
                        context.Importacao.Add(imp);
                        context.SaveChanges();
                    }
                    
                }
                MessageBox.Show("Registro salvos!", "Atenção!");
            }
            else
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Atenção!");
            }
        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtArquivo.Text = openFileDialog.FileName;
            }
        }

        private bool validaPIS(string pis)
        {
            bool valida = true;
            Funcionario func = context.Funcionario.Where(b => b.numeroPis == pis).SingleOrDefault();
            if (func == null)
                valida = false;
            return valida;
        }

        private bool validaData(string data)
        {
            string[] formats = {"ddMMyyyy"};
            DateTime aux;

            bool valida = DateTime.TryParseExact(data, formats,
                                                 new CultureInfo("pt-BR"),
                                                 DateTimeStyles.None,
                                                 out aux);

            return valida;
        }

        private bool validaHora(string hora)
        {
            string[] formats = {"HHmm"};
            DateTime aux;

            bool valida = DateTime.TryParseExact(hora, formats,
                                                 new CultureInfo("pt-BR"),
                                                 DateTimeStyles.None,
                                                 out aux);

            return valida;
        }

        private Funcionario buscaFuncionaro(string pis)
        {
            Funcionario func = null;
            func = context.Funcionario.Where(b => b.numeroPis == pis).SingleOrDefault();
            return func;
        }

        private Importacao buscaImportacao(string pis, string nsr, string numfabrep)
        {
            Importacao imp = null;
            imp = context.Importacao.
                Where(b => b.nsr == nsr && b.numfabrep == numfabrep && b.Funcionario.numeroPis == pis).
                SingleOrDefault();
            return imp;
        }
    }
}
