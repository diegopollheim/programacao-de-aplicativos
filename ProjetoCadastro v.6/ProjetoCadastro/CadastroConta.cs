using ProjetoCadastro.Entidades;
using System;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class CadastroConta : Form
    {

        public CadastroConta()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
            btnAlterar.Hide();

            cbbAgencia.Text = "Selecione";
            for (int i = 0; i < Dados.ListaAgencias.Count; i++)
            {
                cbbAgencia.Items.Add(Dados.ListaAgencias[i].Nome.ToString());
            }
        }

        public CadastroConta(Conta objConta, int pos)
        {
            InitializeComponent();

            btnCadastrar.Enabled = false;
            btnCadastrar.Hide();

            txtNumConta.Text = objConta.Numero;
            txtCpfCliente.Text = objConta.Cliente;
            cbbAgencia.Text = objConta.Agencia;
            txtSaldoConta.Text = objConta.Saldo.ToString();

            lbPos.Text = pos.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string numConta = txtNumConta.Text;
            string numAg = cbbAgencia.Text;
            string client = txtCpfCliente.Text;
            double saldo = double.Parse(txtSaldoConta.Text);


            if (!String.IsNullOrEmpty(numConta))
            {
                if ((!String.IsNullOrEmpty(numAg)) && numAg != "Selecione")
                {
                    if (!String.IsNullOrEmpty(client))
                    {
                        // Monta Objeto Conta
                        Conta objConta = new Conta(numConta, numAg, client, saldo);

                        // Validação do CPF para cadastrar conta
                        if (Dados.ListaPessoas.Count != 0)
                        {
                            for (int i = 0; i < Dados.ListaPessoas.Count; i++)
                            {
                                if (Dados.ListaPessoas[i].Cpf == txtCpfCliente.Text)
                                {
                                    Dados.ListaContas.Add(objConta);
                                    MessageBox.Show("Conta Cadastrada com Sucesso!", "Feito");
                                }
                                else
                                {
                                    MessageBox.Show("Cliente não cadastrado!", "Atenção");
                                }
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum Cliente Casdastrado.\nCadastre um Cliente para continuar!","Atenção");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confira o cpf do cliente", "Atenção");
                    }
                }
                else
                {
                    MessageBox.Show("Confira a agência", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Confira o Número da Conta", "Atenção");
            }
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string numConta = txtNumConta.Text;
            string numAg = cbbAgencia.Text;
            string client = txtCpfCliente.Text;
            double saldo = double.Parse(txtSaldoConta.Text);

            if (!String.IsNullOrEmpty(numConta))
            {
                if ((!String.IsNullOrEmpty(numAg)) && numAg != "Selecione")
                {
                    if (!String.IsNullOrEmpty(client))
                    {
                        // Criação da conta
                        Conta objConta = new Conta(numConta, numAg, client, saldo);

                        Dados.ListaContas[int.Parse(lbPos.Text)] = objConta;
                        MessageBox.Show("Conta Alterada com Sucesso!", "Feito");
                    }
                    else
                    {
                        MessageBox.Show("Confira o cpf do cliente", "Atenção");
                    }
                }
                else
                {
                    MessageBox.Show("Confira a agência", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Confira o Número da Conta", "Atenção");
            }
            this.Close();
        }
    }
}
