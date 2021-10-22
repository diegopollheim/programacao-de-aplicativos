using ExercicioCrudBanco.DAO;
using ExercicioCrudBanco.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCrudBanco.Controller
{
    public class EmpresaController
    {
        public bool Gravar(Empresa empresa)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                //Comando SQL que insere no banco
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"insert into Empresa (RazaoSocial,NomeFantasia,CNPJ,EndLogr,EndNum,EndCidade,EndUf,Telefone) values(@1, @2, @3, @4, @5, @6, @7, @8)", "@1", empresa.RazaoSocial, "@2", empresa.NomeFantasia, "@3", empresa.CNPJ, "@4", empresa.EndLogr, "@5", empresa.EndNum, "@6", empresa.EndCid, "@7", empresa.EndUF, "@8", empresa.Telefone);
            }
        }
        //Alterar registro da Tabela
        public bool Alterar(Empresa empresa)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"update Empresa set RazaoSocial=@1, NomeFantasia=@2, EndLogr=@3, EndNum=@4, EndCidade=@5, EndUf=@6, Telefone=@7 where Id=@8", "@1",
                    empresa.RazaoSocial, "@2", empresa.NomeFantasia, "@3", empresa.EndLogr, "@4", empresa.EndNum, "@5", empresa.EndCid, "@6", empresa.EndUF, "@7", empresa.Telefone, "@8", empresa.Id);
            }
        }

        // Busca Empresa Pelo CNPJ
        public DataTable BuscarEmpresa(string cnpj)
        {
            // Cria variável do tipo Tabela
            DataTable objResultado = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Empresa where CNPJ=@1", out objResultado, "@1", cnpj);
                return objResultado;
            }
        }

        // Excluir Empresa
        public bool Excluir(int id)
        {
            BancoInstance banco = new BancoInstance();
            using (banco = new BancoInstance())
            {
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"delete from Empresa where id=@1", "@1", id);
            }
        }

        public DataTable BuscarTodasEmpresas()
        {
            // criar uma variavel do tipo tabela
            DataTable resultado = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Empresa", out resultado);
                return resultado; // retorna uma tabela do banco
            }
        }
    }
}


