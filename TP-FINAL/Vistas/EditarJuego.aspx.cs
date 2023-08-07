using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;
using Entidades;

namespace Vistas
{
    public partial class EditarJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CargarGrillaCompleta();
            }
        }
        protected void CargarGrillaCompleta()
        {
            negocioJuegos nj = new negocioJuegos();
            grdEditar.DataSource = nj.TodosLosJuegos();
            grdEditar.DataBind();
        }
        protected void Logo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void grdEditar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEditar.PageIndex = e.NewPageIndex;
            CargarGrillaCompleta();

        }
    }
}