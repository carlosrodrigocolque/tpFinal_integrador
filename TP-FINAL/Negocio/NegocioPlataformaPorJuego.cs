using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioPlataformaPorJuego
    {
        public bool agregarPlataformaPorJuego(PlataformaPorJuego obj)
        {
            DatosPlataformaPorJuego conex = new DatosPlataformaPorJuego();
            if (conex.existeCodPlataformaPorJuegos(obj) == false)
                return Convert.ToBoolean(conex.agregarPlataformaPorJuego(obj));
            return false;
        }
        public bool existePlataformaPorJuego(PlataformaPorJuego obj)
        {
            DatosPlataformaPorJuego conex = new DatosPlataformaPorJuego();
            return conex.existeCodPlataformaPorJuegos(obj);
        }
    }
}
