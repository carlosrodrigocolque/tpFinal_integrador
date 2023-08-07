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
    public class DatosPlataformaPorJuego
    {
        private Conexion conex = new Conexion();

        public DataTable getTablaPlataformaPorJuegos()
        {
            DataTable tabla = conex.obtenerTaba("PlataformaPorJuegos", "select * from PlataformasxJuegos");
            return tabla;
        }
        public DataTable getTablaPlataformaPorJuegos(PlataformaPorJuego obj)
        {
            DataTable tabla = conex.obtenerTaba("PlataformaPorJuegos", "select * from PlataformasxJuegos where CodJuego_JU_PXJ = '" + obj.Id_Juego + "' and CodPlataforma_PL_PXJ = '" + obj.Id_Plataforma + "'");
            return tabla;
        }
        public DataTable getTablaPlataformaPorJuegos(string codJuego, string codPlataforma)
        {
            DataTable tabla = conex.obtenerTaba("PlataformaPorJuegos", "select * from PlataformasxJuegos where CodJuego_JU_PXJ = '" + codJuego + "' and CodPlataforma_PL_PXJ = '" + codPlataforma + "'");
            return tabla;
        }
        public bool existeCodPlataformaPorJuegos(PlataformaPorJuego obj)
        {
            string consultaSql = ""
                +"select * from PlataformasxJuegos where CodJuego_JU_PXJ = '" + obj.Id_Juego + "' and CodPlataforma_PL_PXJ = '" + obj.Id_Plataforma + "'";
            return conex.existe(consultaSql);
        }
        public bool existeCodPlataformaPorJuegos(string codJuego, string codPlataforma)
        {
            string consultaSql = ""
                + "select * from PlataformasxJuegos where CodJuego_JU_PXJ = '" + codJuego + "' and CodPlataforma_PL_PXJ = '" + codPlataforma + "'";
            return conex.existe(consultaSql);
        }
        public int agregarPlataformaPorJuego(PlataformaPorJuego obj)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosJuego(ref comando, obj);
            return conex.ejecutarSentenciar(ref comando, "" +
                "insert into PlataformasxJuegos (CodJuego_JU_PXJ, CodPlataforma_PL_PXJ, Stock_PXJ, PrecioUnitario_PXJ, Activo_PXJ) " +
                "values ( @CodJuego, @CodPlataforma, @Stock, @Precio, @Activo)");
        }
        public void armarParametrosJuego(ref SqlCommand comando, PlataformaPorJuego obj)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodJuego", SqlDbType.NVarChar);
            parametros.Value = obj.Id_Juego;
            parametros = comando.Parameters.Add("@CodPlataforma", SqlDbType.NVarChar);
            parametros.Value = obj.Id_Plataforma;
            parametros = comando.Parameters.Add("@Stock", SqlDbType.Int);
            parametros.Value = obj.Stock;
            parametros = comando.Parameters.Add("@Precio", SqlDbType.Int);
            parametros.Value = obj.PrecioUnitario;
            parametros = comando.Parameters.Add("@Activo", SqlDbType.Bit);
            parametros.Value = obj.Activo;
        }
    }
}
