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
            int id = 0;
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                //Comando SQL que insere no banco
                bool ok = false;
                ok = banco.Banco.ExecuteNonQuery(@"insert into Empresa (RazaoSocial,NomeFantasia,CNPJ,EndLogr,EndNum,EndCidade,EndUf,Telefone) values(@1, @2, @3, @4, @5, @6, @7, @8)", "@1",empresa.RazaoSocial, "@2",empresa.NomeFantasia, "@3",empresa.CNPJ, "@4",empresa.EndLogr, "@5",empresa.EndNum, "@6",empresa.EndCid, "@7",empresa.EndUF, "@8",empresa.Telefone);

                return ok;
            }
        }
        //Alterar registro da Tabela
        public bool Alterar(Empresa empresa, int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            { 
               bool ok = false;
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set RazaoSocial=@RazaoSoc where Id = @id","@RazaoSoc", empresa.RazaoSocial, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set NomeFantasia=@NomeFantasia where Id = @id", "@NomeFantasia", empresa.NomeFantasia, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set EndLogr=@EndLogr where Id = @id", "@EndLogr", empresa.EndLogr, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set EndNum=@EndNum where Id = @id", "@EndNum", empresa.EndNum, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set EndCidade=@EndCid where Id = @id", "@EndCid", empresa.EndCid, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set EndUF=@EndUF where Id = @id", "@EndUF", empresa.EndUF, "@id", id);
               ok = banco.Banco.ExecuteNonQuery(@"update Empresa set Telefone=@Telefone where Id = @id", "@Telefone", empresa.Telefone, "@id", id);
               //ok = banco.Banco.ExecuteNonQuery($@"update Empresa set RazaoSocial = {empresa.RazaoSocial.ToString()} where Id= {id}");

                return ok;
            }
        }

        // Busca Empresa Pelo CNPJ
        public DataTable BuscarEmpresa(string cnpj)
        {
            DataTable objResultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Empresa where CNPJ=@1", out objResultado, "@1", cnpj);
                return objResultado;
            }
        }

        // Excluir Empresa
        public bool Excluir(int id) { 
            BancoInstance banco = new BancoInstance();
            using (banco = new BancoInstance())
            {
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"delete from Empresa where id=@1", "@1", id);
            }
        }
    }
}

   
