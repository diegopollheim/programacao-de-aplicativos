using AulaAplicativos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAplicativos.View
{
    public partial class RelatorioCidade : Form
    {
        public RelatorioCidade()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            CidadeController controller = new CidadeController();
            DataTable resultado = new DataTable();

            if (rdbIdCidade.Checked)
            {
                try
                {
                    int chave = int.Parse(txtPesquisa.Text);
                    resultado = controller.BuscarCidadeId(chave);
                    dvgCidades.DataSource = resultado;
                }
                catch(Exception erro)
                {
                    var teste = erro;
                    MessageBox.Show($"Entrada inválida!","Atenção");
                }
            }

            if (rdbIdEstado.Checked)
            {
                try
                {
                    int chave = int.Parse(txtPesquisa.Text);
                    resultado = controller.BuscarCidade(chave);
                    dvgCidades.DataSource = resultado;
                }
                catch (Exception erro)
                {
                    var teste = erro;
                    MessageBox.Show($"Entrada inválida!", "Atenção");
                }
            }

            if (rdbNomeCidade.Checked)
            {
                try
                {
                    string chave = txtPesquisa.Text;
                    resultado = controller.BuscarCidadeNome(chave);
                    dvgCidades.DataSource = resultado;
                }
                catch (Exception erro)
                {
                    var teste = erro;
                    MessageBox.Show($"Entrada inválida!", "Atenção");
                }
            }
        }
    }
}
