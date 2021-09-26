using ProjetoCadastro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class CadastroAgencia : Form
    {
        public CadastroAgencia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarAg_Click(object sender, EventArgs e)
        {
            int numAg = int.Parse(txtNumAg.Text);
            Agencia objAgencia = new Agencia(txtNmAg.Text, txtCidade.Text, numAg);

            Dados.ListaAgencias.Add(objAgencia);
            this.Close();
        }
    }
}
