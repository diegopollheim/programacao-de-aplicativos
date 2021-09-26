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
    public partial class RelatorioClientesCadastrados : Form
    {
        public RelatorioClientesCadastrados()
        {
            InitializeComponent();
            dgvClientes.DataSource = Dados.ListaPessoas;
        }

        private void RelatorioCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string elemento = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            int cont = 0;
            while ((Dados.ListaPessoas[cont].Nome != elemento) && (cont < Dados.ListaPessoas.Count))
            {
                cont++;
            }
            if (cont != Dados.ListaPessoas.Count)
            {
                Dados.ListaPessoas.RemoveAt(cont);
                MessageBox.Show("Elemento Removido!", "Excluido");
                this.Close();
            }
        }
    }
}
