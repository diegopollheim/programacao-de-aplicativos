using ProjetoCadastro.Entidades;
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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            //Adicionando elementos ao comboBox
            //cbbSexo.Items.Add("Selecione");
            //cbbSexo.Items.Add("Masculino");
            //cbbSexo.Items.Add("Feminino");
            //cbbSexo.Items.Add("Outros");

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

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(ttbNome.Text.Length>0)
            {
                if(ttbCpf.Text!="   .   .   -")
                {
                    if(ttbRg.Text.Length>0)
                    {
                        if (ttbTelefone.Text != "(  )     -")
                        {
                            if(cbbSexo.SelectedItem.ToString()!="Selecione")
                            {
                                Pessoa objPessoa = new Pessoa(ttbNome.Text, ttbCpf.Text,
                                    ttbRg.Text, ttbTelefone.Text, cbbSexo.SelectedIndex.ToString());

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

        
    }
}
