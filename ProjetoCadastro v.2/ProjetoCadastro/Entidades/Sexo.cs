using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Entidades
{
    public class Sexo
    {
        public string NomeSexo { get; private set; }

        public Sexo()
        {

        }

        public Sexo(string nomeSexo)
        {
            NomeSexo = nomeSexo;
        }        
    }
}
