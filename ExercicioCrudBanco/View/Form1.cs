using ExercicioCrudBanco.Controller;
using ExercicioCrudBanco.DAO;
using ExercicioCrudBanco.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCrudBanco
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();

            btnAlterar.Hide();
            btnExcluir.Hide();
            btnCadastrar.Enabled = false;

            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtLogradouro.Enabled = false;
            txtEndNum.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string razaoSocial = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string cnpj = txtCnpj.Text;
            string endLogr = txtLogradouro.Text;
            string endNum = txtEndNum.Text;
            string endCid = txtCidade.Text;
            string endUf = txtEstado.Text;
            string telefone = txtTelefone.Text;

            // Cria um objEmpresa com todos os dados preenchidos no FORMS
            // Usei variáveis para facilitar a montage do Obj e tambem na montagem do endereco que usei mais de um textbox
            Empresa objEmpresa = new Empresa(0, razaoSocial, nomeFantasia, cnpj, endLogr, endNum, endCid, endUf, telefone);

            var res = objEmpresa.Gravar();
            if (res)
            {
                MessageBox.Show("Empresa gravada com sucesso.", "Concluído");
            }
            else
            {
                MessageBox.Show("Ocorreu um problema", "OPS");
            }
            ZerarInputs();

            txtCnpj.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EmpresaController controladora = new EmpresaController();
            DataTable resultado = controladora.BuscarEmpresa(txtCnpj.Text);
            if (resultado.Rows.Count > 0)
            {
                //Pega Id do registro buscado
                lbPos.Text = resultado.Rows[0]["Id"].ToString(); 

                // Preenche os txtBoxs com os valores do resultado
                txtRazaoSocial.Text = resultado.Rows[0]["RazaoSocial"].ToString();
                txtNomeFantasia.Text = resultado.Rows[0]["NomeFantasia"].ToString();
                txtCnpj.Text = resultado.Rows[0]["CNPJ"].ToString();
                txtLogradouro.Text = resultado.Rows[0]["EndLogr"].ToString();
                txtEndNum.Text = resultado.Rows[0]["EndNum"].ToString();
                txtEstado.Text = resultado.Rows[0]["EndUf"].ToString();
                txtCidade.Text = resultado.Rows[0]["EndCidade"].ToString();
                txtTelefone.Text = resultado.Rows[0]["Telefone"].ToString();

                btnAlterar.Show();
                btnExcluir.Show();
                txtCnpj.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Nenhuma Empresa cadastrada com esse CNPJ!", "Alerta");
                txtRazaoSocial.Focus();
                txtCnpj.Enabled = false;
                btnCadastrar.Enabled = true;
            }

            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtLogradouro.Enabled = true;
            txtEndNum.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefone.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EmpresaController controler = new EmpresaController();
            if (int.Parse(lbPos.Text) > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir esse registro?", "Confirmar Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    if (controler.Excluir(int.Parse(lbPos.Text)))
                    {
                        MessageBox.Show("Empresa Excluida com Sucesso.", "Concluido!");
                    }
                    ZerarInputs();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
            string razaoSocial = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string cnpj = txtCnpj.Text;
            string endLogr = txtLogradouro.Text;
            string endNum = txtEndNum.Text;
            string endCid = txtCidade.Text;
            string endUf = txtEstado.Text;
            string telefone = txtTelefone.Text;

            EmpresaController controladora = new EmpresaController();
            Empresa objEmpresa = new Empresa(0, razaoSocial, nomeFantasia, cnpj, endLogr, endNum, endCid, endUf, telefone);
            DataTable resultado = controladora.BuscarEmpresa(txtCnpj.Text);
            if (resultado.Rows.Count > 0)
            {
                //Pega Id do registro buscado
                lbPos.Text = resultado.Rows[0]["Id"].ToString();

                // Preenche os txtBoxs com os valores do resultado
                var res = controladora.Alterar(objEmpresa, int.Parse(lbPos.Text));
                if (res)
                {
                    MessageBox.Show("Registro Alterado com Sucesso!","Alterado");
                }

                ZerarInputs();
                txtCnpj.Enabled = true;
            }
        }

        private void ZerarInputs()
        {
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCnpj.Clear();
            txtLogradouro.Clear();
            txtEndNum.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
        }
    }
}
