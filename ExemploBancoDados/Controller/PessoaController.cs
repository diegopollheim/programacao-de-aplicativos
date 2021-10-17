using ExemploBancoDados.DAO;
using ExemploBancoDados.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExemploBancoDados.Controller
{
    public class PessoaController
    {
        //Gravar um registro no banco
        public bool Gravar(PessoaEntity pessoa)
        {
            int id = 0;
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                //Comando SQL que insere no banco
                bool ok = false;
                ok = banco.Banco.ExecuteNonQuery(@"insert into pessoa (Nome,Cpf) values(@1, @2)", "@1",pessoa.Nome, "@2",pessoa.Cpf);

                if (ok && id == 0)
                {
                    //Retorna a posiçao da linha que gravou no banco
                    id = banco.Banco.GetIdentity();
                }
                return ok;
            }
        }
        //Verifica a existencia de uma pessoa no banco
        public DataTable BuscarPessoa(string cpf)
        {
            DataTable objResultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Pessoa where CPF=@1", out objResultado, "@1", cpf);
                return objResultado;
            }


        }

        //Excluir uma pessoa do banco
        public bool Excluir(int id)
        {
            BancoInstance banco = new BancoInstance();
            using (banco = new BancoInstance())
            {
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"delete from pessoa where id=@1", "@1", id);
            }
        }
    }
}
