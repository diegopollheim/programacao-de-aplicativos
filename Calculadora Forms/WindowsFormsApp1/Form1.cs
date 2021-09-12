using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Contains(",") && tela.Text.Contains(","))
            {
                tela.Text += "";
            }
            else
            {
                tela.Text += btn.Text;
                lbl.Text += tela.Text;
            }
            if (tela.Text == "" && btn.Text == ",")
            {
                tela.Text = "0";
            }
        }

        private void btn_Operacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            num1 = Double.Parse(tela.Text);
            tela.Clear();

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(tela.Text);
            tela.Clear();
            CalcularResultado(num1, num2, op);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela.Clear();
            num1 = 0;
            num2 = 0;
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            string aux = tela.Text;
            tela.Clear();
            char[] r = aux.ToArray();

            for (int i = 0; i < r.Length - 1; i++)
            {
                tela.Text += r[i];
            }
        }


        private void CalcularResultado(double num1, double num2, string op)
        {

            double res = 0;
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }
            tela.Clear();
            tela.Text = res.ToString();
        }
    }
}
