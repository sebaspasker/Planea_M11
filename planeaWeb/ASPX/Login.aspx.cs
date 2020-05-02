using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.OTHER;

namespace planeaWeb
{
    // TODO Comentar
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginFunction(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nombre_usuario = NombreUsuario.Text;
            
            FormatoFiltrado filtrado = new FormatoFiltrado();
            string mensaje_filtrado = filtrado.FiltradoUsuario(en, true);
            if(mensaje_filtrado == "TODO_OK")
            {
                if(en.SeleccionarUsuario())
                {
                    if(en.password == Password.Text)
                    {
                        Response.Redirect("~/ASPX/principal2.aspx?nomUsu=" + Server.UrlEncode(en.nombre_usuario));
                    }
                    else
                    {
                        ErrorLogin.Text = "El usuario o contraseña es incorrecto";
                    }
                }
                else
                {
                    ErrorLogin.Text = "El usuario u contraseña es incorrecto";
                }
            } 
            else
            {
                ErrorLogin.Text = mensaje_filtrado;
            }
        }
    }
}