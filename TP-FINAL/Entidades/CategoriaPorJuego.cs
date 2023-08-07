using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaPorJuego
    {
        private string id_Categoria;
        private string id_Juego;

        public CategoriaPorJuego() { }
        public CategoriaPorJuego(string id_Categoria, string id_Juego)
        {
            this.id_Categoria = id_Categoria;
            this.id_Juego = id_Juego;
        }

        public string Id_Categoria { get { return id_Categoria; } set { id_Categoria = value; } }
        public string Id_Juego { get { return id_Juego; } set { id_Juego = value; } }
    }
}
