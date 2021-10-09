using ProjetoCadastro.Entidades;
using System;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(  dgvClientes.CurrentRow.Cells[0].Value.ToString(),
                                            dgvClientes.CurrentRow.Cells[1].Value.ToString(),
                                            dgvClientes.CurrentRow.Cells[2].Value.ToString(),
                                            dgvClientes.CurrentRow.Cells[3].Value.ToString(),
                                            dgvClientes.CurrentRow.Cells[4].Value.ToString());
            int pos = dgvClientes.CurrentRow.Index;

            this.Close();
            CadastroCliente FormAlterar = new CadastroCliente(objPessoa, pos);
            FormAlterar.Show();
        }
    }
}
