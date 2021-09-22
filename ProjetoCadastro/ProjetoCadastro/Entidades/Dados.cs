using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Entidades
{
    static class Dados
    {
        private static List<Pessoa> _listaPessoas = new List<Pessoa>();

        public static List<Pessoa> ListaPessoas
        {
            get { return _listaPessoas; }
            set { _listaPessoas = value; }
        }

        private static List<Sexo> _listaSexos = new List<Sexo>();

        public static List<Sexo> ListaSexos
        {
            get { return _listaSexos; }
            set { _listaSexos = value; }
        }
    }
}
