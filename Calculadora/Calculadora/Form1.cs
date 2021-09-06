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
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
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
                string caption = $"{valor1} + {valor2}";
                CaptionSoma.Text = caption.ToString();
                ResSoma.Text = $"Resultado = {resultado}";
            }
            else
                MessageBox.Show("Verifique o preenchimento dos campos valor 1 e valor 2", "Algo deu errado!");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal resultado = 0;

            if (subVal1Txt.Text != "" && subVal2Txt.Text != "")
            {
                valor1 = Convert.ToDecimal(subVal1Txt.Text);
                valor2 = Convert.ToDecimal(subVal2Txt.Text);
                resultado = valor1 - valor2;
                subVal1Txt.Clear();
                subVal2Txt.Clear();
                string caption = $"{valor1} - {valor2}";
                CaptionSubtracao.Text = caption.ToString();
                ResSubtracao.Text = $"Resultado = {resultado}";
            }
            else
                MessageBox.Show("Verifique o preenchimento dos campos valor 1 e valor 2", "Algo deu errado!");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal resultado = 0;

            if (txtVal1Multiplicar.Text != "" && txtVal2Multiplicar.Text != "")
            {
                valor1 = Convert.ToDecimal(txtVal1Multiplicar.Text);
                valor2 = Convert.ToDecimal(txtVal2Multiplicar.Text);
                resultado = valor1 * valor2;
                subVal1Txt.Clear();
                subVal2Txt.Clear();
                string caption = $"{valor1} * {valor2}";
                CaptionMultiplicacao.Text = caption.ToString();
                lbResultado.Text = Convert.ToString(resultado);
                ResMultiplicar.Text = $"Resultado = {resultado}";
            }
            else
                MessageBox.Show("Verifique o preenchimento dos campos valor 1 e valor 2", "Algo deu errado!");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (val1DivTxt.Text != "" && val2DivTxt.Text != "")
            {
                double valor1 = double.Parse(val1DivTxt.Text);
                double valor2 = double.Parse(val2DivTxt.Text);
                double res = valor1 / valor2;
                val1DivTxt.Clear();
                val2DivTxt.Clear();
                string caption = $"{valor1} / {valor2}";
                CaptionDivisao.Text = caption.ToString();
                lbResultado.Text = Convert.ToString(res);
                ResDivisao.Text = $"Resultado = {res}";
            }
            else
                MessageBox.Show("Verifique o preenchimento dos campos valor 1 e valor 2","Algo deu errado!");
        }
    }
}
