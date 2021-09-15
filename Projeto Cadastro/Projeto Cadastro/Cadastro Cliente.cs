using Projeto_Cadastro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
            cmbSexo.Items.Add("Selecione");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");
            cmbSexo.Items.Add("Outros");

            //seta elemento inicial do DropDown
            cmbSexo.SelectedIndex = cmbSexo.FindStringExact("Selecione");

            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0)
            {

                if (txtCPF.Text != "   .   .   -")
                {

                    if (txtRG.Text.Length > 0)
                    {
                        if (txtTelefone.Text != "(  )     -")
                        {
                            if (cmbSexo.SelectedItem.ToString() != "Selecione")
                            {
                                //lógica para gravar os dados
                                Pessoa objPessoa = new Pessoa(txtNome.Text,
                                                            txtCPF.Text,
                                                            txtRG.Text,
                                                            txtTelefone.Text,
                                                            cmbSexo.Text);

                                // Gravar em memória
                                Dados.ListaPessoas.Add(objPessoa);
                                this.Close();
                                                               
                                MessageBox.Show("Gravação efetuada com Sucesso!", "Concluido!");
                            }
                            else
                            {
                                MessageBox.Show("Selecione um Sexo.", "Atenção!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confira a digitação do Telefone.", "Atenção!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confira a digitação do RG.", "Atenção!");
                    }
                }
                else
                {
                    MessageBox.Show("Confira a digitação do CPF.", "Atenção!");
                }
            }
            else
            {
                MessageBox.Show("Confira a digitação do Nome.", "Atenção!");
            }           

        }
    }
}
