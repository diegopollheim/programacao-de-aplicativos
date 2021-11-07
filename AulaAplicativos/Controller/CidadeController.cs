using AulaAplicativos.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAplicativos.Controller
{
   public class CidadeController
    {
        public DataTable BuscarCidade(int idEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Cidades where IdEstado=@1", out retorno, "@1", idEstado);
                return retorno;
            }
        }

        public DataTable BuscarCidadeId(int idCidade)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Cidades where IdCidade=@1", out retorno, "@1", idCidade);
                return retorno;
            }
        }

        public DataTable BuscarCidadeNome(string NomeCidade)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Cidades where Cidade like @1", out retorno, "@1", "%"+NomeCidade+"%");
                return retorno;
            }
        }
    }
}
