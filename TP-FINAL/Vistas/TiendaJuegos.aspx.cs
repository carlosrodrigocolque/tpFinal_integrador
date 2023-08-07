using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class TiendaJuegos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack == false)
            //{
            //    CargarListaCompleta();
            //}
        }
        //protected void CargarListaCompleta()
        //{
        //    negocioJuegos nj = new negocioJuegos();
        //    listJuegos.DataSource = nj.TodosLosJuegos();
        //    listJuegos.DataBind();
        //}
        protected void Logo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Inicio.aspx");
            
        }
    }
}