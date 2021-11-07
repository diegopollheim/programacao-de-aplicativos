using AulaAplicativos.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAplicativos.Controller
{
   public class EstadoController
    {
        //Busca Todos os Estados
        public DataTable BuscarEstado()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Estado", out retorno);
                return retorno;
            }
        }
        // Buscar Estados pelo ID
        public DataTable BuscarEstadoId(int id)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Estado where IdEstado=@1", out retorno, "@1", id);
                return retorno;
            }
        }
        // Buscar Estados Pelo Nome
        public DataTable BuscarEstadoNome(string nomeEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Estado where Estado like @1", out retorno, "@1", "%"+nomeEstado+"%");
                return retorno;
            }
        }
        // Buscar Estados pela Sigla
        public DataTable BuscarEstadoSigla(string sigla)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Estado where Sigla like @1", out retorno, "@1", sigla);
                return retorno;
            }
        }
    }
}
