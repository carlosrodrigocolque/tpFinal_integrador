using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ModoPorJuego
    {
        /*
        private Juego cod_Juego;
        private ModoDeJuego cod_ModoDeJuego;

        public ModoPorJuego() { }
        public ModoPorJuego(Juego cod_Juego, ModoDeJuego cod_ModoDeJuego)
        {
            this.cod_Juego = cod_Juego;
            this.cod_ModoDeJuego = cod_ModoDeJuego;
        }
        public string Cod_Juego { get { return cod_Juego.CodJuego; } set { cod_Juego.CodJuego = value; } }
        public string Cod_ModoDeJuego { get { return cod_ModoDeJuego.Id_Modo; } set { cod_ModoDeJuego.Id_Modo = value; } }
        */
        /***********/
        private string cod_Juego;
        private string cod_ModoDeJuego;

        public ModoPorJuego() { }
        public ModoPorJuego(ref Juego cod_Juego, ref ModoDeJuego cod_ModoDeJuego)
        {
            this.Cod_Juego = cod_Juego.CodJuego;
            this.Cod_ModoDeJuego = cod_ModoDeJuego.Id_Modo;
        }

        public string Cod_Juego { get => cod_Juego; set => cod_Juego = value; }
        public string Cod_ModoDeJuego { get => cod_ModoDeJuego; set => cod_ModoDeJuego = value; }
        /******
        public string Cod_Juego { get { return cod_Juego.CodJuego; } set { cod_Juego.CodJuego = value; } }
        public string Cod_ModoDeJuego { get { return cod_ModoDeJuego.Id_Modo; } set { cod_ModoDeJuego.Id_Modo = value; } }
        ******/
    }
}
