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
using System.Drawing.Imaging;

namespace Projeto
{


    public partial class FormFuncionario : Form
    {
        registro_pontoEntities context = new registro_pontoEntities();


        public FormFuncionario()
        {
            InitializeComponent();
            Desabilitar();
            CarregarEscolaridade();
            CarregaDepartamento();
            CarregaFuncao();
            CarregaJornada();
            CarregaEstado();
            CarregaEstadoCarteira();
            CarregaEstadoRg();
            comboEstado.SelectedIndex = -1;
            comboCidade.SelectedIndex = -1;
            comboEscolaridade.SelectedIndex = -1;
            comboUF.SelectedIndex = -1;
            CarregaBanco();
            comboBanco.SelectedIndex = -1;

        }

        public void CarregaEstado()
        {
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.DataSource = context.Estado.ToList();
            comboEstado.ValueMember = "Id";
            comboEstado.DisplayMember = "Nome";
            comboEstado.Update();
        }

        public void CarregaEstadoCarteira()
        {
            comboEstadoCarteira.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoCarteira.DataSource = context.Estado.ToList();
            comboEstadoCarteira.ValueMember = "Id";
            comboEstadoCarteira.DisplayMember = "Nome";
            comboEstadoCarteira.Update();
        }

        public void CarregaEstadoRg()
        {
            comboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUF.DataSource = context.Estado.ToList();
            comboUF.ValueMember = "Id";
            comboUF.DisplayMember = "uf";
            comboUF.Update();
        }

        public void CarregaCidade(int idEstado)
        {
            comboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCidade.DataSource = context.Cidade.Where(b => b.Estado.Id == idEstado).ToList();
            comboCidade.ValueMember = "Id";
            comboCidade.DisplayMember = "nomeCidade";
            comboCidade.Update();
        }

        public void CarregarEscolaridade()
        {
            comboEscolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEscolaridade.DataSource = context.Escolaridade.ToList();
            comboEscolaridade.ValueMember = "Id";
            comboEscolaridade.DisplayMember = "escolaridade1";
            comboEscolaridade.Update();
        }

        public void CarregaDepartamento()
        {
            comboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartamento.DataSource = context.Departamento.ToList();
            comboDepartamento.ValueMember = "Id";
            comboDepartamento.DisplayMember = "departamento1";
            comboDepartamento.Update();
        }

        public void CarregaFuncao()
        {
            comboFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFuncao.DataSource = context.Funcao_Cargo.ToList();
            comboFuncao.ValueMember = "Id";
            comboFuncao.DisplayMember = "descricao";
            comboFuncao.Update();
        }

        public void CarregaJornada()
        {
            comboJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJornada.DataSource = context.Jornada.ToList();
            comboJornada.ValueMember = "Id";
            comboJornada.DisplayMember = "descricao";
        }

        public void CarregaBanco()
        {
            comboBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBanco.DataSource = context.Banco.ToList();
            comboBanco.ValueMember = "Id";
            comboBanco.DisplayMember = "Banco1";
        }


        public void Desabilitar()
        {
            btNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLocalizar.Enabled = true;
            btnExcluir.Enabled = false;
            txtId.Enabled = true;
            txtNome.Enabled = false;
            dtpDataNascimento.Enabled = false;
            rdbFeminino.Enabled = false;
            rdbMasculino.Enabled = false;
            comboEscolaridade.Enabled = false;
            txtEmail.Enabled = false;
            txtFoneRes.Enabled = false;
            txtFoneCel.Enabled = false;
            mtbCep.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            comboEstado.Enabled = false;
            comboCidade.Enabled = false;
            btnCarregarImagem.Enabled = false;

        }

        public void Habilitar()
        {
            txtId.Enabled = false;
            btNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = true;
            txtNome.Enabled = true;
            dtpDataNascimento.Enabled = true;
            rdbFeminino.Enabled = true;
            rdbMasculino.Enabled = true;
            comboEscolaridade.Enabled = true;
            txtEmail.Enabled = true;
            txtFoneRes.Enabled = true;
            txtFoneCel.Enabled = true;
            mtbCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            comboEstado.Enabled = true;
            comboCidade.Enabled = true;
            btnCarregarImagem.Enabled = true;
        }

