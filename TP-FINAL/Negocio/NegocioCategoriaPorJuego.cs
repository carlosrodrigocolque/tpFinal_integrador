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
    public class NegocioCategoriaPorJuego
    {
        public bool agregarCategoriaPorJuego(CategoriaPorJuego obj)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            if (conex.existeCategoriasPorJuegos(obj) == false)
                return Convert.ToBoolean(conex.agregarCategoriasPorJuegos(obj));
            return false;
        }
        public bool agregarCategoriaPorJuego(List<CategoriaPorJuego> obj)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            CategoriaPorJuego objCXJ = new CategoriaPorJuego();
            bool agregado=false;
            foreach (CategoriaPorJuego variable in obj)
            {
                objCXJ.Id_Categoria = variable.Id_Categoria.ToString();
                objCXJ.Id_Juego = variable.Id_Juego.ToString();
                if (conex.existeCategoriasPorJuegos(objCXJ) == false)
                    agregado = Convert.ToBoolean(conex.agregarCategoriasPorJuegos(objCXJ));
                if (!agregado)
                    break;
            }
            return agregado;
        }
        public bool existeCategoriaPorJuego(CategoriaPorJuego obj)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            return conex.existeCategoriasPorJuegos(obj);
        }
        public bool existeCategoriaPorJuego(string codJuego, string codCategoria)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            return conex.existeCategoriasPorJuegos(codJuego,codCategoria);
        }
        public bool existeCategoriaPorJuego(List<CategoriaPorJuego> obj)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            CategoriaPorJuego objCXJ = new CategoriaPorJuego();
            foreach (CategoriaPorJuego variable in obj)
            {
                objCXJ.Id_Categoria = variable.Id_Categoria.ToString();
                objCXJ.Id_Juego = variable.Id_Juego.ToString();
                if (conex.existeCategoriasPorJuegos(objCXJ)) 
                    return true;
            }
            return false;
        }
    }
}
