using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb.ASPX {
    public partial class principal2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre_usuario = Request.QueryString["nomUsu"];
            string login_bool = Request.QueryString["login_bool"];
            if(nombre_usuario != "" && login_bool != "")
            {
                ENUsuario enu = new ENUsuario();
                enu.nombre_usuario = nombre_usuario;
                if(login_bool == "True" && enu.SeleccionarUsuario())
                {
                    PrintNombreUsuario.Text = Request.QueryString["nomUsu"];
                } 
                else
                {
                    Response.Redirect("~/ASPX/principal1.aspx");
                }
            }
            else
            {
                Response.Redirect("~/ASPX/principal1.aspx");
            }
        }
    }
}