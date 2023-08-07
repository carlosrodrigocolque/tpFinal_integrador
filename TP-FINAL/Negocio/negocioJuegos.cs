using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;
using System.Data.SqlClient;

namespace Negocio
{
    public class negocioJuegos
    {
        public DataTable TodosLosJuegos()
        {
            Conexion cx = new Conexion();
            return cx.ObtenerTablaCompleta("Juegos");
        }
        public bool agregarJuego(Juego obj)
        {
            DatoJuego conexJuego = new DatoJuego();
            if (!conexJuego.existeCodJuego(obj.CodJuego))
                return Convert.ToBoolean(conexJuego.agregarJuego(obj));
            return false;
        }
        public bool existeJuego(Juego obj)
        {
            DatoJuego conex = new DatoJuego();
            return conex.existeCodJuego(obj.CodJuego); ;
        }
    }
}
