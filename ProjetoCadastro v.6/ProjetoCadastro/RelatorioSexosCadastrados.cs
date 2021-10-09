using ProjetoCadastro.Entidades;
using System;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class RelatorioSexosCadastrados : Form
    {
        public RelatorioSexosCadastrados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatorioSexo_Load(object sender, EventArgs e)
        {
            dgvSexos.DataSource = Dados.ListaSexos;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string elemento = dgvSexos.CurrentRow.Cells[0].Value.ToString();
            int cont = 0;
            while ((Dados.ListaSexos[cont].NomeSexo != elemento) && (cont < Dados.ListaSexos.Count))
            {
                cont++;
            }
            if (cont != Dados.ListaSexos.Count)
            {
                Dados.ListaSexos.RemoveAt(cont);
                MessageBox.Show("Elemento Removido!", "Excluido");
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Sexo objSexo = new Sexo(dgvSexos.CurrentRow.Cells[0].Value.ToString());
            int pos = dgvSexos.CurrentRow.Index;

            this.Close();
            CadastroSexo FormAlterar = new CadastroSexo(objSexo,pos);
            FormAlterar.Show();

        }
    }
}
