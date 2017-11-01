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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            ofdLogo.FileName = "";
            ofdLogo.Title = "Selecione uma foto";
            ofdLogo.Filter = "JPEG|*.JPG|PNG|*.png";
            ofdLogo.ShowDialog();
        }

        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            picLogo.Image = Image.FromFile(ofdLogo.FileName);
        }
    }
}
