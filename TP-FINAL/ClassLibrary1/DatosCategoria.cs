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
    public class DatosCategoria
    {
        private Conexion conex = new Conexion();

        public DataTable getTabaCategorias()
        { 
            DataTable tabla = conex.obtenerTaba("Categoria", "select * from Categorias");
            return tabla;
        }
        public DataTable getTablaCategorias(Categoria obj)
        {
            DataTable tabla = conex.obtenerTaba("Categoria", "select * from Categorias where CodCategoria_CT = '" + obj.CodCategoria + "'");
            return tabla;
        }
        public DataTable getTablaCategorias(string codCategoria)
        {
            DataTable tabla = conex.obtenerTaba("Categoria", "select * from Categorias where CodCategoria_CT = '" + codCategoria + "'");
            return tabla;
        }
        public bool existeCategoria(Categoria obj)
        {
            string consultaSql = ""
                + "select * from Categorias where CodCategoria_CT = '" + obj.CodCategoria + "'";
            return conex.existe(consultaSql);
        }
        public bool existeCategoria(string codCategoria)
        {
            string consultaSql = ""
                + "select * from Categorias where CodCategorias_CT = '" + codCategoria + "'";
            return conex.existe(consultaSql);
        }
        public int agregarCategoria(Categoria obj)
        {
            SqlCommand comando = new SqlCommand();
            armarParametrosCategoria(ref comando, obj);
            return conex.ejecutarSentenciar(ref comando, "" +
                "insert into Categorias (CodCategoria_CT, NombreDeCategoria_CT) " +
                "values ( @CodCategoria, @NombreCategoria)");
        }
        public void armarParametrosCategoria(ref SqlCommand comando, Categoria obj)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodCategoria", SqlDbType.NVarChar);
            parametros.Value = obj.CodCategoria;
            parametros = comando.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
            parametros.Value = obj.NombreCategoria;
        }
    }
}
