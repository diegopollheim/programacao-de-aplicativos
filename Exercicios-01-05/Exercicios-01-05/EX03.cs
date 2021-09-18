using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média_Consumo_Combustivel
{
    public partial class EX03 : Form
    {
        public EX03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double litrosGastos, mediaPorLitro, kmInicial, kmFinal, kmRodados;

            if (txtLitrosGastos.Text != "" && txtKmInicio.Text != "" && txtKmFinal.Text != "")
            {
                kmInicial = double.Parse(txtKmInicio.Text);
                kmFinal = double.Parse(txtKmFinal.Text);
                litrosGastos = double.Parse(txtLitrosGastos.Text);

                if (litrosGastos < 0 || kmFinal < 0 || kmInicial < 0)
                {
                    txtKmInicio.Focus();
                    MessageBox.Show("Revise as entradas.", "Atenção!");
                }
                else if (kmInicial > kmFinal)
                {
                    txtKmInicio.Focus();
                    MessageBox.Show("O Km Inicial não pode ser maior que o Km Final", "Atenção!");
                }
                else
                {
                    kmRodados = kmFinal - kmInicial;
                    mediaPorLitro = kmRodados / litrosGastos;
                    MessageBox.Show($"{mediaPorLitro.ToString("N1")} Km/L", "Média de Consumo");
                }
            }
        }
    }
}
