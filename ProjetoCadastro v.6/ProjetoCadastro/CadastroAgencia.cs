using ProjetoCadastro.Entidades;
using System;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class CadastroAgencia : Form
    {
        private Agencia objAgencia;
        private int pos;

        public CadastroAgencia()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
            btnAlterar.Hide();
        }

        public CadastroAgencia(Agencia objAgencia, int pos)
        {
            InitializeComponent();
            btnCadastrarAg.Enabled = false;
            btnCadastrarAg.Hide();

            lbPos.Text = pos.ToString();
            lbPos.Hide();

            txtNmAg.Text = objAgencia.Nome;
            txtCidade.Text = objAgencia.Cidade;
            txtNumAg.Text = objAgencia.Numero.ToString();

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNmAg.Text))
            {
                MessageBox.Show(lbPos.Text);
                Agencia objAgencia = new Agencia(txtNmAg.Text, txtCidade.Text, int.Parse(txtNumAg.Text));
                Dados.ListaAgencias[int.Parse(lbPos.Text)] = objAgencia;
                MessageBox.Show("Alterado com sucesso!", "Feito");
            }
            else
            {
                MessageBox.Show("Não foi possivel alterar!", "Atenção");
            }
            this.Close();

        }
    }
}
