using AulaAplicativos.Controller;
using AulaAplicativos.Model;
using AulaAplicativos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAplicativos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbEstado.Items.Add(new ItemsComboBox("Selecione", 0));

            // Busca todos os estados e preeche o ComboBox
            EstadoController controllerEstado = new EstadoController();
            DataTable dtEstados = controllerEstado.BuscarEstado();
            for (int i = 0; i < dtEstados.Rows.Count; i++)
                cbbEstado.Items.Add(new ItemsComboBox(dtEstados.Rows[i]["Estado"].ToString(), int.Parse(dtEstados.Rows[i]["IdEstado"].ToString())));


            // Bloqueia a alteração dos ComboBox
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCidade.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            // Limpa ComboBox para preencher com novos elementos
            cbbCidade.Items.Clear();

            int idSelecionado = (cbbEstado.SelectedItem as ItemsComboBox).Id;

            // Buscar as Cidades do estado selecionado
            CidadeController controllerCidade = new CidadeController();
            DataTable dtCidades = controllerCidade.BuscarCidade(idSelecionado);
            for (int j = 0; j < dtCidades.Rows.Count; j++)
                cbbCidade.Items.Add(new ItemsComboBox(dtCidades.Rows[j]["Cidade"].ToString(), int.Parse(dtCidades.Rows[j]["IdCidade"].ToString())));
        }

        private void btnRelatCid_Click(object sender, EventArgs e)
        {
            RelatorioCidade telaCidade = new RelatorioCidade();
            telaCidade.Show();
        }

        private void btnRelatEstado_Click(object sender, EventArgs e)
        {
            RelatorioEstados tela = new RelatorioEstados();
            tela.Show();
        }
    }
}
