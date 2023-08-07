using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlataformaPorJuego
    {
        private string id_Juego;
        private string id_Plataforma;
        private int stock;
        private int precioUnitario;
        private bool activo;

        public PlataformaPorJuego() { }
        public PlataformaPorJuego(string id_Juego, string id_Plataforma, int stock, int precioUnitario, bool activo)
        {
            this.id_Juego = id_Juego;
            this.id_Plataforma = id_Plataforma;
            this.stock = stock;
            this.precioUnitario = precioUnitario;
            this.activo = activo;
        }

        public string Id_Juego { get => id_Juego; set => id_Juego = value; }
        public string Id_Plataforma { get => id_Plataforma; set => id_Plataforma = value; }
        public int Stock { get => stock; set => stock = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
