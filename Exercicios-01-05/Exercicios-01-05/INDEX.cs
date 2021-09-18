using Calculo_da_Média;
using Conversor_Fahrenheit;
using Manipulando_Strings;
using Média_Consumo_Combustivel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volume_Caixa_Retangular;

namespace Exercicios_01_05
{
    public partial class INDEX : Form
    {
        public INDEX()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EX01 ex01 = new EX01();
            ex01.Show();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EX02 ex02 = new EX02();
            ex02.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EX03 ex03 = new EX03();
            ex03.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EX04 ex04 = new EX04();
            ex04.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EX05 ex05 = new EX05();
            ex05.Show();
        }
    }
}
