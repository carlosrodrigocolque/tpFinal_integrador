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
    public class Conexion
    {
        private string rutaBase = "Data Source=localhost\\sqlexpress;Initial Catalog=ChePlay;Integrated Security=True";
        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBase);
            try
            {
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(string consultaSql)
        {
            SqlDataAdapter adap;
            try
            {
                adap = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return adap;
            }
            catch
            {
                return null;
            }
        }
        public DataTable ObtenerTablaCompleta(string NombreTabla)
        {
            string ConsultaSql = "select Nombre_JU as 'nombre Del Juego',NombreDePlataforma_PL as 'Plataforma',PrecioUnitario_PXJ as 'Precio' " +
                "from (Juegos inner join PlataformasxJuegos  on CodJuego_JU = CodJuego_JU_PXJ) " +
                "inner join Plataformas on CodPlataforma_PL = CodPlataforma_PL_PXJ";
            DataSet ds = new DataSet();
            SqlDataAdapter adp = ObtenerAdaptador(ConsultaSql);
            adp.Fill(ds, NombreTabla);
            ObtenerConexion().Close();
            return ds.Tables[NombreTabla];
        }
        public DataTable obtenerTaba(string nombreTabla, string consultaSql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = ObtenerAdaptador(consultaSql);
            adaptador.Fill(ds,nombreTabla);
            ObtenerConexion().Close();
            return ds.Tables[nombreTabla];
        }
        public int ejecutarSentenciar(ref SqlCommand cmd, string consultaSql)
        {
            SqlCommand comando = new SqlCommand();
            comando=cmd;
            comando.Connection=ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSql;
            int numFilas = comando.ExecuteNonQuery();
            return numFilas;
        }
        public bool existe(string consultaSql)
        {
            Boolean estado = false;
            SqlCommand comando = new SqlCommand(consultaSql, ObtenerConexion());
            SqlDataReader lectura = comando.ExecuteReader();
            if (lectura.Read())
                estado = true;
            return estado;
        }
    }
}
