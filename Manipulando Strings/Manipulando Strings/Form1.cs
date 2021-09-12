using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulando_Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtPalavra.Text.Length.ToString();
        }

        private void btnQtdPalavras_Click(object sender, EventArgs e)
        {
            string frase = txtPalavra.Text;
            string[] palavras = frase.Split(' ');
            txtResultado.Text = palavras.Length.ToString();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            string palavra = txtPalavra.Text;
            string palavraInvertida = "";

            for (int i = palavra.Length-1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }
            txtResultado.Text = palavraInvertida.ToString();
        }
    }
}
