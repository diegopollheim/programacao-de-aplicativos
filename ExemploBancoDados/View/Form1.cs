using ExemploBancoDados.Controller;
using ExemploBancoDados.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGravar.Enabled = false;
            lbPos.Visible = false;
            txtNome.Enabled = false;
            btnExcluir.Hide();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Gravar Dados no Banco de Dados
            if (txtCpf.Text != "   .   .   -")
            {
                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    // Monta objPessoa
                    PessoaEntity objPessoa = new PessoaEntity(0, txtNome.Text, txtCpf.Text);

                    // Fazer inserçao no banco
                    var resultado = objPessoa.Gravar();
                    if (resultado != false)
                    {
                        MessageBox.Show("Gravação Concluida!", "Sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Gravação Concluida!", "Sucesso");
                    }
                    txtCpf.Enabled = true;
                    txtCpf.Focus();
                    btnExcluir.Enabled = false;
                    txtNome.Enabled = false;
                    txtCpf.Clear();
                    txtNome.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o Nome.", "Atenção!");
                }
            }
            else
            {

                MessageBox.Show("Preencha o Nome.", "Atenção!");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != "   .   .   -  ")
            {
                // Verifica se existe esse cpf no banco
                PessoaController controladora = new PessoaController();
                DataTable resultado = controladora.BuscarPessoa(txtCpf.Text);
                if (resultado.Rows.Count > 0)
                {
                    txtNome.Text = resultado.Rows[0]["Nome"].ToString();
                    lbPos.Text = resultado.Rows[0]["Id"].ToString();
                    txtNome.Enabled = true;
                    txtCpf.Enabled = false;
                    btnExcluir.Show();
                }
                else
                {
                    // Libera para gravar no banco bloqueando o campo CPF
                    MessageBox.Show("Não encontrou", "OK!!");
                    btnGravar.Enabled = true;
                    txtNome.Enabled = true;
                    txtCpf.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha o CPF", "Atenção!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PessoaController controler = new PessoaController();
            if (int.Parse(lbPos.Text) > 0)
            {
               if (MessageBox.Show("Deseja realmente excluir esse registro?", "Confirmar Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    
                    if (controler.Excluir(int.Parse(lbPos.Text)))
                    {
                        MessageBox.Show("Pessoa Excluida.","Concluido!");
                    }
                }
            }            
        }
    }
}
