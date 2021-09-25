<<<<<<< HEAD:ProjetoCadastro/ProjetoCadastro/Entidades/Dados.cs
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 6b3bd380094cdc81a3212cbc1b431ff25cc34959:Projeto Cadastro/Projeto Cadastro/Entidades/Dados.cs
