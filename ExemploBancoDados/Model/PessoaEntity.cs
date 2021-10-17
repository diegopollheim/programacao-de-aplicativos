using ExemploBancoDados.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploBancoDados.Model
{
   public class PessoaEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public PessoaEntity()
        {
            
        }
        public PessoaEntity(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public bool Gravar()
        {
            PessoaController controller = new PessoaController();
            return controller.Gravar(this);
        }
    }
}
