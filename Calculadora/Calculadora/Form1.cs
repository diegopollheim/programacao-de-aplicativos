using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal resultado = 0;

            if (ttbValor1.Text != "" && ttbValor2.Text != "")
            {
                valor1 = Convert.ToDecimal(ttbValor1.Text);
                valor2 = Convert.ToDecimal(ttbValor2.Text);
                resultado = valor1 + valor2;
                ttbValor1.Clear();
                ttbValor2.Clear();
                lbResultado.Text = Convert.ToString(resultado);
            }
            else
                MessageBox.Show("Verifique o preenchimento dos campos Valor 1 e Valor 2.");
        }
    }
}
