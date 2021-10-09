using ProjetoCadastro.Entidades;
using System;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente(Pessoa objPessoa, int pos)
        {
            InitializeComponent();
            btnCadastrar.Enabled = false;
            btnCadastrar.Hide();

            cbbSexo.Items.Add("Selecione");
            for (int i = 0; i < Dados.ListaSexos.Count; i++)
            {
                cbbSexo.Items.Add(Dados.ListaSexos[i].NomeSexo.ToString());
            }
            //setar um elemento inicial
            cbbSexo.SelectedIndex = cbbSexo.FindStringExact("Selecione");

            //bloquear edição do comboBox
            cbbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public CadastroCliente()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
            btnAlterar.Hide();

            cbbSexo.Items.Add("Selecione");
            for (int i = 0; i < Dados.ListaSexos.Count; i++)
            {
                cbbSexo.Items.Add(Dados.ListaSexos[i].NomeSexo.ToString());
            }
            //setar um elemento inicial
            cbbSexo.SelectedIndex = cbbSexo.FindStringExact("Selecione");

            //bloquear edição do comboBox
            cbbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do cadastro de clientes?",
               "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ttbNome.Text.Length > 0)
            {
                if (ttbCpf.Text != "   .   .   -")
                {
                    if (ttbRg.Text.Length > 0)
                    {
                        if (ttbTelefone.Text != "(  )     -")
                        {
                            if (cbbSexo.SelectedItem.ToString() != "Selecione" && !String.IsNullOrEmpty(cbbSexo.Text))
                            {
                                Pessoa objPessoa = new Pessoa(ttbNome.Text, ttbCpf.Text,
                                    ttbRg.Text, ttbTelefone.Text, cbbSexo.SelectedItem.ToString());

                                //Gravar em memória
                                Dados.ListaPessoas.Add(objPessoa);

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Selecione um sexo!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Verifique a digitação do telefone!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique a digitação do RG");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique a digitação do CPF!");
                }
            }
            else
            {
                MessageBox.Show("Verifique a digitação do nome!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var nome = ttbNome.Text;
            var cpf = ttbCpf.Text;
            var rg = ttbRg.Text;
            var telefone = ttbTelefone.Text;
            var sexo = cbbSexo.Text;

            if (!String.IsNullOrEmpty(nome))
            {
                var objPessoa = new Pessoa(nome, cpf, rg, telefone, sexo);
                Dados.ListaPessoas[Convert.ToInt32(lbPos.Text)] = objPessoa;
                MessageBox.Show("Alterado com sucesso!", "Feito");
            }
            else
            {
                MessageBox.Show("Não foi possivel alterar!", "Atenção");
            }
            this.Close();
            RelatorioClientesCadastrados relatorio = new RelatorioClientesCadastrados();
            relatorio.Show();
        }
    }
}
