using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Entidades
{
    class Agencia
    {
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        public int Numero { get; private set; }
       
        public Agencia(string nome, string cidade, int numero)
        {
            Nome = nome;
            Cidade= cidade;
            Numero = numero;
        }
    }
}
