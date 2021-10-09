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
    public partial class RelatorioAgenciasCadastradas : Form
    {
        public RelatorioAgenciasCadastradas()
        {
            InitializeComponent();
            dgvAgencias.DataSource = Dados.ListaAgencias;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string elemento = dgvAgencias.CurrentRow.Cells[0].Value.ToString();
            int cont = 0;
            while ((Dados.ListaAgencias[cont].Nome != elemento) && (cont < Dados.ListaAgencias.Count))
            {
                cont++;
            }
            if (cont != Dados.ListaAgencias.Count)
            {
                Dados.ListaAgencias.RemoveAt(cont);
                MessageBox.Show("Elemento Removido!", "Excluido");
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Agencia objAgencia = new Agencia(dgvAgencias.CurrentRow.Cells[0].Value.ToString(),
                                            dgvAgencias.CurrentRow.Cells[1].Value.ToString(),
                                            Convert.ToInt32(dgvAgencias.CurrentRow.Cells[2].Value));

            int pos = dgvAgencias.CurrentRow.Index;

            this.Close();
            CadastroAgencia FormAlterar = new CadastroAgencia(objAgencia, pos);
            FormAlterar.Show();
        }
    }
}
