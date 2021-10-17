using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Entidades
{
    public class Cliente
    {
        
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Telefone { get; private set; }
        public string Sexo { get; private set; }

        public Cliente(string nome, string cpf, string rg,
            string telefone, string sexo)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Sexo = sexo;
        }
    }
}
