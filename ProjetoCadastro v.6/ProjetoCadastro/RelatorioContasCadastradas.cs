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
    public partial class RelatorioContasCadastradas : Form
    {
        public RelatorioContasCadastradas()
        {
            InitializeComponent();
            dgvContas.DataSource = Dados.ListaContas;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Exclui a conta da linha selecionada
            string elemento = dgvContas.CurrentRow.Cells[0].Value.ToString();
            int cont = 0;
            while ((Dados.ListaContas[cont].Numero != elemento) && (cont < Dados.ListaContas.Count))
            {
                cont++;
            }
            if (cont != Dados.ListaContas.Count)
            {
                Dados.ListaContas.RemoveAt(cont);
                MessageBox.Show("Elemento Removido!", "Excluido");
                this.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Conta objConta = new Conta( dgvContas.CurrentRow.Cells[0].Value.ToString(),
                                        dgvContas.CurrentRow.Cells[1].Value.ToString(),
                                        dgvContas.CurrentRow.Cells[2].Value.ToString(),
                                        double.Parse(dgvContas.CurrentRow.Cells[3].Value.ToString()));
            int pos = dgvContas.CurrentRow.Index;

            this.Close();
            CadastroConta FormAlterar = new CadastroConta(objConta, pos);
            FormAlterar.Show();
        }
    }
}