        public void limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            comboEscolaridade.SelectedIndex = -1;
            txtEmail.Clear();
            txtFoneRes.Clear();
            txtFoneCel.Clear();
            mtbCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            comboEstado.SelectedIndex = -1;
            comboCidade.SelectedIndex = -1;
            picLogo.Image = null;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do funcionário!", "Atenção!");
                txtNome.Focus();
            }
            else if (dtpDataNascimento.Text == "")
            {
                MessageBox.Show("Informe a data de nascimento!", "Atenção!");
                dtpDataNascimento.Focus();
            }
            else if (rdbFeminino.Checked == false && rdbMasculino.Checked == false)
            {
                MessageBox.Show("Informe o sexo!", "Atenção!");
            }
            else if (comboEscolaridade.SelectedItem == null)
            {
                MessageBox.Show("Informe a escolaridade!", "Atenção!");
                comboEscolaridade.Focus();
            }
            else if (comboCidade.SelectedItem == null)
            {
                MessageBox.Show("Informe a cidade!", "Atenção!");
                comboCidade.Focus();
            }

            else
            {
                if (txtId.Text == string.Empty)
                {


                    //Novo
                    Funcionario funcionario = new Funcionario();
                    funcionario.nome = txtNome.Text;
                    funcionario.dataNascimento = DateTime.Parse(dtpDataNascimento.Text);
                    if (rdbFeminino.Checked)
                    {
                        funcionario.sexo = "f";
                    }
                    else
                    {
                        funcionario.sexo = "m";
                    }

                    Escolaridade esc = context.Escolaridade.Find(Convert.ToInt32(comboEscolaridade.SelectedValue));
                    funcionario.Escolaridade = esc;
                    funcionario.idEscolaridade = funcionario.Escolaridade.Id;
                    funcionario.email = txtEmail.Text;
                    funcionario.foneResidencial = txtFoneRes.Text;
                    funcionario.foneCelular = txtFoneCel.Text;
                    funcionario.cep = mtbCep.Text;
                    funcionario.logradouro = txtLogradouro.Text;
                    funcionario.numero = txtNumero.Text;
                    funcionario.complemento = txtComplemento.Text;
                    funcionario.bairro = txtBairro.Text;
                    Cidade cid = context.Cidade.Find(Convert.ToInt32(comboCidade.SelectedValue));
                    funcionario.Cidade = cid;
                    funcionario.idCidade = funcionario.Cidade.Id;
                    funcionario.carteiraTrabalho = txtCarteira.Text;
                    funcionario.serieCarteira = txtSerie.Text;
                    //Estado est = context.Estado.Find(Convert.ToInt32(comboEstadoCarteira.SelectedValue));
                    //funcionario.Estado = est;
                    if (dtpDataEmissão.Text != string.Empty)
                        funcionario.dataEmissao = DateTime.Parse(dtpDataEmissão.Text);
                    funcionario.cpf = mtbCpf.Text;
                    funcionario.rg = txtRg.Text;
                    if (dtpDtEmissaoRG.Text != string.Empty)
                        funcionario.dataEmissaoRg = DateTime.Parse(dtpDtEmissaoRG.Text);
                    funcionario.orgaoExpeditor = txtOrgaoExpeditor.Text;
                    if (comboUF.Text != string.Empty)
                    {
                        Estado estRg = context.Estado.Find(Convert.ToInt32(comboUF.SelectedValue));
                        funcionario.EstadoRG = estRg;
                    }

                    funcionario.numeroPis = txtPis.Text;
                    if (dtpDataPis.Text != string.Empty)
                        funcionario.dataCadastro = DateTime.Parse(dtpDataPis.Text);
                    funcionario.agencia = txtAgencia.Text;
                    funcionario.codigoAgencia = txtCodAgencia.Text;
                    Cidade cidade = context.Cidade.Find(Convert.ToInt32(comboCidade.SelectedValue));
                    funcionario.Cidade = cidade;
                    funcionario.idCidade = funcionario.Cidade.Id;
                    Departamento dep = context.Departamento.Find(Convert.ToInt32(comboDepartamento.SelectedValue));
                    funcionario.Departamento = dep;
                    Funcao_Cargo funcao = context.Funcao_Cargo.Find(Convert.ToInt32(comboFuncao.SelectedValue));
                    funcionario.Funcao_Cargo = funcao;
                    Jornada jornada = context.Jornada.Find(Convert.ToInt32(comboJornada.SelectedValue));
                    funcionario.Jornada = jornada;
                    Banco banco = context.Banco.Find(Convert.ToInt32(comboBanco.SelectedValue));
                    funcionario.Banco1 = banco;
                    string caminhoFoto = @"C:\Carol\ADS\4 SEMESTRE\POOA\ProjetoOficial\Projeto\Projeto\bin\Debug\image\" + funcionario.nome + "_" + funcionario.cpf.Replace(".", "").Replace("-", "") + ".jpg";
                    picLogo.Image.Save(caminhoFoto, ImageFormat.Jpeg);
                    funcionario.foto = caminhoFoto;
                    context.Funcionario.Add(funcionario);
                    context.SaveChanges();
                    txtId.Text = funcionario.Id.ToString();
                    MessageBox.Show("Registro salvo com sucesso", "Atenção");
                }
                //EDITAR
                else
                {
                    Funcionario funcionario = context.Funcionario.Find(Convert.ToInt32(txtId.Text));
                    funcionario.nome = txtNome.Text;
                    funcionario.dataNascimento = DateTime.Parse(dtpDataNascimento.Text);
                    if (rdbFeminino.Checked)
                    {
                        funcionario.sexo = "f";
                    }
                    else
                    {
                        funcionario.sexo = "m";
                    }
                    Escolaridade esc = context.Escolaridade.Find(Convert.ToInt32(comboEscolaridade.SelectedValue));
                    funcionario.Escolaridade = esc;
                    funcionario.idEscolaridade = funcionario.Escolaridade.Id;
                    funcionario.email = txtEmail.Text;
                    funcionario.foneResidencial = txtFoneRes.Text;
                    funcionario.foneCelular = txtFoneCel.Text;
                    funcionario.cep = mtbCep.Text;
                    funcionario.logradouro = txtLogradouro.Text;
                    funcionario.numero = txtNumero.Text;
                    funcionario.complemento = txtComplemento.Text;
                    funcionario.bairro = txtBairro.Text;
                    Cidade cid = context.Cidade.Find(Convert.ToInt32(comboCidade.SelectedValue));
                    funcionario.Cidade = cid;
                    funcionario.idCidade = funcionario.Cidade.Id;
                    funcionario.carteiraTrabalho = txtCarteira.Text;
                    funcionario.serieCarteira = txtSerie.Text;
                    //Estado est = context.Estado.Find(Convert.ToInt32(comboEstadoCarteira.SelectedValue));
                    //funcionario.Estado = est;
                    if (dtpDataEmissão.Text != string.Empty)
                        funcionario.dataEmissao = DateTime.Parse(dtpDataEmissão.Text);
                    funcionario.cpf = mtbCpf.Text;
                    funcionario.rg = txtRg.Text;
                    if (dtpDtEmissaoRG.Text != string.Empty)
                        funcionario.dataEmissaoRg = DateTime.Parse(dtpDtEmissaoRG.Text);
                    funcionario.orgaoExpeditor = txtOrgaoExpeditor.Text;
                    if (comboUF.Text != string.Empty)
                    {
                        Estado estRg = context.Estado.Find(Convert.ToInt32(comboUF.SelectedValue));
                        funcionario.EstadoRG = estRg;
                    }

                    funcionario.numeroPis = txtPis.Text;
                    if (dtpDataPis.Text != string.Empty)
                        funcionario.dataCadastro = DateTime.Parse(dtpDataPis.Text);
                    funcionario.banco = comboBanco.Text;
                    funcionario.agencia = txtAgencia.Text;
                    funcionario.codigoBanco = txtCodBanco.Text;
                    funcionario.codigoAgencia = txtCodAgencia.Text;
                    Cidade cidade = context.Cidade.Find(Convert.ToInt32(comboCidade.SelectedValue));
                    funcionario.Cidade = cidade;
                    funcionario.idCidade = funcionario.Cidade.Id;
                    Departamento dep = context.Departamento.Find(Convert.ToInt32(comboDepartamento.SelectedValue));
                    funcionario.Departamento = dep;
                    Funcao_Cargo funcao = context.Funcao_Cargo.Find(Convert.ToInt32(comboFuncao.SelectedValue));
                    funcionario.Funcao_Cargo = funcao;
                    context.Entry(funcionario);
                    context.SaveChanges();
                    MessageBox.Show("Registro alterado com sucesso", "Atenção");

                }
            }
        }

        private void comboEstado_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstado.SelectedIndex > -1)
            {
                Estado estado = (Estado)comboEstado.SelectedItem;
                CarregaCidade(estado.Id);
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Funcionario func = context.Funcionario.Find(Convert.ToInt32(txtId.Text));

                if (func != null)
                {
                    preenchetela(func);
                    Habilitar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado", "Atenção!");
                }

            }
        }

        private void preenchetela(Funcionario func)
        {
            txtId.Text = func.Id.ToString();
            txtNome.Text = func.nome;
            dtpDataNascimento.Value = func.dataNascimento;
            if (func.sexo == "m")
            {
                rdbMasculino.Checked = true;
            }
            else
            {
                rdbFeminino.Checked = true;
            }
            comboEscolaridade.SelectedValue = func.idEscolaridade;
            txtEmail.Text = func.email;
            txtFoneRes.Text = func.foneResidencial;
            txtFoneCel.Text = func.foneCelular;
            mtbCep.Text = func.cep;
            txtLogradouro.Text = func.logradouro;
            txtNumero.Text = func.numero;
            txtComplemento.Text = func.complemento;
            txtBairro.Text = func.bairro;
            comboEstado.SelectedValue = func.Cidade.Estado.Id;
            comboCidade.SelectedValue = func.idCidade;
            txtCarteira.Text = func.carteiraTrabalho;
            txtSerie.Text = func.serieCarteira;
            if (func.idEstadoCTPS != null)
                comboEstadoCarteira.SelectedValue = func.EstadoRG.Id;
            dtpDataEmissão.Value = (DateTime) func.dataEmissao;
            mtbCpf.Text = func.cpf;
            txtRg.Text = func.rg;
            if (func.dataEmissao != null)
                dtpDataEmissão.Value = (DateTime)func.dataEmissaoRg;
            txtOrgaoExpeditor.Text = func.orgaoExpeditor;
            if (func.EstadoRG!=null)
                comboUF.SelectedValue = func.EstadoRG.Id;
            txtPis.Text = func.numeroPis;
            dtpDataPis.Value = (DateTime)func.dataCadastro;
            if (func.banco != null)
                comboBanco.SelectedValue = func.Banco1.Id;
            if (func.agencia != null)
                txtAgencia.Text = func.agencia;
            if (func.codigoAgencia != null)
                txtCodAgencia.Text = func.codigoAgencia;
            if (func.foto != null && func.foto != "")
                picLogo.Image = new Bitmap(new Bitmap(func.foto), picLogo.Size);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sim ou não?", "Deseja excluir?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                registro_pontoEntities context = new registro_pontoEntities();
                Funcionario func = context.Funcionario.Find(Convert.ToInt32(txtId.Text));
                context.Funcionario.Remove(func);
                context.SaveChanges();
                limpar();
                Desabilitar();
                MessageBox.Show("Registro excluido!", "Atenção!");
            }
        }

        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            picLogo.Image = Image.FromFile(ofdLogo.FileName);
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria um objeto OpenFileDialog
                OpenFileDialog openFile1 = new OpenFileDialog();
                openFile1.Title = "Procurar Imagem";
                openFile1.InitialDirectory = @"C:\";
                openFile1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                openFile1.FilterIndex = 2;
                openFile1.RestoreDirectory = true;

                if (openFile1.ShowDialog() == DialogResult.OK)
                {

                    picLogo.Image = new Bitmap(new Bitmap(openFile1.FileName), picLogo.Size);
                    //picLogo.Image.Save(@"C:\Carol\teste.jpg", ImageFormat.Jpeg);
                   
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Inserir imagem : " + ex);
            }
        }
    }

}

