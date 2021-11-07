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
    public partial class RelatorioEstados : Form
    {
        public RelatorioEstados()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            EstadoController controller = new EstadoController();
            DataTable resultado = new DataTable();

            if (rdbIdEstado.Checked)
            {
                try
                {
                    int chave = int.Parse(txtPesquisar.Text);
                    resultado = controller.BuscarEstadoId(chave);
                    dvgEstados.DataSource = resultado;
                }
                catch (Exception erro)
                {
                    var teste = erro;
                    MessageBox.Show($"Entrada inválida!", "Atenção");
                }
            }

            if (rdbNomeEstado.Checked)
            {
                try
                {
                    string chave = txtPesquisar.Text;
                    resultado = controller.BuscarEstadoNome(chave);
                    dvgEstados.DataSource = resultado;
                }
                catch (Exception erro)
                {
                    var teste = erro;
                    MessageBox.Show($"Entrada inválida!", "Atenção");
                }
            }

            if (rdbSigla.Checked)
            {
                try
                {
                    string chave = txtPesquisar.Text;
                    resultado = controller.BuscarEstadoSigla(chave.ToUpper());
                    dvgEstados.DataSource = resultado;
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
