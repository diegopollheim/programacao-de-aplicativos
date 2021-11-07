using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAplicativos.Model
{
    public class EstadoEntity
    {
        public int IdEstado { get; private set; }
        public string Estado { get; private set; }
        public string Sigla { get; private set; }

        public EstadoEntity(int idEstado, string estado, string sigla)
        {
            IdEstado = idEstado;
            Estado = estado;
            Sigla = sigla;
        }
    }
}
