using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb.ASPX {
    public partial class principal2 : System.Web.UI.Page {
        /// <summary>
        ///  Comprueba que se ha metido un nombre de usuario y es correcto, sino lo redirecciona a principal1.aspx
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre_usuario = Session["nombre_usuario"].ToString();
            if(!String.IsNullOrEmpty(nombre_usuario))
            {
                ENUsuario enu = new ENUsuario();
                enu.nombre_usuario = nombre_usuario;
                if(enu.SeleccionarUsuario())
                {
                    PrintNombreUsuario.Text = nombre_usuario;
                    HttpCookie userCookie;
                    userCookie = Request.Cookies["nombre_usuario"];
                    if(userCookie != null) 
                    {
                        userCookie = new HttpCookie("nombre_usuario", nombre_usuario);
                        userCookie.Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies.Add(userCookie);
                    }
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