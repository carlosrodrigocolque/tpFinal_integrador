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
    public class NegocioModoPorJuego
    {
        public bool agregarModoPorjuego(CategoriaPorJuego obj)
        {
            DatosCategoriaPorJuego conex = new DatosCategoriaPorJuego();
            if (conex.existeCategoriasPorJuegos(obj) == false)
                return Convert.ToBoolean(conex.agregarCategoriasPorJuegos(obj));
            return false;
        }
        public bool agregarModoPorJuego(List<ModoPorJuego> obj)
        {
            DatosModoPorJuego conex = new DatosModoPorJuego();
            ModoPorJuego objMXJ = new ModoPorJuego();
            bool agregado = false;
            foreach (ModoPorJuego variable in obj)
            {
                objMXJ.Cod_ModoDeJuego = variable.Cod_ModoDeJuego.ToString();
                objMXJ.Cod_Juego = variable.Cod_Juego.ToString();
                if (conex.existeModosPorJuegos(objMXJ) == false)
                    agregado = Convert.ToBoolean(conex.agregarCategoriasPorJuegos(objMXJ));
                if (!agregado)
                    break;
            }
            return agregado;
        }
        public bool existeModoPorJuego(ModoPorJuego obj)
        {
            DatosModoPorJuego conex = new DatosModoPorJuego();
            return conex.existeModosPorJuegos(obj);
        }
        public bool existeModoPorJuego(string codJuego, string codCategoria)
        {
            DatosModoPorJuego conex = new DatosModoPorJuego();
            return conex.existeModosPorJuegos(codJuego, codCategoria);
        }
        public bool existeModoPorJuego(List<ModoPorJuego> obj)
        {
            DatosModoPorJuego conex = new DatosModoPorJuego();
            ModoPorJuego objMXJ=new ModoPorJuego();
            foreach (ModoPorJuego variable in obj)
            {
                objMXJ.Cod_ModoDeJuego = variable.Cod_ModoDeJuego.ToString();
                objMXJ.Cod_Juego = variable.Cod_Juego.ToString();
                if (conex.existeModosPorJuegos(objMXJ))
                    return true;
            }
            return false;
        }
    }
}
