using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_da_Média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // Programa incompleto. Feito parcialmente sem todas as validações necessárias
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double media = 0;

            if (txtNota1.Text != "")
            {
                n1 = double.Parse(txtNota1.Text);
            }
            if (txtNota2.Text != "")
            {
                n2 = double.Parse(txtNota2.Text);
            }
            if (txtNota3.Text != "")
            {
                n3 = double.Parse(txtNota3.Text);
            }
            if (txtNota4.Text != "")
            {
                n4 = double.Parse(txtNota4.Text);
            }

            if (n1 < 10 && n1 > 0 || n2 < 10 && n2 > 0 || n3 < 10 && n3 > 0 || n4 < 10 && n4 > 0)
            {
                media = (n1 + n2 + n3 + n4) / 4;
                MessageBox.Show($"Resultado {media.ToString()}", "Média das Notas");
            }
            else
            {
                MessageBox.Show("Revise as notas!\nNotas com valor máximo de 10.", "Atenção");
            }
        }
    }
}
