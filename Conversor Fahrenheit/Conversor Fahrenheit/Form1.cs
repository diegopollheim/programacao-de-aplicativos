using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                float fahrenheit = float.Parse(textBox.Text);
                float celsius = (fahrenheit - 32) * 5 / 9;
                textBox.Clear();

                MessageBox.Show($"{fahrenheit} Fahrenheit (F°) é equivalente a {celsius.ToString("N2")} Celsius (C°)","Resultado");
            }
            if (textBox.Text == "")
            {
                MessageBox.Show($"Insira um valor para fazer a conversão", "Atenção");
                textBox.Focus();
            }
            
        }
    }
}
