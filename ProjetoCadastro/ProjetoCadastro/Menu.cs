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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?",
                "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCadastroCliente relCliente = new RelatorioCadastroCliente();
            relCliente.Show();
        }

        private void cadastrarSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSexo NovoCadastro = new CadastroSexo();

            NovoCadastro.Show();
        }

        private void sexosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioSexo NovoRelatorio = new RelatorioSexo();
            NovoRelatorio.Show();
        }
    }
}
