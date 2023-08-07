using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatoJuego
    {
        private Conexion conex = new Conexion();
        
        public DataTable getTablaJuegos()
        {
            DataTable tabla = conex.obtenerTaba("Juegos","select * from Juegos");
            return tabla;
        }
        public DataTable getTablaJuegos(string codJuego)
        {
            DataTable tabla = conex.obtenerTaba("Juegos","select *from Juegos where CodJuego_JU = '"+codJuego.ToString()+"'");
            return tabla;
        }
        public bool existeCodJuego(string codJuego)
        {
            string consultaSql = "select * from Juegos where CodJuego_JU = '" + codJuego + "'";
            return conex.existe(consultaSql);
        }
        public bool existeNombreJuego(string nombreJuego)
        {
            string consultaSql = "select * from Juegos where Nombre_JU = '" + nombreJuego + "'";
            return conex.existe(consultaSql);
        }
        public int agregarJuego(Juego obj)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosJuego(ref comando,obj);
            return conex.ejecutarSentenciar(ref comando, "" +
                "insert into Juegos (CodJuego_JU, CodProveedor_PR_JU, Nombre_JU,Descripcion_JU, FechaDeLanzamiento_JU, URLportada_JU, Activo_JU) "+
                "values ( @CodJuego, @CodProveedor, @Nombre, @Descripcion, @FechaLanzamiento, @UrlPortada, @Activo)");
        }
        public void armarParametrosJuego(ref SqlCommand comando, Juego obj) 
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodJuego",SqlDbType.NVarChar);
            parametros.Value = obj.CodJuego;
            parametros = comando.Parameters.Add("@CodProveedor", SqlDbType.NVarChar);
            parametros.Value = obj.CodProvedor;
            parametros = comando.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            parametros.Value = obj.NombreJuego;
            parametros = comando.Parameters.Add("@Descripcion",SqlDbType.NVarChar);
            parametros.Value = obj.Descripcion;
            parametros = comando.Parameters.Add("@FechaLanzamiento", (SqlDbType.DateTime));
            parametros.Value = obj.FechaDeLanzamiento;
            parametros = comando.Parameters.Add("@UrlPortada", SqlDbType.NVarChar);
            parametros.Value = obj.UrlPortada;
            parametros = comando.Parameters.Add("@Activo", SqlDbType.Bit);
            parametros.Value = obj.Activo;
        }
    }
}
