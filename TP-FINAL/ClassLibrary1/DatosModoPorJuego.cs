using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosModoPorJuego
    {
        private Conexion conex = new Conexion();

        public DataTable getTabaModosPorJuegos()
        {
            DataTable tabla = conex.obtenerTaba("ModosPorJuegos", "select * from ModosxJuegos");
            return tabla;
        }
        public DataTable getTablaModosPorJuegos(ModoPorJuego obj)
        {
            DataTable tabla = conex.obtenerTaba("ModosPorJuegos", "select * from ModosxJuegos where CodJuego_JU_MXJ = '" + obj.Cod_Juego + "' and CodModoDeJuego_MDJ_MXJ = '" + obj.Cod_ModoDeJuego + "'");
            return tabla;
        }
        public DataTable getTablaModosPorJuegos(string codJuego, string codModoDeJuego)
        {
            DataTable tabla = conex.obtenerTaba("ModosPorJuegos", "select * from ModosxJuegos where CodJuego_JU_MXJ = '" + codJuego + "' and CodModoDeJuego_MDJ_MXJ = '" + codModoDeJuego + "'");
            return tabla;
        }
        public bool existeModosPorJuegos(ModoPorJuego obj)
        {
            string consultaSql = ""
                + "select * from ModosxJuegos where CodJuego_JU_MXJ = '" + obj.Cod_Juego + "' and CodModoDeJuego_MDJ_MXJ = '" + obj.Cod_ModoDeJuego + "'";
            return conex.existe(consultaSql);
        }
        public bool existeModosPorJuegos(string codJuego, string codMododeJuego)
        {
            string consultaSql = ""
                + "select * from ModosxJuegos where CodJuego_JU_MXJ = '" + codJuego + "' and CodModoDeJuego_MDJ_MXJ = '" + codMododeJuego + "'";
            return conex.existe(consultaSql);
        }
        public int agregarCategoriasPorJuegos(ModoPorJuego obj)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosJuego(ref comando, obj);
            return conex.ejecutarSentenciar(ref comando, "" +
                "insert into ModosxJuegos (CodJuego_JU_MXJ, CodModoDeJuego_MDJ_MXJ) " +
                "values ( @CodJuego, @CodModoDeJuego)");
        }
        public void armarParametrosJuego(ref SqlCommand comando, ModoPorJuego obj)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodJuego", SqlDbType.NVarChar);
            parametros.Value = obj.Cod_Juego;
            parametros = comando.Parameters.Add("@CodModoDeJuego", SqlDbType.NVarChar);
            parametros.Value = obj.Cod_ModoDeJuego;
        }
    }
}
