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
    public partial class CadastroSexo : Form
    {
        public CadastroSexo()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
            btnAlterar.Hide();
        }

        public CadastroSexo(Sexo objsexo, int pos)
        {
            InitializeComponent();
            btnCadastrarSexo.Enabled = false;
            btnCadastrarSexo.Hide();

            ttbNomeSexo.Text = objsexo.NomeSexo.ToString();
            lbPos.Text = pos.ToString();
            lbPos.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarSexo_Click(object sender, EventArgs e)
        {
            string sexo = ttbNomeSexo.Text;
            bool achou =  false;
            
            if (sexo.Length > 0) {

                for (int i = 0; (i < Dados.ListaSexos.Count) && (!achou); i++)
                {
                    if (sexo.ToString().ToUpper() == Dados.ListaSexos[i].NomeSexo.ToString().ToUpper()) {
                        achou = true;
                    }
                }
                if (!achou)
                {
                    Sexo objSexo = new Sexo(ttbNomeSexo.Text.ToString());
                    Dados.ListaSexos.Add(objSexo);

                    MessageBox.Show($"O sexo {sexo}, foi cadastrado com sucesso!", "Feito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Sexo já cadastrado!", "Algo deu errado!");
                    ttbNomeSexo.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Não pode ser gravado um sexo sem Nome.","Atenção");
                ttbNomeSexo.Focus();
            }
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var texto = ttbNomeSexo.Text;
           
            if (!String.IsNullOrEmpty(texto)) 
            {
                var objSexo = new Sexo(texto.ToUpper());
                Dados.ListaSexos[Convert.ToInt32(lbPos.Text)-1] = objSexo;
                MessageBox.Show("Alterado com sucesso!","Feito");
            }
            else
            {
                MessageBox.Show("Não foi possivel alterar!", "Atenção");
            }
            this.Close();
            RelatorioSexosCadastrados relatorio = new RelatorioSexosCadastrados();
            relatorio.Show();
        }
    }
}
