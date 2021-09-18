using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Caixa_Retangular
{
    public partial class EX02 : Form
    {
        public EX02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, largura, comprimento, volume;
            if (txtAltura.Text == "" || txtComprimento.Text == "" || txtLargura.Text == "")
            {
                txtAltura.Focus();
                MessageBox.Show($"Revise os campos para continuar", "Atenção!");
            }
            else
            {
                altura = double.Parse(txtAltura.Text);
                largura = double.Parse(txtLargura.Text);
                comprimento = double.Parse(txtComprimento.Text);

                if (altura > 0 && largura > 0 && comprimento > 0)
                {
                    volume = comprimento * altura * largura;
                    MessageBox.Show($"Volume: {volume} cm³", "Volume da caixa");
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
